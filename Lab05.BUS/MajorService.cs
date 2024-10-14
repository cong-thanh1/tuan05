using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.BUS
{
    public class MajorService
    {
        public List<Major> getAllByFaculty(int facultyID)
        {
            Model1 model1 = new Model1();
            return model1.Majors.Where(p=>p.FacultyID == facultyID).ToList();
        }
    }
}
