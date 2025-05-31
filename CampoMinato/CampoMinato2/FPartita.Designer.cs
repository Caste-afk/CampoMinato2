namespace CampoMinato2
{
    partial class FPartita
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
            dgv_main = new DataGridView();
            btn_Informazioni = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_main).BeginInit();
            SuspendLayout();
            // 
            // dgv_main
            // 
            dgv_main.AllowUserToAddRows = false;
            dgv_main.AllowUserToDeleteRows = false;
            dgv_main.AllowUserToResizeColumns = false;
            dgv_main.AllowUserToResizeRows = false;
            dgv_main.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_main.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_main.ColumnHeadersVisible = false;
            dgv_main.Cursor = Cursors.Hand;
            dgv_main.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_main.Location = new Point(111, 36);
            dgv_main.Margin = new Padding(3, 4, 3, 4);
            dgv_main.MultiSelect = false;
            dgv_main.Name = "dgv_main";
            dgv_main.RowHeadersVisible = false;
            dgv_main.RowHeadersWidth = 51;
            dgv_main.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_main.RowTemplate.Height = 25;
            dgv_main.ScrollBars = ScrollBars.None;
            dgv_main.Size = new Size(750, 750);
            dgv_main.TabIndex = 0;
            dgv_main.CellContentClick += dgv_main_CellClick;
            // 
            // btn_Informazioni
            // 
            btn_Informazioni.BackColor = Color.Transparent;
            btn_Informazioni.Location = new Point(832, 12);
            btn_Informazioni.Name = "btn_Informazioni";
            btn_Informazioni.Size = new Size(150, 150);
            btn_Informazioni.TabIndex = 1;
            btn_Informazioni.UseVisualStyleBackColor = false;
            btn_Informazioni.Click += btn_Informazioni_Click;
            // 
            // FPartita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 793);
            Controls.Add(btn_Informazioni);
            Controls.Add(dgv_main);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FPartita";
            Text = "FPartita";
            Load += FPartita_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_main).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_main;
        private Button btn_Informazioni;
    }
}