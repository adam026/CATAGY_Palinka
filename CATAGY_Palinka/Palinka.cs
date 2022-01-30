using System;

namespace CATAGY_Palinka
{
    class Palinka
    {
        private int _fok;
        private Gyumolcs _gyumolcs;
        private int _mennyiseg;
        private int _keszult;
        private int _ar;

        public int Fok { 
            get => _fok; 
            set
            {
                if (value < 30) throw new Exception("A pálinka foka nem lehet kisebb mint 30 fok. Az víz.");
                if (value > 87) throw new Exception("A pálinka foka nem lehet nagyobb mint 87 fok. A _ szádat. Hány fokos?");
                _fok = value;
            } 
        }
        public Gyumolcs Gyumolcs { get; set; }
        public int Mennyiseg
        {
            get => _mennyiseg;
            set
            {
                if (value < 0) throw new Exception("A pálinka mennyiség nem lehet kevesebb mint 0 dl!");
                if (value > 50) throw new Exception("A pálinka mennyiség nem lehet tömm mint 50 dl!");
                _mennyiseg = value;
            }
        }
        public int Keszult 
        {
            get => _keszult;
            set
            {
                if (value < 2000) throw new Exception("A pálinka készítési éve nem lehet kisebb mint 2000!");
                if (value > DateTime.Now.Year) throw new Exception("A pálinkát nem készíthették a jövőben!");
                _keszult = value;
            }
        }
        public int Ar
        {
            get => _ar;
            set
            {
                if (value < 50) throw new Exception("A pálinka ára nem lehet kevesebb 50 Ft/dl-nél. Hatóságilag szabályozva.");
                if (value > 1000) throw new Exception("A pálinka ára nem lehet nagyobb 1000 Ft/dl-nél. Hatóságilag szabályozva.");
                _ar = value;
            }
        }

        public Palinka(int fok, Gyumolcs gyumolcs, int mennyiseg, int keszult, int ar)
        {
            Fok = fok;
            Gyumolcs = gyumolcs;
            Mennyiseg = mennyiseg;
            Keszult = keszult;
            Ar = ar;
        }
    }
}
