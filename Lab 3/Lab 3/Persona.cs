using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Persona
    {
        private string Rut;
        private string Name;
        private string LastName;
        private int BDay;
        private string Nationality;

        protected List<String> listname = new List<String>() { "Olivia", "Paula", "Alexis", "Agustin", "Alberto", "Arturo" };
        protected List<String> listlastname = new List<String>() { "Gotelli", "Yañez", "Vidal", "Ronaldo", "Medel", "Bravo" };
        protected List<String> listnationality = new List<String>() { "Colombiana", "Americana", "Austriaca", "Checo", "Chino", "Arabe" };


        public void SetFullName()
        {
            Random random = new Random();
            int AleName = random.Next(0, listname.Count());
            int AleLast = random.Next(0, listlastname.Count());
            int AleNati = random.Next(0, listnationality.Count());

            this.Name = listname[AleName];
            this.LastName = listlastname[AleLast];
            this.Nationality = listnationality[AleNati];

        }
        public string GetFullName()
        {
            return (Name + " " + LastName + " " + Nationality);
        }

        public void SetRut()
        {
            Random random = new Random();
            int D1 = random.Next(0, 3);

            if (D1 == 0)
            {
                int D2 = random.Next(3, 10);
                this.Rut += D2.ToString();
            }
            else if (D1 == 1)
            {
                this.Rut += D1.ToString();
                int D2 = random.Next(0, 10);
                this.Rut += D2.ToString();

            }
            else if (D1 == 2)
            {
                this.Rut += D1.ToString();
                int D2 = random.Next(0, 6);
                this.Rut += D2.ToString();
            }
            for ( int x = 0; x < 2; x++)
            {
                this.Rut += ".";
                int D3 = random.Next(0, 10);
                this.Rut += D3.ToString();
                int D4 = random.Next(0, 10);
                this.Rut += D4.ToString();
                int D5 = random.Next(0, 10);
                this.Rut += D5.ToString();
            }
            this.Rut += "-";
            int guion = random.Next(0, 11);
            if (guion == 10)
            {
                this.Rut += "K";
            }
            else
            {
                this.Rut += guion.ToString();
            }       
        }
        public string GetRut()
        {
            return Rut;
        }



    }
}
