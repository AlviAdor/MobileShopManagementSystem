namespace MobileShopMangementSystem.AllUserControl
{
    partial class UC_DeletePhoneRecord
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DeletePhoneRecord));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            labelTOSET = new Label();
            DataGridView12 = new Guna.UI2.WinForms.Guna2DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)DataGridView12).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(347, 43);
            label1.TabIndex = 2;
            label1.Text = "Delete Phone Records";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSearch
            // 
            txtSearch.CustomizableEdges = customizableEdges1;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(522, 169);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(319, 36);
            txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // labelTOSET
            // 
            labelTOSET.AutoSize = true;
            labelTOSET.Font = new Font("Segoe UI", 11.25F);
            labelTOSET.Location = new Point(522, 138);
            labelTOSET.Name = "labelTOSET";
            labelTOSET.Size = new Size(137, 20);
            labelTOSET.TabIndex = 6;
            labelTOSET.Text = "Company or Model";
            // 
            // DataGridView12
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView12.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView12.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView12.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView12.ColumnHeadersHeight = 4;
            DataGridView12.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView12.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView12.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView12.Location = new Point(39, 285);
            DataGridView12.Margin = new Padding(13);
            DataGridView12.Name = "DataGridView12";
            DataGridView12.RowHeadersVisible = false;
            DataGridView12.Size = new Size(1249, 413);
            DataGridView12.TabIndex = 8;
            DataGridView12.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView12.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView12.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView12.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView12.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView12.ThemeStyle.BackColor = Color.White;
            DataGridView12.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView12.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView12.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView12.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DataGridView12.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView12.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView12.ThemeStyle.HeaderStyle.Height = 4;
            DataGridView12.ThemeStyle.ReadOnly = false;
            DataGridView12.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView12.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView12.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DataGridView12.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView12.ThemeStyle.RowsStyle.Height = 25;
            DataGridView12.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView12.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView12.CellClick += DataGridView12_CellClick;
            DataGridView12.Enter += guna2DataGridView1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 711);
            label2.Name = "label2";
            label2.Size = new Size(127, 17);
            label2.TabIndex = 9;
            label2.Text = "Delete INSTRUCTION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.ForeColor = Color.FromArgb(0, 118, 221);
            label3.Location = new Point(39, 734);
            label3.Name = "label3";
            label3.Size = new Size(268, 20);
            label3.TabIndex = 10;
            label3.Text = "To Delete any Record Just Click on Row";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(1049, 711);
            label4.Name = "label4";
            label4.Size = new Size(239, 20);
            label4.TabIndex = 11;
            label4.Text = "*Deleted data can not be Resotred";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 26;
            guna2Elipse1.TargetControl = this;
            // 
            // UC_DeletePhoneRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DataGridView12);
            Controls.Add(txtSearch);
            Controls.Add(labelTOSET);
            Controls.Add(label1);
            Name = "UC_DeletePhoneRecord";
            Size = new Size(1815, 1450);
            ((System.ComponentModel.ISupportInitialize)DataGridView12).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Label labelTOSET;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView12;
        private Label label2;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
