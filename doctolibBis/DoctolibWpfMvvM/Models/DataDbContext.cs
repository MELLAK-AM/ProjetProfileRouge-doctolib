using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoctolibWpfMvvM.Models
{
    public class DataDbContext : DbContext
    {
        public DbSet<Praticien> Praticiens { get; set; }
        public DbSet<Patient> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=(LocalDb)\coursM2I;Integrated Security=True");
        }
    }
}
