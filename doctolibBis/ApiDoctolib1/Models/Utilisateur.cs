﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiDoctolib1.Models;

namespace ApiDoctolib1.Models
{
    public class Utilisateur
    {
        private int id;

        private string email;

        private string motPasse;

        private string role;

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string MotPasse { get => motPasse; set => motPasse = value; }
        public string Role { get => role; set => role = value; }
    }
}
