using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace WindowsFormsApplication1
{
    class Ulamek
    {
        public  int licznik { get; set; }
        public int mianownik { get; set; }
        public int cale { get; set; }

        public Ulamek(int licznik, int mianownik, int cale = 0)
        {
            this.licznik = licznik + (cale * mianownik);
            this.mianownik = mianownik;

        }

        public Ulamek Dodaj(Ulamek x)
        {
            int f_licznik = (licznik * x.mianownik) + (x.licznik * mianownik);
            int f_mianownik = mianownik * x.mianownik;
            int f_cale = 0;

        
            int mniejsze = coMiększe(f_mianownik, f_mianownik);

            for (int i = 2; i < mniejsze; i++)
            {
                if (f_mianownik % i == 0 && f_licznik % i == 0)
                {
                    f_mianownik = f_mianownik / i;
                    f_licznik = f_licznik / i;
                    break;
                }
            }

            if (f_licznik > f_mianownik)
            {
                f_cale = f_licznik / f_mianownik;
                f_licznik = f_licznik % f_mianownik;
            }
         
            return new Ulamek(f_licznik, f_mianownik, f_cale);
        }
         public Ulamek Odejmij(Ulamek x)
        {
            int f_licznik = (this.licznik * x.mianownik) - (x.licznik * this.mianownik) ;
            int f_mianownik = this.mianownik * x.mianownik;

            return new Ulamek(f_licznik, f_mianownik);
        }
        public Ulamek Pomnoz(Ulamek x)
        {
            int f_licznik = this.licznik * x.licznik;
            int f_mianownik = this.mianownik * x.mianownik;

            return new Ulamek(f_licznik, f_mianownik);
        }
        public Ulamek Podziel(Ulamek x)
        {
            int f_licznik = this.licznik * x.mianownik;
            int f_mianownik = this.mianownik * x.licznik;

            return new Ulamek(f_licznik, f_mianownik);
        }

        public int coMiększe(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else if (a == b)
            {
                return a;
            }
            else
            {
                return b;
            }

        }

        
    }
}
