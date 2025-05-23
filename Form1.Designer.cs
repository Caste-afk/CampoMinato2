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
            btn_Impostazioni = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Impostazioni
            // 
            btn_Impostazioni.Location = new Point(778, 378);
            btn_Impostazioni.Name = "btn_Impostazioni";
            btn_Impostazioni.Size = new Size(94, 29);
            btn_Impostazioni.TabIndex = 0;
            btn_Impostazioni.Text = "button1";
            btn_Impostazioni.UseVisualStyleBackColor = true;
            btn_Impostazioni.Click += btn_Impostazioni_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._4649c4a3_3e0c_4db7_8abe_8205bed2de2f_removebg_preview;
            pictureBox1.Location = new Point(243, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Impostazioni);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Impostazioni;
        private PictureBox pictureBox1;
    }
}