using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public abstract class ProdusAbstract
    {
        public int ID { get; set; }
        public string CodIntern { get; set; }
        public string Nume { get; set; }

        public ProdusAbstract(int ID, string CodIntern, string Nume)
        {
            this.ID = ID;
            this.Nume = Nume;
            this.CodIntern = CodIntern;
        }

        public abstract void Descriere();

        public virtual string AltaDescriere()
        {
            return "ID : " + ID + " Nume : " + Nume + " Cod Intern : " + CodIntern;
        }
    }
}
