using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.BUS
{
    public class StudentService
    {
        public List<Student> Getall()
        {
            Model1 context = new Model1();
            return context.Students.ToList();
        }
        public List<Student> GetAllHasMajor()
        {
            Model1 context = new Model1();  
            return context.Students.Where(p=>p.MajorID == null).ToList();
        }
        public List<Student> GetAllHasNoMajor(int FacultyID) {
            Model1 context = new Model1();
            return context.Students.Where(p=>p.MajorID == null && p.FacultyID == FacultyID).ToList();
        }
        public Student FindbyId(String StudentID){
            Model1 context = new Model1();
            return context.Students.FirstOrDefault(p=>p.StudentID == StudentID);
        }
        public void InsertUpdate(Student s)
        {
            Model1 context = new Model1();
            context.Students.AddOrUpdate(s);
            context.SaveChanges();
        }
        public void Delete(string studentID)
        {
            Model1 model1 = new Model1();
            // Tìm sinh viên theo ID và xóa khỏi cơ sở dữ liệu
            var student = model1.Students.FirstOrDefault(s => s.StudentID == studentID);
            if (student != null)
            {
                model1.Students.Remove(student);
                model1.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }
        }
    }
}
