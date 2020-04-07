using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Producto
    {
        private string ProdName;
        private string ProdBrand;
        private string ProdPrice;
        private int ProdStock;
        private Cliente Cliente;
        private Auxiliares Cajero;
        private int Hour;
        private string Date;


        private List<string> AllProName = new List<string>() { "Jugo", "Hielo", "Vino", "Galletas", "Pisco", "Queso", "Yogurt", "Pan", "Ramitas", "Jamon", "Bebida", "Tomate", "Pan", "Arroz", "Leche" };
        private List<string> AllProBrand = new List<string>() { "Great Value", "Livean", "Bimbo", "Alto del Carmen", "Nestle", "Carozzi", "Maggi", "Coca-Cola", "Quacker", "Vivo", "Soprole", "Danone", "Sopraval", "Not CO.", "Colun" };
        private List<string> AllProPrice = new List<string>() { "500", "750", "1000", "1100", "900", "2000", "1500", "2700", "3000", "550", "600", "950", "1250", "2100", "2200" };

        public void CreatProd(int A1, int A2, int A3, int ProdStock, int Day, int Month)
        {

            this.ProdName = AllProName[A1];
            this.ProdPrice = AllProPrice[A2];
            this.ProdBrand = AllProBrand[A3];
            this.ProdStock = ProdStock;
            this.Date = Day.ToString() + "/" + Month.ToString() + "/" + "2019";
        }
        public void MakeABuy(Cliente Comprador, Auxiliares Cajero, int Hour)
        {
            if (ProdStock <= 0)
            {
                Console.WriteLine("No es posible realizar la compra ya que ese producto no tiene stock");

            }
            else
            {
                ProdStock--;
                this.Cliente = Comprador;
                this.Cajero = Cajero;
                this.Hour = Hour;

            }
        }
        public string GetDataProduct()
        {
            return "Nombre: " + ProdName + Environment.NewLine + "Marca: " + ProdBrand + Environment.NewLine + "Precio: " + ProdPrice + Environment.NewLine + "Stock: " + ProdStock;
        }
        public string GetDataBuy()
        {

            return ProdName + " " + ProdBrand + " " + ProdPrice + Environment.NewLine + "Cliente: " + Cliente.GetFullName() + Environment.NewLine + "Cajero: " + Cajero.GetFullName() + Environment.NewLine + "Fecha: " + Date + Environment.NewLine + "Hora: " + Hour.ToString() + Environment.NewLine + "Stock despues de compra: " + ProdStock.ToString();
        }
        public int CheckStock()
        {
            return ProdStock;
        }

    }


}
