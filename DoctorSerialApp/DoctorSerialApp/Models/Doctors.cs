using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsSerailApp.Models
{
    public class Doctors
    {
        public int RegistrationNO { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public int Contact { get; set; }
        public string Picture { get; set; }
        public string Offday { get; set; }
        public string Address { get; set; }
        public string Birthdate { get => this.BirthDate.ToString("yyyy-MM-dd"); }


    }
}
