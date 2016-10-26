using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entitati;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            do
            {
                Console.WriteLine("1 - Produs");
                Console.WriteLine("2 - Servicii");
                Console.WriteLine("0 - Iesire\n\n\n");

                Console.WriteLine("Optiune: ");

                input = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (input)
                {
                   

                    case 1:

                        {

                    Console.Write("Nr. produse:");
                    int nrProduse = int.Parse(Console.ReadLine());
                    // array de servicii   
                    Produs[] produse = new Produs[100];
                    // citim serviciile   
                    for (int cnt = 0; cnt < nrProduse; cnt++)
                    {
                        Console.WriteLine("Introdu un produs: \n");
                        Console.Write("Numele: ");
                        String nume = Console.ReadLine();
                        Console.Write("Codul intern:");
                        String codIntern = Console.ReadLine();
                        Console.Write("Producator: ");
                        String producator = Console.ReadLine();

                        Produs prod = new Produs(cnt, nume, codIntern, producator);



                        //verifica daca numele a 2 produse sunt identice ------------------
                        bool exists = false;
                        int counter = 0;
                        if (produse[0] == null)
                        {
                            produse[0] = prod;
                        }
                        else
                        {
                            while (produse[counter] != null)
                            {
                                if (produse[counter].Nume.Equals(prod.Nume))
                                {
                                    Console.WriteLine("Produsul {0} exista deja", prod.Nume);
                                    exists = true;
                                    cnt--;
                                    nrProduse--;
                                    break;
                                }
                                counter++;
                            }
                            if (exists == false)
                            {
                                produse[cnt] = prod;
                            }
                        }

                        //---------------------------------------------



                    }
                    // afisam serviciile
                    Console.WriteLine("Produsele sunt:");
                    int contor = 0;

                    while (produse[contor] != null)
                    {
                        produse[contor].Afisare();

                        contor++;
                    }
                    Console.ReadKey();

                    break;
                }


                    case 2:
                        {

                    Console.Write("Nr. servicii:");
                    int nrServicii = int.Parse(Console.ReadLine());
                    // array de servicii   
                    Serviciu[] servicii = new Serviciu[100];
                    // citim serviciile   
                    for (int cnt = 0; cnt < nrServicii; cnt++)
                    {
                        Console.WriteLine("Introdu un serviciu: \n");
                        Console.Write("Numele:");
                        String nume = Console.ReadLine();
                        Console.Write("Codul intern:");
                        string codIntern = Console.ReadLine();
                        Serviciu serv = new Serviciu(cnt, nume, codIntern);

                        /*      var existingServiciu = servicii.Where(x => x != null).FirstOrDefault(x => x.Nume.Equals(serv.Nume));

                              if (existingServiciu == null)
                              {
                                  servicii[cnt] = serv;
                              }
                              else
                              {
                                  Console.WriteLine("Serviciul {0} {1} exista deja", serv.Nume, serv.CodIntern);
                                  cnt -= 1;
                                  nrServicii -= 1;
                              }

                  */

                        bool exists = false;
                        int counter = 0;
                        if (servicii[0] == null)
                        {
                            servicii[0] = serv;
                        }
                        else
                        {
                            while (servicii[counter] != null)
                            {
                                if (servicii[counter].Nume.Equals(serv.Nume))
                                {
                                    Console.WriteLine("Serviciul {0} exista deja", serv.Nume);
                                    exists = true;
                                    cnt--;
                                    nrServicii--;
                                    break;
                                }
                                counter++;
                            }
                            if (exists == false)
                            {
                                servicii[cnt] = serv;
                            }
                        }
                    }
                    // afisam serviciile
                    Console.WriteLine("Serviciile sunt:");
                    int contor = 0;

                    while (servicii[contor] != null)
                    {
                        servicii[contor].Afisare();

                        contor++;
                    }
                    Console.ReadKey();
                    break;

                }

            }

            } while (input != 0);


        }
}
}