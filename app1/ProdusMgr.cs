using entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    class ProdusMgr
    {
        Produs[] produse = new Produs[100];

        public void ReadProdus()
        {
            Console.WriteLine("Produsele sunt:");
            int contor = 0;

            while (produse[contor] != null)
            {
                Console.WriteLine(produse[contor].AltaDescriere());

                contor++;
            }
        }

        public void ReadProduse(int nr)
        {
            Console.WriteLine("Primele {0} produse sunt :", nr);
            int contor = 0;

            while ((contor < nr))
            {

                Console.WriteLine(produse[contor].AltaDescriere());

                contor++;
            }
        }
        public void WriteProduse()
        {
            Console.Write("Nr. produse:");
            int nrProduse = int.Parse(Console.ReadLine());

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
            }
        }
    }
}
