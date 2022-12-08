using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsSerailApp.Models
{
    public class DoctorRepo
    {
        ObservableCollection<Doctors> doctors;
        public DoctorRepo()
        {
            this.doctors = new ObservableCollection<Doctors>()
            {
               new Doctors{RegistrationNO=7788, Name="DR.Sayma Sultana", Title="Professor", Department="Neurology", BirthDate= new DateTime(1975,04,11), Email="sayma2020@gmail.com", Contact=01564221, Address="4/6, Green Road, Dhaka", Offday="Sunday", Picture="Assets/Dr.Sayma.jpg"},
                new Doctors{RegistrationNO=1122, Name="Dr.Abdur Rahman", Title="Professor", Department="Respioritory Medicine", BirthDate= new DateTime(1980,10,12), Email="abdurrahman123@gmail.com", Contact=0151564321, Address="2/f, Lalbagh, Dhaka", Offday="Friday", Picture="Assets/Abdur.jpg"},
                new Doctors{RegistrationNO=2233, Name="Dr.Kibriya", Title="Ass.Professor", Department="Orthopadics", BirthDate= new DateTime(1985,02,08), Email="kibriya564@gmail.com", Contact=0151564321, Address="5/7, Dhanmondi, Dhaka", Offday="Friday", Picture="Assets/Dr.Kibriya.jpg"},
                new Doctors{RegistrationNO=3344, Name="DR.Tasniya", Title="Ass.Professor", Department="Neurology", BirthDate= new DateTime(1980,04,11), Email="tasniya2525@gmail.com", Contact=0151564321, Address="4/6, Green Road, Dhaka", Offday="Sunday", Picture="Assets/Dr.Tasniya.png"},
                new Doctors{RegistrationNO=4455, Name="Dr.Aysha Khatun", Title="Professor", Department="Oncology", BirthDate= new DateTime(1980,05,06), Email="aysha@gmail.com", Contact=0151564321, Address="7/7, Gulshan, Dhaka", Offday="Friday", Picture="Assets/Khatun.jpg"},
                new Doctors{RegistrationNO=5566, Name="Dr.Zara", Title="Ass.Professor", Department="Surgery", BirthDate= new DateTime(1990,08,09), Email="zara125@gmail.com", Contact=0151564321, Address="1/1, Uttora, Dhaka", Offday="Sundat", Picture="Assets/Dr.Zara.jpg"},
                new Doctors{RegistrationNO=6677, Name="Dr.Rahul", Title="Ass.Professor", Department="Physical Medicine", BirthDate= new DateTime(1980,10,07), Email="rahuk569@gmail.com", Contact=0151564321, Address="2/4, Banani, Dhaka", Offday="saturday", Picture="Assets/Rahul.jpg"},
                new Doctors{RegistrationNO=8899, Name="DR.Nuzat Tabassum", Title="Ass.Professor", Department="Orthopadics", BirthDate= new DateTime(1985,10,18), Email="tabassum565@gmail.com", Contact=015987921, Address="8/9, Mohammadpur, Dhaka", Offday="Sunday", Picture="Assets/Dr.Tabassum.jpg"},
                new Doctors{RegistrationNO=9910, Name="DR.Mahbub Talukder", Title="Ass.Professor", Department="Neurology", BirthDate= new DateTime(1978,04,11), Email="mahbub852@gmail.com", Contact=012654821, Address="6/9, Green Road, Dhaka", Offday="Friday", Picture="Assets/Mahbub.jpg"},
                new Doctors{RegistrationNO=1011, Name="DR.Anika Arabi", Title="Ass.Professor", Department="Oncology", BirthDate= new DateTime(1985,09,11), Email="anika65656@gmail.com", Contact=0151123456, Address="4/4, Green Road, Dhaka", Offday="Sunday", Picture="Assets/Anika.jpg"},
                new Doctors{RegistrationNO=1111, Name="DR.Nazma Hoq", Title="Professor", Department="Respioritory Medicine", BirthDate= new DateTime(1975,08,11), Email="nazma65656@gmail.com", Contact=0151123456, Address="7/7, Lalbagh, Dhaka", Offday="friday", Picture="Assets/Nazma.jpg"},
            };
        }
        public ObservableCollection<Doctors> Get()
        {
            return this.doctors;
        }
        public Doctors Get(int id)
        {
            return this.doctors.FirstOrDefault(t => t.RegistrationNO == id);
        }
    }
}
