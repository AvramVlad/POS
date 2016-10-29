using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Produs : ProdusAbstract
    {
        public String Producator { get; set; }

        public Produs(int ID, string CodIntern, string Nume, String Producator) : base(ID, CodIntern, Nume)
        {
            this.Producator = Producator;

        }

        public override void Descriere()
        {
            Console.WriteLine("ID  : " + ID + " Nume : " + Nume + " Cod Intern : " + CodIntern + " Producator :" + Producator);
        }

        public override string AltaDescriere()
        {
            return base.AltaDescriere() + " Producator : " + Producator;
        }
    }
}
