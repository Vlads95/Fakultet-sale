using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Septembar_2015;
namespace ConsoleApp1
{
    class Raspored
    {


        int godina;
        List<Sala> spisakSala;
        List<Kandidat> spisakNerasporedjenih;

        public Raspored()
        {

        }



        public List<Sala> SpisakSala { get => spisakSala; set => spisakSala = value; }
        public List<Kandidat> SpisakNerasporedjenih { get => spisakNerasporedjenih; set => spisakNerasporedjenih = value; }

        static void Main(string[] args)
        {

        }
    }
}
