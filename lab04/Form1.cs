using lab04.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04
{
    public partial class Form1 : Form
    {
        Model1 context = new Model1();

        //1. lấy tất cả các sinh viên từ bảng Student
       
        public Form1()  
        {
            InitializeComponent();
            List<Student> listStudent = context.Students.ToList();
        }

        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cmbFaculty.DataSource = listFalcultys;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }

        //Hàm binding gridView từ list sinh viên
        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                dgvStudent.Rows[index].Cells[2].Value = item.Gender;
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore;
                dgvStudent.Rows[index].Cells[4].Value = item.Faculty.FacultyName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Model1 context = new Model1();
                List<Faculty> listFalcultys = context.Faculties.ToList(); //lấy các khoa
                List<Student> listStudent = context.Students.ToList(); //lấy sinh viên
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }    
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các ô nhập liệu
                string fullName = txtFullName.Text.Trim();
                string gender = txtGender.Text.Trim(); // Nếu bạn dùng ComboBox thì hãy lấy giá trị từ đó
                decimal averageScore;

                // Kiểm tra điểm trung bình có hợp lệ không
                if (!decimal.TryParse(txtAverageScore.Text.Trim(), out averageScore))
                {
                    MessageBox.Show("Vui lòng nhập điểm trung bình hợp lệ.");
                    return;
                }

                int facultyID = (int)cmbFaculty.SelectedValue; // Lấy giá trị ID khoa từ combobox

                // Tạo đối tượng Student mới
                Student newStudent = new Student
                {
                    FullName = fullName,
                    Gender = gender,
                    AverageScore = averageScore,
                    FacultyID = facultyID // Gán ID khoa
                };

                // Thêm sinh viên vào cơ sở dữ liệu
                context.Students.Add(newStudent);
                context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                // Cập nhật lại danh sách sinh viên hiển thị
                List<Student> listStudent = context.Students.ToList();
                BindGrid(listStudent); // Cập nhật DataGridView với danh sách sinh viên mới

                // Xóa thông tin trong TextBox sau khi thêm
                txtFullName.Clear();
                txtGender.Clear();
                txtAverageScore.Clear();

                MessageBox.Show("Thêm sinh viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            } 
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //xóa sinh viên

        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            //sửa sinh viên

        }
    }
}
