namespace CampoMinato2
{
    partial class FSalva
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
            btn_Salva = new Button();
            tbx_NomeFile = new TextBox();
            SuspendLayout();
            // 
            // btn_Salva
            // 
            btn_Salva.Location = new Point(20, 85);
            btn_Salva.Margin = new Padding(3, 2, 3, 2);
            btn_Salva.Name = "btn_Salva";
            btn_Salva.Size = new Size(207, 46);
            btn_Salva.TabIndex = 1;
            btn_Salva.Text = "button1";
            btn_Salva.UseVisualStyleBackColor = true;
            btn_Salva.Click += btn_Salva_Click;
            // 
            // tbx_NomeFile
            // 
            tbx_NomeFile.Location = new Point(368, 110);
            tbx_NomeFile.Margin = new Padding(3, 2, 3, 2);
            tbx_NomeFile.Name = "tbx_NomeFile";
            tbx_NomeFile.Size = new Size(110, 23);
            tbx_NomeFile.TabIndex = 0;
            // 
            // FSalva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 401);
            Controls.Add(tbx_NomeFile);
            Controls.Add(btn_Salva);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FSalva";
            Text = "FSalva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Salva;
        private TextBox tbx_NomeFile;
    }
}