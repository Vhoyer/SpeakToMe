namespace SpeakToMe
{
    partial class fmrMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSpeech = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVoice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGender = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVoiceName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVoiceID = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSelectVoice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.installOtherVoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tkbVolume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.flp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSpeech
            // 
            this.txtSpeech.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpeech.Location = new System.Drawing.Point(61, 40);
            this.txtSpeech.Multiline = true;
            this.txtSpeech.Name = "txtSpeech";
            this.txtSpeech.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSpeech.Size = new System.Drawing.Size(596, 396);
            this.txtSpeech.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiVoice});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(103, 22);
            this.tsmiOpen.Text = "Open";
            // 
            // tsmiVoice
            // 
            this.tsmiVoice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLanguage,
            this.tsmiGender,
            this.tsmiVoiceName,
            this.tsmiVoiceID,
            this.toolStripMenuItem1,
            this.tsmiSelectVoice,
            this.toolStripMenuItem2,
            this.installOtherVoiceToolStripMenuItem});
            this.tsmiVoice.Name = "tsmiVoice";
            this.tsmiVoice.Size = new System.Drawing.Size(47, 20);
            this.tsmiVoice.Text = "Voice";
            // 
            // tsmiLanguage
            // 
            this.tsmiLanguage.Name = "tsmiLanguage";
            this.tsmiLanguage.Size = new System.Drawing.Size(176, 22);
            this.tsmiLanguage.Text = "Language: ";
            // 
            // tsmiGender
            // 
            this.tsmiGender.Name = "tsmiGender";
            this.tsmiGender.Size = new System.Drawing.Size(176, 22);
            this.tsmiGender.Text = "Gender:";
            // 
            // tsmiVoiceName
            // 
            this.tsmiVoiceName.Name = "tsmiVoiceName";
            this.tsmiVoiceName.Size = new System.Drawing.Size(176, 22);
            this.tsmiVoiceName.Text = "Voice Name:";
            // 
            // tsmiVoiceID
            // 
            this.tsmiVoiceID.Name = "tsmiVoiceID";
            this.tsmiVoiceID.Size = new System.Drawing.Size(176, 22);
            this.tsmiVoiceID.Text = "Voice ID:";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 6);
            // 
            // tsmiSelectVoice
            // 
            this.tsmiSelectVoice.Name = "tsmiSelectVoice";
            this.tsmiSelectVoice.Size = new System.Drawing.Size(176, 22);
            this.tsmiSelectVoice.Text = "Select other voice";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 6);
            // 
            // installOtherVoiceToolStripMenuItem
            // 
            this.installOtherVoiceToolStripMenuItem.Name = "installOtherVoiceToolStripMenuItem";
            this.installOtherVoiceToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.installOtherVoiceToolStripMenuItem.Text = "Install other voice...";
            this.installOtherVoiceToolStripMenuItem.Click += new System.EventHandler(this.installOtherVoiceToolStripMenuItem_Click);
            // 
            // flp1
            // 
            this.flp1.Controls.Add(this.btnSpeak);
            this.flp1.Controls.Add(this.btnStop);
            this.flp1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flp1.Location = new System.Drawing.Point(0, 442);
            this.flp1.Name = "flp1";
            this.flp1.Padding = new System.Windows.Forms.Padding(0, 3, 8, 0);
            this.flp1.Size = new System.Drawing.Size(668, 36);
            this.flp1.TabIndex = 2;
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(582, 6);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(75, 23);
            this.btnSpeak.TabIndex = 0;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(501, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tkbVolume
            // 
            this.tkbVolume.LargeChange = 10;
            this.tkbVolume.Location = new System.Drawing.Point(19, 56);
            this.tkbVolume.Maximum = 100;
            this.tkbVolume.Name = "tkbVolume";
            this.tkbVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tkbVolume.Size = new System.Drawing.Size(45, 163);
            this.tkbVolume.SmallChange = 5;
            this.tkbVolume.TabIndex = 0;
            this.tkbVolume.TickFrequency = 10;
            this.tkbVolume.Value = 5;
            this.tkbVolume.Scroll += new System.EventHandler(this.tkbVolume_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Volume";
            // 
            // fmrMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flp1);
            this.Controls.Add(this.txtSpeech);
            this.Controls.Add(this.tkbVolume);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmrMain";
            this.Text = "Speak to me";
            this.Load += new System.EventHandler(this.fmrMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tkbVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSpeech;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiVoice;
        private System.Windows.Forms.FlowLayoutPanel flp1;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ToolStripMenuItem tsmiLanguage;
        private System.Windows.Forms.ToolStripMenuItem tsmiGender;
        private System.Windows.Forms.ToolStripMenuItem tsmiVoiceName;
        private System.Windows.Forms.ToolStripMenuItem tsmiVoiceID;
        private System.Windows.Forms.TrackBar tkbVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectVoice;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem installOtherVoiceToolStripMenuItem;
    }
}

