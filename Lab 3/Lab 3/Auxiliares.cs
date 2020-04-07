using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Auxiliares : Trabajadores  //LISTA//
    {
        private string SalaryAux = "SalaryAux";
        private string ScheduleAux = "ScheduleAux";
        public string GetSalary()
        {
            return SalaryAux;
        }
        public void SetSalary(string salary)
        {
            this.SalaryAux = salary;
        }
        public string GetSchedule()
        {
            return ScheduleAux;
        }
        public void SetSchedule(string schedule)
        {
            this.ScheduleAux = schedule;
        }
    }
}
