namespace lab04
{
    partial class Form1
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
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSSV,
            this.colHoten,
            this.colGioiTinh,
            this.colDTB,
            this.colKhoa});
            this.dgvStudent.Location = new System.Drawing.Point(304, 30);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.Size = new System.Drawing.Size(723, 370);
            this.dgvStudent.TabIndex = 0;
            // 
            // colMSSV
            // 
            this.colMSSV.HeaderText = "Mã";
            this.colMSSV.MinimumWidth = 6;
            this.colMSSV.Name = "colMSSV";
            this.colMSSV.Width = 125;
            // 
            // colHoten
            // 
            this.colHoten.HeaderText = "Họ và tên";
            this.colHoten.MinimumWidth = 6;
            this.colHoten.Name = "colHoten";
            this.colHoten.Width = 125;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Width = 125;
            // 
            // colDTB
            // 
            this.colDTB.HeaderText = "DTB";
            this.colDTB.MinimumWidth = 6;
            this.colDTB.Name = "colDTB";
            this.colDTB.Width = 125;
            // 
            // colKhoa
            // 
            this.colKhoa.HeaderText = "Khoa";
            this.colKhoa.MinimumWidth = 6;
            this.colKhoa.Name = "colKhoa";
            this.colKhoa.Width = 125;
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(81, 30);
            this.cmbFaculty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(160, 24);
            this.cmbFaculty.TabIndex = 1;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(23, 340);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(48, 34);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(207, 340);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(57, 34);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(108, 340);
            this.btnUpd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(55, 34);
            this.btnUpd.TabIndex = 4;
            this.btnUpd.Text = "Sửa";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(96, 79);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(145, 22);
            this.txtFullName.TabIndex = 5;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(96, 127);
            this.txtGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(145, 22);
            this.txtGender.TabIndex = 6;
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(96, 164);
            this.txtAverageScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(145, 22);
            this.txtAverageScore.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(96, 205);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 22);
            this.textBox4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtAverageScore);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.dgvStudent);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.TextBox textBox4;
    }
}

