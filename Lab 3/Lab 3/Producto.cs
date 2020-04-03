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

        public Producto(string ProdName,string ProdBrand,string ProdPrice, int ProdStock)
        {
            this.ProdName = ProdName;
            this.ProdBrand = ProdBrand;
            this.ProdPrice = ProdPrice;
            this.ProdStock = ProdStock;
        }
    }
}
