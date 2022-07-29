using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreManagement.Database.Models
{
    public class Draggist :User//eczaci
    {
        public string  Education { get; set; }
        public string Experience { get; set; }
        public Draggist(string name, string surname, string pin,string education, string experience)
            :base(name,surname,pin)
        {
            Education = education;
            Experience = experience;
        }
    }
}
