using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreManagement.Database.Models
{
    public class Owner : User //patron
    {
        public Owner(int id, string name, string surname, string pin)
            :base(id,name,surname,pin)
        {
           
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PIN { get; set; }


    }
}
