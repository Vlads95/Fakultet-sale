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


       



        // Sve sale čiji kapacitet nije popunjen.

        public List<Sala> sveSale()
        {
            List<Sala> lista = new List<Sala>();
            foreach (Sala s in SpisakSala)
            {
                if (s.SpisakKandidata.Count() < s.Kapacitet)
                {
                    lista.Add(s);
                }
            }
            return lista;
        }



        //Svi kandidati koji polažu prijemni ispit na određenom fakultetu.


            public List<Kandidat> sviKandidatiNaOdredjenomFaxu (Fax fax)
        {
            List<Kandidat> lista = new List<Kandidat>();

            foreach (Sala s in spisakSala)
            {

                if (s.Lokacija.Fakultet== fax)

                {

                    foreach (Kandidat k in s.spisakKandidata)
                    {
                        lista.Add(k);
                    }


                }



            }
            return lista;

        }




       // Sala sa najvećim kapacitetom.

            public Sala najvecaSala ()
        {

            Sala max = spisakSala[0];

            foreach (Sala s in spisakSala)
            {
                if (s.Kapacitet > max.Kapacitet)
                {
                    max = s;
                }
            }
            return max;


        }


        //Procenat kandidata koji će polagati prijemni ispit na SF-u.

            public double procenatNaSF()
        {

            int broj=0;
            int uk = 0;

            foreach (Sala s in spisakSala)
            {
                 uk+= s.spisakKandidata.Count();
                if (s.Lokacija.Fakultet == Fax.SF)

                {

                    foreach (Kandidat k in s.spisakKandidata)
                    {
                        broj++;
                    }


                }


                
            }

            try
            {
                return Math.Round(broj / uk * 100.0);
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Deljenje nulom");
                return 0;
            }
            catch (Exception)
            {

                Console.WriteLine("Neka glupost");
                return 0;

            }

        }


        // Sve sale za koje je odgovorno lice čije prezime i ime  počinje na  određeno slovo.
             public List<Sala> sveSaleSlovo( char slovo)
        {

            List<Sala> lista = new List<Sala>();

            foreach (Sala s in SpisakSala)
            {
                if (s.Osoba.Ime.Split(',')[0].ToCharArray()[0]==slovo 
                 && s.Osoba.Ime.Split(',')[2].ToCharArray()[0]==slovo)
                {
                    lista.Add(s);
                    
                }



            }
            return lista;
        }


        // Sve sale za koje je odgovorno lice čije prezime sadrži određeno slovo.


        public List<Sala> sveSaleSadrzi(char slovo)
        {

            List<Sala> lista = new List<Sala>();

            foreach (Sala s in SpisakSala)
            {
                if (s.Osoba.Ime.Split(',')[2].Contains(slovo)
                 )
                {
                    lista.Add(s);

                }



            }
            return lista;
        }



        /*   

            Procenat popunjenosti sala na SF-u.
            Obraditi grešku koja bi nastala prilikom računanja procenta popunjenosti
            sala ukoliko nijedan od kandidata nije unešen na datu lokaciju,na taj način što će se ispisati poruka
            o tome da nije moguće izračunati zahtjevano.               */






        static void Main(string[] args)
        {

        }
    }
}
