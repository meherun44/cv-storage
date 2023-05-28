
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CvStorage.Models;

namespace CvStorage.Repository
{
    public interface ICvRepository
    {
        public int AddCv(Cv model);
        //public Student GetStudentById(int id);
       // public List<Student> GetAllStudent();
    }
}
