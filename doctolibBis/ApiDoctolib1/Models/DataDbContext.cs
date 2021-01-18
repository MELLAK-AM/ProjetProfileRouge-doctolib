﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace ApiDoctolib1.Models
{
    public class DataDbContext : DbContext
    {
        private static DataDbContext _instance = null;
        public DbSet<Praticien> Praticiens { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }

        public DataDbContext()
        {

        }

        public static DataDbContext Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataDbContext();
                return _instance;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=(LocalDb)\coursM2I;Integrated Security=True");
        }
    }
}
