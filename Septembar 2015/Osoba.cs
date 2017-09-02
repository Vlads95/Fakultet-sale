using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septembar_2015
{
    public class Osoba
    {

      protected  string ime;
       protected DateTime datumRodjenja;

        public Osoba(string ime , DateTime datumRodjenja)
        {
            this.ime = ime;
            this.datumRodjenja = datumRodjenja;

        }

        public string Ime { get => ime; set => ime = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
    }
}
