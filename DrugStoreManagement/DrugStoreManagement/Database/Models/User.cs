﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreManagement.Database.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PIN { get; set; }

        public User(int id, string name, string surname, string pin)
        {
            Id = id;
            Name = name;
            Surname = surname;
            PIN = pin;
        }
        public User( string name, string surname, string pin)
        {
    
            Name = name;
            Surname = surname;
            PIN = pin;
        }

    }
}
