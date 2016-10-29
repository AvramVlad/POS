using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Serviciu : ProdusAbstract
    {
        public Serviciu(int unId, String unNume, String unCodIntern) : base(unId, unNume, unCodIntern)
        {
        }

        public override void Descriere()
        {
            Console.WriteLine("ID : " + ID + " Nume : " + Nume + " Cod Intern : " + CodIntern);
        }

      

    }
}
