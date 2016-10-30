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
            ServiciuMgr serviciiManager = new ServiciuMgr();

       
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

                        
                            produseManager.WriteProduse();
                            produseManager.ReadProdus();
                            produseManager.ReadProduse(1);


                            break;
                        

                    case 2:


                        serviciiManager.WriteServicii();
                        serviciiManager.ReadServiciu();
                        serviciiManager.ReadServicii(1);



                        break;  

                }

            } while (input != 0);


        }
    }
}