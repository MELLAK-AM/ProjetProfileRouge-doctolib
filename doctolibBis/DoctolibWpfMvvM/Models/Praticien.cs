using System;
using System.Collections.Generic;
using System.Text;

namespace DoctolibWpfMvvM.Models
{
    public class Praticien
    {
        private int id;   
        private string Nom;
        private string Telephone;
        private DateTime dateEmbauche;
        private string specialite;

        public int Id { get => id; set => id = value; }
        public string Nom1 { get => Nom; set => Nom = value; }
        public string Telephone1 { get => Telephone; set => Telephone = value; }
        public DateTime DateEmbauche { get => dateEmbauche; set => dateEmbauche = value; }
        public string Specialite { get => specialite; set => specialite = value; }
       
    }
}
