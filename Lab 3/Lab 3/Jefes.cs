using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Jefes : Trabajadores //LISTO//
    {
        private string SalaryJef = "SalaryJef";
        private string ScheduleJef = "ScheduleJef";

        public string GetSalary()
        {
            return SalaryJef;
        }
        public void SetSalary(string salary)
        {
            this.SalaryJef = salary;
        }
        public string GetSchedule()
        {
            return ScheduleJef;
        }
        public void SetSchedule(string schedule)
        {
            this.ScheduleJef = schedule;
        }
    }
    
}
