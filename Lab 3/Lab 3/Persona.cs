using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Persona
    {
        protected string Rut;
        protected string Name;
        protected string LastName;
        protected string BDay;
        protected string Nationality;

        protected List<String> listname = new List<String>() { "Olivia", "Paula", "Alexis", "Agustin", "Alberto", "Arturo","Lorena","Miguel","Constanza","Felipe" };
        protected List<String> listlastname = new List<String>() { "Gotelli", "Yañez", "Vidal", "Ronaldo", "Medel", "Bravo","Brooks","Kardashian","Swift","Stallone"};
        protected List<String> listnationality = new List<String>() { "Colombiana", "Americana", "Austriaca", "Checo", "Chino", "Arabe","Panameño","Chileno","Italiana","Cubano"};


        public void SetFullName(int A1, int A2, int A3, int Day, int Month , int Year)
        {
            this.Name = listname[A1];
            this.LastName = listlastname[A2];
            this.Nationality = listnationality[A3];
            this.BDay = Day.ToString() + "/" + Month.ToString() + "/" + Year.ToString();
        }
        public string GetFullName()
        {
            return (Name + " " + LastName + " " + Nationality + " " + BDay + " " + Rut);
        }

        public void SetRut(int D1, int D2, int D3, int D4, int D5, int D6, int D7, int D8, int D9)
        {
            Rut += D1.ToString() + D2.ToString() + "." + D3.ToString() + D4.ToString() + D5.ToString() + "." + D6.ToString() + D7.ToString() + D8.ToString() + "-" + D9.ToString();
        }
        public string GetRut()
        {
            return Rut;
        }
        public void SetName(string Name, string LastName, string Nationality, string Rut, string Day, string Month, string Year)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Nationality = Nationality;
            this.Rut = Rut;
            this.BDay += Day + "/" + Month + "/" + Year;


        }



    }
}
