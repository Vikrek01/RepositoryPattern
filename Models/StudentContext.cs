using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepositoryPatternInMVC.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name=MyConnectionString")
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}