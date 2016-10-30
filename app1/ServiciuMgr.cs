using entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    class ServiciuMgr
    {
        Serviciu[] servicii = new Serviciu[100];

        public void ReadServiciu()
        {
            Console.WriteLine("Serviciile sunt:");
            int contor = 0;

            while (servicii[contor] != null)
            {
                Console.WriteLine(servicii[contor].AltaDescriere());

                contor++;
            }
        }

        public void ReadServicii(int nr)
         {
            Console.WriteLine("Primele {0} servicii sunt :", nr);
            int contor = 0;

            while ((contor < nr))
            {

                Console.WriteLine(servicii[contor].AltaDescriere());

                contor++;
            }
        }
        public void WriteServicii()
        {
            Console.Write("Nr. servicii:");
            int nrServicii = int.Parse(Console.ReadLine());

            // citim serviciile   
            for (int cnt = 0; cnt < nrServicii; cnt++)
            {
                Console.WriteLine("Introdu un serviciu: \n");
                Console.Write("Numele:");
                String nume = Console.ReadLine();
                Console.Write("Codul intern:");
                String codIntern = Console.ReadLine();
                Serviciu serv = new Serviciu(cnt, nume, codIntern);


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
        }
    }
}
