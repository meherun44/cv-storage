using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CvStorage.Models;
using Microsoft.EntityFrameworkCore;

namespace CvStorage.Data
{
    public class CvContext : DbContext
    {
        public CvContext(DbContextOptions<CvContext> options)
            : base(options)
        {
        }
        public DbSet<Cv> Cvs { get; set; }
        //public DbSet<Course> Courses { get; set; }


    }
}
