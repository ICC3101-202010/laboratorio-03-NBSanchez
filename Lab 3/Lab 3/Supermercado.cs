using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Supermercado
    {
        List<Cliente> AllClient = new List<Cliente>();
        List<Object> AllEmployees = new List<Object>();
        List<Auxiliares> AllCashier = new List<Auxiliares>();
        List<Producto> AllProducts = new List<Producto>();
        List<Producto> AllBuys = new List<Producto>();

        public void SetClient(Cliente cliente)
        {
            AllClient.Add(cliente);

        }
        public void GetClient()
        {
            for (int i = 0; i < AllClient.Count(); i++)
            {
                Console.WriteLine(AllClient[i].GetFullName());


            }
            Console.WriteLine("");
        }
        public void SetEmployees(Object objeto)
        {
            AllEmployees.Add(objeto);
        }
        public void SetCashier(Auxiliares auxiliares)
        {
            AllCashier.Add(auxiliares);
        }
        public void GetCashier()
        {
            for (int i = 0; i < AllCashier.Count(); i++)
            {
                Console.WriteLine(AllCashier[i].GetFullName());

            }
            Console.WriteLine("");
        }
        public void SetProduct(Producto producto)
        {
            AllProducts.Add(producto);
        }
        
        public void GetProduct()
        {
            for (int i = 0; i < AllProducts.Count(); i++)
            {
                Console.WriteLine(AllProducts[i].GetDataProduct());
                Console.WriteLine("");
            }
        }
        public List<Producto> SeeProduct()
        {
            return AllProducts;
        }
        public List<Cliente> SeeClient()
        {
            return AllClient;
        }
        public List<Auxiliares> SeeCashier()
        {
            return AllCashier;
        }

        public List<Producto> SeeAllBuy()
        {
            return AllBuys;
        }
        
        public void ResetAll()
        {
            AllCashier.Clear();
            AllClient.Clear();
            AllBuys.Clear();
            AllProducts.Clear();
            AllEmployees.Clear();
        }



    }
}
