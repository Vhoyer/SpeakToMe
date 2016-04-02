using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Collections.ObjectModel;

namespace SpeakToMe
{
    public partial class fmrMain : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();

        public fmrMain()
        {
            InitializeComponent();
            synth.VoiceChange += Synth_VoiceChange;
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (txtSpeech.Text == string.Empty)
            {
                MessageBox.Show("Text Box Empty", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string speech = txtSpeech.Text;
            synth.SpeakAsync(speech);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (synth.State == SynthesizerState.Speaking)
            {
                synth.SpeakAsyncCancelAll();
            }
        }

        private void fmrMain_Load(object sender, EventArgs e)
        {
            Synth_VoiceChange(null, null);
            
            ReadOnlyCollection<InstalledVoice> voices = synth.GetInstalledVoices();
            ToolStripMenuItem[] items = new ToolStripMenuItem[voices.Count];
            for (int i = 0; i < voices.Count; i++)
            {
                items[i] = new ToolStripMenuItem(voices[i].VoiceInfo.Description, null, tsmiVoiceSelect_Click, voices[i].VoiceInfo.Name);
                if (synth.Voice.Name == items[i].Name)
                {
                    items[i].Checked = true;
                }
            }
            tsmiSelectVoice.DropDownItems.AddRange(items);
        }

        private void tsmiVoiceSelect_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Checked)
                return;

            synth.SelectVoice((sender as ToolStripMenuItem).Name);
            foreach (var item in tsmiSelectVoice.DropDownItems)
            {
                (item as ToolStripMenuItem).Checked = false;
            }
            (sender as ToolStripMenuItem).Checked = true;
            Synth_VoiceChange(null, null);
        }

        private void tkbVolume_Scroll(object sender, EventArgs e)
        {
            synth.Volume = tkbVolume.Value;
        }

        private void installOtherVoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After installing a voice package you'll have to restart the applicantion", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("https://www.microsoft.com/en-us/download/details.aspx?id=27224");
        }

        private void Synth_VoiceChange(object sender, VoiceChangeEventArgs e)
        {
            tsmiLanguage.Text = "Language: " + synth.Voice.Culture.ToString();
            tsmiGender.Text = "Gender: " + synth.Voice.Gender.ToString();
            tsmiVoiceName.Text = "Voice Name: " + synth.Voice.Name;
            tsmiVoiceID.Text = "Voice ID: " + synth.Voice.Id;
            tkbVolume.Value = synth.Volume;
        }
    }
}
