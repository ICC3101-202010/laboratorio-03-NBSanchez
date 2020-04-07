using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Supervisores : Trabajadores //LISTO//
    {
        private string SalarySup = "SalarySup";
        private string ScheduleSup = "ScheduleSup";
        public string GetSalary()
        {
            return SalarySup;
        }
        public void SetSalary(string salary)
        {
            this.SalarySup = salary;
        }
        public string GetSchedule()
        {
            return ScheduleSup;
        }
        public void SetSchedule(string schedule)
        {
            this.ScheduleSup = schedule;
        }
    }
}
