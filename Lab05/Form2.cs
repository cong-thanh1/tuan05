using Lab05.BUS;
using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class frmRegister : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private readonly MajorService majorService = new MajorService();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            try
            {
                var listFacultys = facultyService.getAll();
                FillFalcultyCombobox(listFacultys);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            this.cmbFaculty.DataSource = listFacultys;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Faculty selectedFaculty = cmbFaculty.SelectedItem as Faculty;
            if (selectedFaculty != null)
            {
                var listMajor = majorService.getAllByFaculty(selectedFaculty.FacultyID);
                var facultyLst = facultyService.getAll();
                FillFalcultyCombobox(facultyLst);
                var listStudents = studentService.GetAllHasNoMajor(selectedFaculty.FacultyID);
                BindGrid(listStudents);
            }
        }
        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[1].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[2].Value = item.FullName;
                if (item.Faculty != null)
                {
                    dgvStudent.Rows[index].Cells[3].Value = item.Faculty.FacultyName;
                }
                dgvStudent.Rows[index].Cells[4].Value = item.AverageScore + "";
                if (item.MajorID != null)
                {
                    dgvStudent.Rows[index].Cells[5].Value = item.Major.Name + "";
                }
            }
        }

        private void lblChuyenNganh_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Get selected student from DataGridView (assuming row selection)
                if (dgvStudent.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a student!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the selected student ID from the grid
                string studentID = dgvStudent.SelectedRows[0].Cells[1].Value.ToString();
                var student = studentService.FindbyId(studentID);

                if (student == null)
                {
                    MessageBox.Show("Student not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Assign major to student (if major is selected)
                if (cmbMajor.SelectedItem is Major selectedMajor)
                {
                    student.MajorID = selectedMajor.MajorID;
                    studentService.InsertUpdate(student);  // Save the student with the updated major
                    MessageBox.Show("Student registered to major successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the grid with updated student list
                    var listStudents = studentService.GetAllHasNoMajor(selectedMajor.FacultyID);
                    BindGrid(listStudents);
                }
                else
                {
                    MessageBox.Show("Please select a major!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during registration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbMajor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
