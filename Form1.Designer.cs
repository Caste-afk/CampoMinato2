namespace CampoMinato2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_Impostazioni = new Button();
            btn_esci = new Button();
            btn_gioca = new Button();
            EntrateEsplosive = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)EntrateEsplosive).BeginInit();
            SuspendLayout();
            // 
            // btn_Impostazioni
            // 
            btn_Impostazioni.Location = new Point(502, 401);
            btn_Impostazioni.Name = "btn_Impostazioni";
            btn_Impostazioni.Size = new Size(94, 29);
            btn_Impostazioni.TabIndex = 0;
            btn_Impostazioni.Text = "Impostazioni";
            btn_Impostazioni.UseVisualStyleBackColor = true;
            btn_Impostazioni.Click += btn_Impostazioni_Click;
            // 
            // btn_esci
            // 
            btn_esci.Location = new Point(570, 593);
            btn_esci.Name = "btn_esci";
            btn_esci.Size = new Size(209, 60);
            btn_esci.TabIndex = 2;
            btn_esci.Text = "Esci";
            btn_esci.UseVisualStyleBackColor = true;
            btn_esci.Click += btn_esci_Click;
            // 
            // btn_gioca
            // 
            btn_gioca.Location = new Point(53, 318);
            btn_gioca.Name = "btn_gioca";
            btn_gioca.Size = new Size(320, 100);
            btn_gioca.TabIndex = 3;
            btn_gioca.UseVisualStyleBackColor = true;
            btn_gioca.Click += btn_gioca_Click;
            // 
            // EntrateEsplosive
            // 
            EntrateEsplosive.Image = (Image)resources.GetObject("EntrateEsplosive.Image");
            EntrateEsplosive.Location = new Point(317, 46);
            EntrateEsplosive.Name = "EntrateEsplosive";
            EntrateEsplosive.Size = new Size(585, 310);
            EntrateEsplosive.SizeMode = PictureBoxSizeMode.StretchImage;
            EntrateEsplosive.TabIndex = 4;
            EntrateEsplosive.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1146, 679);
            Controls.Add(EntrateEsplosive);
            Controls.Add(btn_gioca);
            Controls.Add(btn_esci);
            Controls.Add(btn_Impostazioni);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)EntrateEsplosive).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Impostazioni;
        private Button btn_impostazioni;
        private Button btn_esci;
        private Button btn_gioca;
        private PictureBox EntrateEsplosive;
    }
}
