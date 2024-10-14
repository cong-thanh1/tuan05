namespace Lab05
{
    partial class frmStudent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSinhVien = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.picSinhVien = new System.Windows.Forms.PictureBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.lblDiem = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChoice = new System.Windows.Forms.Button();
            this.chkUnregisterMajor = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.grpSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKýToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // đăngKýToolStripMenuItem
            // 
            this.đăngKýToolStripMenuItem.Name = "đăngKýToolStripMenuItem";
            this.đăngKýToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.đăngKýToolStripMenuItem.Text = "Đăng ký";
            this.đăngKýToolStripMenuItem.Click += new System.EventHandler(this.đăngKýToolStripMenuItem_Click);
            // 
            // grpSinhVien
            // 
            this.grpSinhVien.Controls.Add(this.btnDel);
            this.grpSinhVien.Controls.Add(this.btnAdd);
            this.grpSinhVien.Controls.Add(this.picSinhVien);
            this.grpSinhVien.Controls.Add(this.cmbKhoa);
            this.grpSinhVien.Controls.Add(this.label4);
            this.grpSinhVien.Controls.Add(this.lblKhoa);
            this.grpSinhVien.Controls.Add(this.txtDiem);
            this.grpSinhVien.Controls.Add(this.lblDiem);
            this.grpSinhVien.Controls.Add(this.txtName);
            this.grpSinhVien.Controls.Add(this.lblName);
            this.grpSinhVien.Controls.Add(this.txtID);
            this.grpSinhVien.Controls.Add(this.lblID);
            this.grpSinhVien.Location = new System.Drawing.Point(12, 95);
            this.grpSinhVien.Name = "grpSinhVien";
            this.grpSinhVien.Size = new System.Drawing.Size(280, 312);
            this.grpSinhVien.TabIndex = 1;
            this.grpSinhVien.TabStop = false;
            this.grpSinhVien.Text = "Thông tin sinh viên";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(148, 270);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(50, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add/Update";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // picSinhVien
            // 
            this.picSinhVien.Location = new System.Drawing.Point(104, 176);
            this.picSinhVien.Name = "picSinhVien";
            this.picSinhVien.Size = new System.Drawing.Size(119, 73);
            this.picSinhVien.TabIndex = 9;
            this.picSinhVien.TabStop = false;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(104, 112);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbKhoa.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ảnh đại diện";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(22, 112);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(32, 13);
            this.lblKhoa.TabIndex = 6;
            this.lblKhoa.Text = "Khoa";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(104, 144);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(100, 20);
            this.txtDiem.TabIndex = 5;
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(22, 144);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(81, 13);
            this.lblDiem.TabIndex = 4;
            this.lblDiem.Text = "Điểm trung bình";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tên sinh viên";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(104, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(22, 44);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(67, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Mã sinh viên";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colKhoa,
            this.colDTB,
            this.colChuyenNganh});
            this.dgvStudent.Location = new System.Drawing.Point(340, 95);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(448, 263);
            this.dgvStudent.TabIndex = 2;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            this.dgvStudent.SelectionChanged += new System.EventHandler(this.dgvStudent_SelectionChanged);
            // 
            // colID
            // 
            this.colID.HeaderText = "MSSV";
            this.colID.Name = "colID";
            // 
            // colName
            // 
            this.colName.HeaderText = "Họ tên";
            this.colName.Name = "colName";
            // 
            // colKhoa
            // 
            this.colKhoa.HeaderText = "Khoa";
            this.colKhoa.Name = "colKhoa";
            // 
            // colDTB
            // 
            this.colDTB.HeaderText = "DTB";
            this.colDTB.Name = "colDTB";
            // 
            // colChuyenNganh
            // 
            this.colChuyenNganh.HeaderText = "Chuyên ngành";
            this.colChuyenNganh.Name = "colChuyenNganh";
            // 
            // btnChoice
            // 
            this.btnChoice.Location = new System.Drawing.Point(241, 299);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(30, 23);
            this.btnChoice.TabIndex = 12;
            this.btnChoice.Text = "...";
            this.btnChoice.UseVisualStyleBackColor = true;
            this.btnChoice.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // chkUnregisterMajor
            // 
            this.chkUnregisterMajor.AutoSize = true;
            this.chkUnregisterMajor.Location = new System.Drawing.Point(624, 72);
            this.chkUnregisterMajor.Name = "chkUnregisterMajor";
            this.chkUnregisterMajor.Size = new System.Drawing.Size(164, 17);
            this.chkUnregisterMajor.TabIndex = 13;
            this.chkUnregisterMajor.Text = "Chưa đăng ký chuyên ngành";
            this.chkUnregisterMajor.UseVisualStyleBackColor = true;
            this.chkUnregisterMajor.CheckedChanged += new System.EventHandler(this.chkUnregisterMajor_CheckedChanged_1);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkUnregisterMajor);
            this.Controls.Add(this.btnChoice);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.grpSinhVien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStudent";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSinhVien.ResumeLayout(false);
            this.grpSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpSinhVien;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox picSinhVien;
        private System.Windows.Forms.Button btnChoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenNganh;
        private System.Windows.Forms.CheckBox chkUnregisterMajor;
        private System.Windows.Forms.ToolStripMenuItem đăngKýToolStripMenuItem;
    }
}

