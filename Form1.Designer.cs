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
            lbl_Titolo = new Label();
            btn_impostazioni = new Button();
            btn_esci = new Button();
            btn_gioca = new Button();
            SuspendLayout();
            // 
            // lbl_Titolo
            // 
            lbl_Titolo.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_Titolo.Location = new Point(191, 9);
            lbl_Titolo.Name = "lbl_Titolo";
            lbl_Titolo.Size = new Size(445, 99);
            lbl_Titolo.TabIndex = 0;
            lbl_Titolo.Text = "Campo Minato";
            lbl_Titolo.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_impostazioni
            // 
            btn_impostazioni.Location = new Point(306, 247);
            btn_impostazioni.Name = "btn_impostazioni";
            btn_impostazioni.Size = new Size(209, 60);
            btn_impostazioni.TabIndex = 1;
            btn_impostazioni.Text = "Impostazioni";
            btn_impostazioni.UseVisualStyleBackColor = true;
            // 
            // btn_esci
            // 
            btn_esci.Location = new Point(306, 313);
            btn_esci.Name = "btn_esci";
            btn_esci.Size = new Size(209, 60);
            btn_esci.TabIndex = 2;
            btn_esci.Text = "Esci";
            btn_esci.UseVisualStyleBackColor = true;
            // 
            // btn_gioca
            // 
            btn_gioca.Location = new Point(306, 181);
            btn_gioca.Name = "btn_gioca";
            btn_gioca.Size = new Size(209, 60);
            btn_gioca.TabIndex = 3;
            btn_gioca.Text = "Gioca";
            btn_gioca.UseVisualStyleBackColor = true;
            btn_gioca.Click += btn_gioca_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_gioca);
            Controls.Add(btn_esci);
            Controls.Add(btn_impostazioni);
            Controls.Add(lbl_Titolo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Titolo;
        private Button btn_impostazioni;
        private Button btn_esci;
        private Button btn_gioca;
    }
}