namespace Lab05
{
    partial class frmRegister
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
            this.lblDangKy = new System.Windows.Forms.Label();
            this.lblCkhoa = new System.Windows.Forms.Label();
            this.lblChuyenNganh = new System.Windows.Forms.Label();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.btnRegister = new System.Windows.Forms.Button();
            this.colChoose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDangKy
            // 
            this.lblDangKy.AutoSize = true;
            this.lblDangKy.Location = new System.Drawing.Point(263, 75);
            this.lblDangKy.Name = "lblDangKy";
            this.lblDangKy.Size = new System.Drawing.Size(145, 13);
            this.lblDangKy.TabIndex = 0;
            this.lblDangKy.Text = "ĐĂNG KÝ CHUYÊN NGÀNH";
            // 
            // lblCkhoa
            // 
            this.lblCkhoa.AutoSize = true;
            this.lblCkhoa.Location = new System.Drawing.Point(149, 124);
            this.lblCkhoa.Name = "lblCkhoa";
            this.lblCkhoa.Size = new System.Drawing.Size(32, 13);
            this.lblCkhoa.TabIndex = 1;
            this.lblCkhoa.Text = "Khoa";
            // 
            // lblChuyenNganh
            // 
            this.lblChuyenNganh.AutoSize = true;
            this.lblChuyenNganh.Location = new System.Drawing.Point(130, 168);
            this.lblChuyenNganh.Name = "lblChuyenNganh";
            this.lblChuyenNganh.Size = new System.Drawing.Size(76, 13);
            this.lblChuyenNganh.TabIndex = 2;
            this.lblChuyenNganh.Text = "Chuyên ngành";
            this.lblChuyenNganh.Click += new System.EventHandler(this.lblChuyenNganh_Click);
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(212, 124);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(251, 21);
            this.cmbFaculty.TabIndex = 3;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
            // 
            // cmbMajor
            // 
            this.cmbMajor.FormattingEnabled = true;
            this.cmbMajor.Location = new System.Drawing.Point(212, 165);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(251, 21);
            this.cmbMajor.TabIndex = 4;
            this.cmbMajor.SelectedIndexChanged += new System.EventHandler(this.cmbMajor_SelectedIndexChanged);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChoose,
            this.colMSSV,
            this.colNameSV,
            this.colKhoaSV,
            this.colDTB});
            this.dgvStudent.Location = new System.Drawing.Point(12, 192);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(609, 200);
            this.dgvStudent.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(68, 415);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // colChoose
            // 
            this.colChoose.HeaderText = "Chọn";
            this.colChoose.Name = "colChoose";
            // 
            // colMSSV
            // 
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.Name = "colMSSV";
            this.colMSSV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMSSV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colNameSV
            // 
            this.colNameSV.HeaderText = "Họ tên";
            this.colNameSV.Name = "colNameSV";
            this.colNameSV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNameSV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colKhoaSV
            // 
            this.colKhoaSV.HeaderText = "KHoa";
            this.colKhoaSV.Name = "colKhoaSV";
            this.colKhoaSV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colKhoaSV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDTB
            // 
            this.colDTB.HeaderText = "DTB";
            this.colDTB.Name = "colDTB";
            this.colDTB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDTB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.cmbMajor);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.lblChuyenNganh);
            this.Controls.Add(this.lblCkhoa);
            this.Controls.Add(this.lblDangKy);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDangKy;
        private System.Windows.Forms.Label lblCkhoa;
        private System.Windows.Forms.Label lblChuyenNganh;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.ComboBox cmbMajor;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDTB;
    }
}