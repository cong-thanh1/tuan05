using Lab05.BUS;
using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class frmStudent : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService= new FacultyService();   
       public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dgvStudent);
                var listFacultys = facultyService.getAll();
                var listStudent = studentService.Getall();
                FillFalcultyCombobox(listFacultys);
                BindGrid(listStudent);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            listFacultys.Insert(0, new Faculty());
            this.cmbKhoa.DataSource = listFacultys;
            this.cmbKhoa.DisplayMember = "FacultyName";
            this.cmbKhoa.ValueMember = "FacultyID";
        }
        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                if (item.Faculty != null)
                    dgvStudent.Rows[index].Cells[2].Value =
                    item.Faculty.FacultyName;
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore +
                "";
                if (item.MajorID != null)
                    dgvStudent.Rows[index].Cells[4].Value = item.Major.Name +
                    "";
                ShowAvatar(item.Avatar);
            }
        }
       
        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle =
            DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void chkUnregisterMajor_CheckedChanged_1(object sender, EventArgs e)
        {
            var listStudent = new List<Student>();
            if (this.chkUnregisterMajor.Checked)
                listStudent = studentService.GetAllHasMajor();
            else
                listStudent = studentService.Getall();
            BindGrid(listStudent);
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            registerForm.ShowDialog();
        }
        private string avatarFilePath = string.Empty;
        private void LoadAvatar(string studentID)
        {
            string folderPath = Path.Combine(Application.StartupPath, "Images");
            var student = studentService.FindbyId(studentID);
            if (student != null && !string.IsNullOrEmpty(student.Avatar))
            {
                string avatarFilePath = Path.Combine(folderPath, student.Avatar);
                if (File.Exists(avatarFilePath))
                {
                    picSinhVien.Image = Image.FromFile(avatarFilePath);
                }
                else
                {
                    picSinhVien.Image = null;
                }
            }
        }
        private string SaveAvatar(string sourceFilePath, string studentID)
        {
            try
            {
                string folderPath = Path.Combine(Application.StartupPath, "Images");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                string fileExtension = Path.GetExtension(sourceFilePath);
                string targetFilePath = Path.Combine(folderPath, $"{studentID}{fileExtension}");
                if (!File.Exists(sourceFilePath))
                {
                    throw new FileNotFoundException($"Không tìm thấy file: {sourceFilePath}");
                }
                File.Copy(sourceFilePath, targetFilePath, true);
                return $"{studentID}{fileExtension}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving avatar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void ShowAvatar(string imageName)
        {
            if (string.IsNullOrEmpty(imageName))
            {
                picSinhVien.Image = null;
                return;
            }

            string folderPath = Path.Combine(Application.StartupPath, "Images");
            string imagePath = Path.Combine(folderPath, imageName);

            if (File.Exists(imagePath))
            {
                picSinhVien.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show($"Image file not found at: {imagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                picSinhVien.Image = null;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Validate the inputs
                if (!ValidateInputs()) return; // Assumes ValidateInputs() properly checks all fields

                // Step 2: Find the student by ID or create a new one
                var student = studentService.FindbyId(txtID.Text) ?? new Student();

                // Step 3: Assign values from the form fields to the student object
                student.StudentID = txtID.Text.Trim();  // Trim to remove extra spaces
                student.FullName = txtName.Text.Trim(); // Ensure no extra spaces
                if (!double.TryParse(txtDiem.Text.Trim(), out double averageScore))
                {
                    MessageBox.Show("Invalid score format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                student.AverageScore = averageScore;

                if (!int.TryParse(cmbKhoa.SelectedValue.ToString(), out int facultyID))
                {
                    MessageBox.Show("Invalid Faculty ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                student.FacultyID = facultyID;

                // Step 4: If an avatar file path is provided, save the avatar
                if (!string.IsNullOrEmpty(avatarFilePath))
                {
                    string avatarFileName = SaveAvatar(avatarFilePath, txtID.Text);
                    if (!string.IsNullOrEmpty(avatarFileName))
                    {
                        student.Avatar = avatarFileName;
                    }
                    else
                    {
                        MessageBox.Show("Error saving avatar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Step 5: Insert or update the student in the database
                studentService.InsertUpdate(student);

                // Step 6: Update the data grid to reflect the changes
                BindGrid(studentService.Getall());

                // Step 7: Clear the form fields after successful addition
                ClearFormFields();  

            }
            catch (Exception ex)
            {
                // Handle any exceptions and display them in a message box
                MessageBox.Show($"Error adding student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to validate inputs (could be implemented as you need)
        private bool ValidateInputs()
        {
            // Check if the ID, Name, and other mandatory fields are provided
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Student ID is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Student name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Average score is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Method to clear form fields after adding/updating
        private void ClearFormFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtDiem.Clear();
            avatarFilePath = string.Empty; // Reset the avatar file path
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    avatarFilePath = openFileDialog.FileName;
                    picSinhVien.Image = Image.FromFile(avatarFilePath);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng có chọn sinh viên nào trong DataGridView không
                if (dgvStudent.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy StudentID của sinh viên được chọn
                var selectedRow = dgvStudent.SelectedRows[0]; // Chọn dòng đầu tiên
                string studentID = selectedRow.Cells[0].Value.ToString(); // Cột chứa StudentID là cột đầu tiên

                // Hỏi người dùng có chắc chắn muốn xóa không
                var result = MessageBox.Show($"Are you sure you want to delete student with ID: {studentID}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Gọi service để xóa sinh viên
                    studentService.Delete(studentID);

                    // Cập nhật lại danh sách sinh viên trên DataGridView
                    BindGrid(studentService.Getall());

                    MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudent_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                var selectedRow = dgvStudent.SelectedRows[0];
                string studentID = selectedRow.Cells[0].Value.ToString(); // Lấy StudentID

                // Tìm sinh viên theo ID
                var student = studentService.FindbyId(studentID);

                if (student != null)
                {
                    // Hiển thị thông tin sinh viên lên các textbox
                    txtID.Text = student.StudentID;
                    txtName.Text = student.FullName;
                    txtDiem.Text = student.AverageScore.ToString();

                    if (student.FacultyID.HasValue)
                    {
                        cmbKhoa.SelectedValue = student.FacultyID.Value;
                    }
                    else
                    {
                        cmbKhoa.SelectedIndex = -1; // Không chọn khoa nào
                    }

                    // Hiển thị avatar
                    LoadAvatar(student.StudentID);
                }
            }
        }
    }
}
