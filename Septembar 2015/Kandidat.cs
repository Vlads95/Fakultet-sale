using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septembar_2015
{
    public class Kandidat:Osoba


    {

        int brojPrijave;
        int brojTelefona;

        public Kandidat(int brojPrijave, int brojTelefona,string ime,DateTime datumRodjenja):base(ime, datumRodjenja)
        {
            this.brojPrijave = brojPrijave;
            this.brojTelefona = brojTelefona;

        }

        public int BrojPrijave { get => brojPrijave; set => brojPrijave = value; }
        public int BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
    }
}
