using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Trabajadores : Persona
    {
        
        protected string Salary;
        protected string Schedule;
        public void SetSchedule(string Schedule )
        {
            this.Schedule = Schedule;

        }
        public string GetSchedule()
        {
            return Schedule;
        }
        public void SetSalary(string Salary)
        {
            this.Salary = Salary;
        }
        public string GetSalary()
        {
            return Salary;
        }

        
        


    }

}

