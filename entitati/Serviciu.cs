using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Serviciu
    {
        private long id;// identificator   
        private String nume;// numele produsului  
        private String codIntern;// codul Intern  

        public void Afisare()
        {
            Console.WriteLine(" {0}  {1} " , Nume, CodIntern);
        }

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nume
        {
            get
            {
                return nume;
            }

            set
            {
                nume = value;
            }
        }

        public string CodIntern
        {
            get
            {
                return codIntern;
            }

            set
            {
                codIntern = value;
            }
        }
        public Serviciu(long unId, String unNume, String unCodIntern)

        {
            this.Id = unId;
            this.Nume = unNume;
            this.CodIntern = unCodIntern;

        }
    }
}
