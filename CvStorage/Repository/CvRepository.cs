using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CvStorage.Data;
using CvStorage.Models;

namespace CvStorage.Repository
{
    public class CvRepository : ICvRepository
    {
        private readonly CvContext context = null;

        public CvRepository(CvContext _context)
        {
            context = _context;
        }

       
        
        public int AddCv(Cv model)
        {
            var cv = new Cv()
            {
                Name = model.Name,
                Email=model.Email,
                Address=model.Address,
                FatherName=model.FatherName,
                MotherName=model.MotherName,
                Gender=model.Gender,
                Religion = model.Religion,

                MaritalStatus=model.MaritalStatus,

                NationalId=model.NationalId,
                PrimaryMobile=model.PrimaryMobile,
                EmergencyContact=model.EmergencyContact,
                BloodGroup=model.BloodGroup,
                PresentAddress=model.PresentAddress,
                PermanentAddress=model.PermanentAddress,
                Objective=model.Objective,
                PresentSalary=model.PresentSalary,
                ExpectedSalary=model.ExpectedSalary,
                SpecialSkills=model.SpecialSkills,
                CareerSummary=model.CareerSummary,


            };

            context.Cvs.Add(cv);
            context.SaveChanges();

            return cv.Id;
        }

        public Cv GetCvById(int id)
        {
            var student = context.Cvs.FirstOrDefault(s => s.Id == id);
            return student;
        }

        public List<Cv> GetAllCv()
        {

            var cvs = new List<Cv>();
            var data = context.Cvs.ToList();
            if (data?.Any() == true)
            {
                foreach (var d in data)
                {
                    var cv = new Cv()
                    {
                        Id = d.Id,
                        Name = d.Name,
                        
                    };

                    cvs.Add(cv);
                }
            }
            return data;
        }
    }
}
