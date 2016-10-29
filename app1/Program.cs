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
            ProdusMgr produseManager = new ProdusMgr();
            int input;
            do
            {
                Console.WriteLine("1 - Produs");
                Console.WriteLine("2 - Servicii");
                Console.WriteLine("0 - Iesire\n\n\n");

                Console.Write("Optiune: ");

                input = int.Parse(Console.ReadLine());


                switch (input)
                {


                    case 1:

                        {
                            produseManager.WriteProduse();

                            produseManager.ReadProdus();

                            produseManager.ReadProduse(10);
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