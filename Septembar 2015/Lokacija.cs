using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septembar_2015
{

    public enum Fax { FON, FPN, SF, VSER }
    public  class Lokacija
    {


        int brSala;
        Fax fakultet;

        public Lokacija(int brSala, Fax fakultet)
        {
            this.brSala = brSala;
            this.fakultet = fakultet;



        }

        public int BrSala { get => brSala; set => brSala = value; }
        public Fax Fakultet { get => fakultet; set => fakultet = value; }
    }
}
