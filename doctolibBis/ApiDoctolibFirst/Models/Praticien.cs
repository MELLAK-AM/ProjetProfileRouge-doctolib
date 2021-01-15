using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiDoctolibFirst.Models
{
    public class Praticien
    {
        private int id;   
        private string nom;
        private string telephone;
        private string email;
        private string adresse;
        private DateTime dateEmbauche;
        private string specialite;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public DateTime DateEmbauche { get => dateEmbauche; set => dateEmbauche = value; }
        public string Specialite { get => specialite; set => specialite = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public List<Image> Images { get; set; }
      

        public Praticien()
        {
            Images = new List<Image>();
        }
        public static List<Praticien> Search(string search)
        {
            return new List<Praticien>(
                DataDbContext.Instance.Praticiens.Include(p => p.Images)
                .Where(p => p.Nom.Contains(search) || p.Specialite.Contains(search)));
    
        }

        public static Praticien GetPraticien(int id)
        {
            return DataDbContext.Instance.Praticiens.Find(id);
        }

        public bool Update()
        {
            return DataDbContext.Instance.SaveChanges() > 0;
        }

        public bool Save()
        {
            DataDbContext.Instance.Praticiens.Add(this);
            return DataDbContext.Instance.SaveChanges() > 0;
        }
    }
}
