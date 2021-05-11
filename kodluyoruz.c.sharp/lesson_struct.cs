namespace kodluyoruz.c.sharp
{
    public class lesson_struct
    {
        public void example()
        {
            var dik = new dikdortgen();
            dik.kisaKenar = 3;
            dik.uzunKenar = 4;
            dik.alanHesapla();

            disdortgen_struct disdortgen;
            disdortgen.kisaKenar = 6;
            disdortgen.uzunKenar = 8;
            disdortgen.alanHesapla();
        }
    }

    class dikdortgen
    {
        public int kisaKenar;
        public int uzunKenar;

        //public dikdortgen()
        //{
            
        //}

        public long alanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }

    struct disdortgen_struct
    {
        public int kisaKenar;
        public int uzunKenar;

        public disdortgen_struct(int _kisaKenar, int _uzunKenar)
        {
            this.kisaKenar = _kisaKenar;
            this.uzunKenar = _uzunKenar;
        }

        public long alanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }
}