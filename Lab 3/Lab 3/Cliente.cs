using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Cliente : Persona
    {
        private string clientID;
        private List<Producto> NewBuys = new List<Producto>();
        private string ScheduleBuy;

        public void SetID (int D1, int D2, int D3,int D4)
        {
            this.clientID = "clientID: " + D1.ToString() + D2.ToString() + D3.ToString() + D4.ToString();
        }
        public string GetID()
        {
            return clientID;
        }
        public void SetSchedule(string Schedule)
        {
            this.ScheduleBuy = Schedule;
        }
        public string getHorario()
        {
            return ScheduleBuy;
        }

    }
}
