using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Produs
    {
        private long id;// identificator   
        private String nume;// numele produsului  
        private String codIntern;// codul Intern  
        private String producator;// producator  

        public void Afisare()
        {
            Console.WriteLine("{0} {1} {2} ", Nume, CodIntern, Producator);
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

        public string Producator
        {
            get
            {
                return producator;
            }

            set
            {
                producator = value;
            }

        }
        public Produs(long unId, String unNume, String unCodIntern, String unProducator)
        {
            this.Id = unId;
            this.Nume = unNume;
            this.CodIntern = unCodIntern;
            this.Producator = unProducator;
        }
    }

}
