using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona personita = new Persona();
            personita.SetRut();
            Console.WriteLine(personita.GetRut());
            personita.SetFullName();
            Console.WriteLine(personita.GetFullName());


        }
    }
}
