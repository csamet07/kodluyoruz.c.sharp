namespace kodluyoruz.c.sharp
{
    public class leeson_interface
    {
        
    }

    interface IOtomobil
    {
        int kac_tekerlegi_var();
        marka hangi_markanin_araci();
        renk standart_rengi_ne();
    }

    enum marka
    {
        ford,
        toyota,
        honda
    }

    enum renk
    {
        beyaz,
        gri
    }

    class focus : IOtomobil
    {
        public int kac_tekerlegi_var()
        {
            return 4;
        }

        public marka hangi_markanin_araci()
        {
            return marka.ford;
        }

        public renk standart_rengi_ne()
        {
            return renk.beyaz;
        }
    }
}