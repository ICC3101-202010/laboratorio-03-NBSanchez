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
            Console.WriteLine("BIENVENIDOS AL SUPERMERCADO NAT´S");
            Supermercado ObjSuper = new Supermercado();

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("HAZ INGRESADO AL MENU PRINCIPAL DE NUESTRA PAGINA");
                Console.WriteLine("");
                Console.WriteLine("ESCOJA UNA DE LAS SIGUIENTES OPCIONES POR NUMERO/LETRA: ");
                Console.WriteLine("");
                Console.WriteLine("1. PROGRAMA MANUAL: ");
                Console.WriteLine("2. PROGRAMA AUTOMATICO: ");
                Console.WriteLine("E. SALIR DEL MENU: ");
                Console.WriteLine("");

                string firstoption = Console.ReadLine();
                if (firstoption == "2")
                {
                    Console.WriteLine("NO LOGRE TERMINAR EL BONUS");
                    continue;
                }
                if (firstoption == "E" || firstoption == "e")
                {
                    Console.WriteLine("A SIDO UN PLACER PARA NOSOTROS ATENDERTE ");
                    break;
                }
                else if (firstoption != "1" && firstoption != "2" && firstoption != "E" && firstoption != "e")
                {
                    Console.WriteLine("ESA OPCION NO ES VALIDA, PORFAVOR INGRELA NUEVAMENTE: ");
                    continue;
                }

                if (firstoption == "1")
                {
                    Random random = new Random();
                    ObjSuper.ResetAll();
                    int Hour = 830;
                    int Day = random.Next(1, 31);
                    int Month = random.Next(1, 13);

                    while (true)
                    {

                        Console.WriteLine("ESCOJA UNA DE LAS SIGUIENTES OPCIONES POR NUMERO/LETRA: ");
                        Console.WriteLine("1. CREAR CLIENTE: ");
                        Console.WriteLine("2. CREAR CAJERO:  ");
                        Console.WriteLine("3. CREAR JEFE: ");
                        Console.WriteLine("4. CREAR SUPERVISOR: ");
                        Console.WriteLine("5. CREAR LISTA DE PRODUCTOS: ");
                        Console.WriteLine("6. VAMOS A REALIZAR UNA COMPRA: ");
                        Console.WriteLine("7. VER INFO DE PERSONAS Y PRODUCTOS: ");
                        Console.WriteLine("R. VOLVER AL MENU PRINCIPAL");
                        Console.WriteLine("");

                        string secondoption = Console.ReadLine();

                        if (secondoption == "R" || secondoption == "r")
                        {
                            break;
                        }

                        else if (secondoption == "1")
                        {
                            Cliente ObjClie = new Cliente();
                            Console.WriteLine("ENTREGUE PRIMER NOMBRE DEL CLIENTE");
                            string CliName = Console.ReadLine();
                            Console.WriteLine("ENTREGUE EL PRIMER APELLIDO");
                            string CliLastName = Console.ReadLine();
                            Console.WriteLine("INGRESE SU NACIONALIDAD");
                            string CliNationality = Console.ReadLine();
                            Console.WriteLine("INGRESE SU RUT");
                            string CliRUT = Console.ReadLine();
                            Console.WriteLine("INGRESE FECHA DE NACIEMIENTO");
                            Console.WriteLine("INGRESE DÍA: ");
                            string CliDay = Console.ReadLine();
                            Console.WriteLine("INGRESE MES COMO NUMERO (EX: FEBRERO = 2)");
                            string CliMonth = Console.ReadLine();
                            Console.WriteLine("INGRESE AÑO: ");
                            string CliYear = Console.ReadLine();

                            ObjClie.SetName(CliName, CliLastName, CliNationality, CliRUT, CliDay, CliMonth, CliYear);
                            ObjClie.SetID(random.Next(10), random.Next(10), random.Next(10), random.Next(10));
                            ObjSuper.SetClient(ObjClie);
                            Console.WriteLine("");
                            Console.WriteLine("--------------------------------------------------------------------------");
                        }
                        else if (secondoption == "2")
                        {
                            Jefes ObjJef = new Jefes();
                            Console.WriteLine("ENTREGUE PRIMER NOMBRE DEL JEFE");
                            string JefName = Console.ReadLine();
                            Console.WriteLine("ENTREGUE EL PRIMER APELLIDO");
                            string JefLastName = Console.ReadLine();
                            Console.WriteLine("INGRESE SU NACIONALIDAD");
                            string JefNationality = Console.ReadLine();
                            Console.WriteLine("INGRESE SU RUT");
                            string JefRUT = Console.ReadLine();
                            Console.WriteLine("INGRESE FECHA DE NACIEMIENTO");
                            Console.WriteLine("INGRESE DÍA: ");
                            string JefDay = Console.ReadLine();
                            Console.WriteLine("INGRESE MES COMO NUMERO (EX: FEBRERO = 2)");
                            string JefMonth = Console.ReadLine();
                            Console.WriteLine("INGRESE AÑO: ");
                            string JefYear = Console.ReadLine();
                            ObjJef.SetName(JefName, JefLastName, JefNationality, JefRUT, JefDay, JefMonth, JefYear);
                            ObjJef.SetSalary("SueldoJefe");
                            ObjJef.SetSchedule("HorarioJefe");
                            ObjSuper.SetEmployees(ObjJef);
                            Console.WriteLine("");
                            Console.WriteLine("--------------------------------------------------------------------------");
                        }
                        else if (secondoption == "3")
                        {
                            Auxiliares ObjAux = new Auxiliares();
                            Console.WriteLine("ENTREGUE PRIMER NOMBRE DEL AUXILIAR");
                            string AuxName = Console.ReadLine();
                            Console.WriteLine("ENTREGUE EL PRIMER APELLIDO");
                            string AuxLastName = Console.ReadLine();
                            Console.WriteLine("INGRESE SU NACIONALIDAD");
                            string AuxNationality = Console.ReadLine();
                            Console.WriteLine("INGRESE SU RUT");
                            string AuxRUT = Console.ReadLine();
                            Console.WriteLine("INGRESE FECHA DE NACIEMIENTO");
                            Console.WriteLine("INGRESE DÍA: ");
                            string AuxDay = Console.ReadLine();
                            Console.WriteLine("INGRESE MES COMO NUMERO (EX: FEBRERO = 2)");
                            string AuxMonth = Console.ReadLine();
                            Console.WriteLine("INGRESE AÑO: ");
                            string AuxYear = Console.ReadLine();
                            ObjAux.SetName(AuxName, AuxLastName, AuxNationality, AuxRUT, AuxDay, AuxMonth, AuxYear);
                            ObjAux.SetSalary("SueldoAuxiliar");
                            ObjAux.SetSchedule("HorarioAuxiliar");
                            ObjSuper.SetEmployees(ObjAux);
                            ObjSuper.SetCashier(ObjAux);
                            Console.WriteLine("");
                            Console.WriteLine("--------------------------------------------------------------------------");

                        }
                        else if (secondoption == "4")
                        {
                            Supervisores ObjSup = new Supervisores();
                            Console.WriteLine("ENTREGUE PRIMER NOMBRE DEL SUPERVISOR");
                            string SupName = Console.ReadLine();
                            Console.WriteLine("ENTREGUE EL PRIMER APELLIDO");
                            string SupLastName = Console.ReadLine();
                            Console.WriteLine("INGRESE SU NACIONALIDAD");
                            string SupNationality = Console.ReadLine();
                            Console.WriteLine("INGRESE SU RUT");
                            string SupRUT = Console.ReadLine();
                            Console.WriteLine("INGRESE FECHA DE NACIEMIENTO");
                            Console.WriteLine("INGRESE DÍA: ");
                            string SupDay = Console.ReadLine();
                            Console.WriteLine("INGRESE MES COMO NUMERO (EX: FEBRERO = 2)");
                            string SupMonth = Console.ReadLine();
                            Console.WriteLine("INGRESE AÑO: ");
                            string SupYear = Console.ReadLine();
                            ObjSup.SetName(SupName, SupLastName, SupNationality, SupRUT, SupDay, SupMonth, SupYear);
                            ObjSup.SetSalary("SueldoSupervisor");
                            ObjSup.SetSchedule("HorarioSupervisor");
                            ObjSuper.SetEmployees(ObjSup);
                            Console.WriteLine("");
                            Console.WriteLine("--------------------------------------------------------------------------");

                        }
                        else if (secondoption == "5")
                        {
                            Console.WriteLine("INGRESE EL NUMERO DE PRODUCTOS QUE QUIERE CREAR:");
                            int num = Int32.Parse(Console.ReadLine());
                            for (int i = 0; i < num; i++)
                            {
                                int A1 = random.Next(15);
                                int A2 = random.Next(15);
                                int A3 = random.Next(15);
                                int A4 = random.Next(1, 10);

                                Producto ObjProd = new Producto();
                                ObjProd.CreatProd(A1, A2, A3, A4, Day, Month);
                                ObjSuper.SetProduct(ObjProd);
                            }

                        }
                        else if (secondoption == "6")
                        {
                            List<Cliente> ListCli = ObjSuper.SeeClient();
                            List<Auxiliares> ListCashi = ObjSuper.SeeCashier();
                            List<Producto> ListProd = ObjSuper.SeeProduct();
                            if (ListCli.Count() == 0 || ListCashi.Count() == 0 || ListProd.Count() == 0)
                            {
                                Console.WriteLine("ES IMPOSIBLE REALIZAR LA COMPRA");
                                Console.WriteLine("");
                                continue;
                            }
                            else
                            {
                                List<Producto> ListCom = new List<Producto>();
                                int RClient = random.Next(ListCli.Count());
                                int RCashier = random.Next(ListCashi.Count());
                                Console.WriteLine("INGRESE EL NUMERO DE PRODUCTOS QUE DESEA COMPRAR: ");
                                int NBuys = Int32.Parse(Console.ReadLine());

                                for (int a = 0; a < NBuys; a++)
                                {
                                    int RBuys = random.Next(ListProd.Count());
                                    int stock = ListProd[RBuys].CheckStock();
                                    if (stock <= 0)
                                    {
                                        ListProd.RemoveAt(RBuys);

                                    }
                                    else
                                    {
                                        ListProd[RBuys].MakeABuy(ListCli[RClient], ListCashi[RCashier], Hour);
                                        ListCom.Add(ListProd[RBuys]);
                                        Console.WriteLine(ListCom[(ListCom.Count() - 1)].GetDataBuy());
                                        Console.WriteLine("");
                                    }
                                    Hour += 100;
                                }

                            }

                        }
                        else if (secondoption == "7")
                        {
                            List<Cliente> ListCli = ObjSuper.SeeClient();
                            List<Auxiliares> ListCashi = ObjSuper.SeeCashier();
                            List<Producto> ListProd = ObjSuper.SeeProduct();
                            if (ListCli.Count() == 0 || ListCashi.Count() == 0 || ListProd.Count() == 0)
                            {
                                Console.WriteLine("ES IMPOSIBLE MOSTRAR LOS DATOS ");
                                Console.WriteLine("");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("CLIENTES:");
                                Console.WriteLine("");
                                ObjSuper.GetClient();
                                Console.WriteLine("CAJEROS:");
                                Console.WriteLine("");
                                ObjSuper.GetCashier();
                                Console.WriteLine("PRODUCTOS:");
                                Console.WriteLine("");
                                ObjSuper.GetProduct();
                            }

                        }
                        else if (secondoption != "1" && secondoption != "2" && secondoption != "3" && secondoption != "4" && secondoption != "5" && secondoption != "6" && secondoption != "7" && secondoption != "r" && secondoption != "R")
                        {
                            Console.WriteLine("SU OPCION NO ES VALIDA, PORFAVOR SELECIONE OTRA: ");
                            Console.WriteLine("");
                            continue;

                        }





                    }

                }



            }

        }
    }
}
