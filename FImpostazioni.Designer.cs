namespace CampoMinato2
{
    partial class FImpostazioni
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
            trk_AudioMusica = new TrackBar();
            lbl_Musica = new Label();
            label1 = new Label();
            label2 = new Label();
            btn_MuteMusic = new Button();
            btn_MaxMusic = new Button();
            btn_MaxSounds = new Button();
            btn_MuteSounds = new Button();
            label3 = new Label();
            lbl_Suoni = new Label();
            trk_Sounds = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trk_AudioMusica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trk_Sounds).BeginInit();
            SuspendLayout();
            // 
            // trk_AudioMusica
            // 
            trk_AudioMusica.Cursor = Cursors.Hand;
            trk_AudioMusica.Location = new Point(201, 143);
            trk_AudioMusica.Margin = new Padding(0);
            trk_AudioMusica.Maximum = 100;
            trk_AudioMusica.Name = "trk_AudioMusica";
            trk_AudioMusica.Size = new Size(399, 56);
            trk_AudioMusica.TabIndex = 0;
            trk_AudioMusica.Value = 100;
            trk_AudioMusica.Scroll += trk_AudioMusica_Scroll;
            // 
            // lbl_Musica
            // 
            lbl_Musica.AutoSize = true;
            lbl_Musica.BackColor = Color.Transparent;
            lbl_Musica.Location = new Point(171, 120);
            lbl_Musica.Name = "lbl_Musica";
            lbl_Musica.Size = new Size(50, 20);
            lbl_Musica.TabIndex = 1;
            lbl_Musica.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(281, 27);
            label1.Name = "label1";
            label1.Size = new Size(238, 31);
            label1.TabIndex = 2;
            label1.Text = "IMPOSTAZIONI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(67, 94);
            label2.Name = "label2";
            label2.Size = new Size(217, 25);
            label2.TabIndex = 3;
            label2.Text = "VOLUME MUSICA";
            // 
            // btn_MuteMusic
            // 
            btn_MuteMusic.BackColor = Color.Transparent;
            btn_MuteMusic.Location = new Point(114, 143);
            btn_MuteMusic.Name = "btn_MuteMusic";
            btn_MuteMusic.Size = new Size(40, 40);
            btn_MuteMusic.TabIndex = 4;
            btn_MuteMusic.UseVisualStyleBackColor = false;
            btn_MuteMusic.Click += btn_MuteMusic_Click;
            // 
            // btn_MaxMusic
            // 
            btn_MaxMusic.BackColor = Color.Transparent;
            btn_MaxMusic.Location = new Point(647, 143);
            btn_MaxMusic.Name = "btn_MaxMusic";
            btn_MaxMusic.Size = new Size(40, 40);
            btn_MaxMusic.TabIndex = 5;
            btn_MaxMusic.UseVisualStyleBackColor = false;
            btn_MaxMusic.Click += btn_MaxMusic_Click;
            // 
            // btn_MaxSounds
            // 
            btn_MaxSounds.BackColor = Color.Transparent;
            btn_MaxSounds.Location = new Point(647, 255);
            btn_MaxSounds.Name = "btn_MaxSounds";
            btn_MaxSounds.Size = new Size(40, 40);
            btn_MaxSounds.TabIndex = 10;
            btn_MaxSounds.UseVisualStyleBackColor = false;
            btn_MaxSounds.Click += btn_MaxSounds_Click;
            // 
            // btn_MuteSounds
            // 
            btn_MuteSounds.BackColor = Color.Transparent;
            btn_MuteSounds.Location = new Point(114, 255);
            btn_MuteSounds.Name = "btn_MuteSounds";
            btn_MuteSounds.Size = new Size(40, 40);
            btn_MuteSounds.TabIndex = 9;
            btn_MuteSounds.UseVisualStyleBackColor = false;
            btn_MuteSounds.Click += btn_MuteSounds_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(67, 206);
            label3.Name = "label3";
            label3.Size = new Size(198, 25);
            label3.TabIndex = 8;
            label3.Text = "VOLUME SUONI";
            // 
            // lbl_Suoni
            // 
            lbl_Suoni.AutoSize = true;
            lbl_Suoni.BackColor = Color.Transparent;
            lbl_Suoni.Location = new Point(171, 232);
            lbl_Suoni.Name = "lbl_Suoni";
            lbl_Suoni.Size = new Size(50, 20);
            lbl_Suoni.TabIndex = 7;
            lbl_Suoni.Text = "label1";
            // 
            // trk_Sounds
            // 
            trk_Sounds.Cursor = Cursors.Hand;
            trk_Sounds.Location = new Point(201, 255);
            trk_Sounds.Margin = new Padding(0);
            trk_Sounds.Maximum = 100;
            trk_Sounds.Name = "trk_Sounds";
            trk_Sounds.Size = new Size(399, 56);
            trk_Sounds.TabIndex = 6;
            trk_Sounds.Value = 100;
            trk_Sounds.Scroll += trk_Sounds_Scroll;
            // 
            // FImpostazioni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_MaxSounds);
            Controls.Add(btn_MuteSounds);
            Controls.Add(label3);
            Controls.Add(lbl_Suoni);
            Controls.Add(trk_Sounds);
            Controls.Add(btn_MaxMusic);
            Controls.Add(btn_MuteMusic);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_Musica);
            Controls.Add(trk_AudioMusica);
            Name = "FImpostazioni";
            Text = "FImpostazioni";
            Load += FImpostazioni_Load;
            ((System.ComponentModel.ISupportInitialize)trk_AudioMusica).EndInit();
            ((System.ComponentModel.ISupportInitialize)trk_Sounds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trk_AudioMusica;
        private Label lbl_Musica;
        private Label label1;
        private Label label2;
        private Button btn_MuteMusic;
        private Button btn_MaxMusic;
        private Button btn_MaxSounds;
        private Button btn_MuteSounds;
        private Label label3;
        private Label lbl_Suoni;
        private TrackBar trk_Sounds;
    }
}