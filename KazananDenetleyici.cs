namespace TicTacToe
{
    public class KazananDenetleyici
    {
        public Durum Kontrol(Tahta tahta)
        {
            if (KazananKontrol(tahta, Durum.X)) return Durum.X;
            if (KazananKontrol(tahta, Durum.O)) return Durum.O;
            return Durum.Belirlenmemis;
        }

        private bool KazananKontrol(Tahta tahta, Durum oyuncu)
        {
            for (int satir = 0; satir < 3; satir++)
                if (HepsiAyni(tahta, new Pozisyon[] {
                        new Pozisyon(satir, 0),
                        new Pozisyon(satir, 1),
                        new Pozisyon(satir, 2) }, oyuncu))
                    return true;

            for (int sutun = 0; sutun < 3; sutun++)
                if (HepsiAyni(tahta, new Pozisyon[] {
                        new Pozisyon(0, sutun),
                        new Pozisyon(1, sutun),
                        new Pozisyon(2, sutun) }, oyuncu))
                    return true;

            if (HepsiAyni(tahta, new Pozisyon[] {
                    new Pozisyon(0, 0),
                    new Pozisyon(1, 1),
                    new Pozisyon(2, 2) }, oyuncu))
                return true;

            if (HepsiAyni(tahta, new Pozisyon[] {
                    new Pozisyon(2, 0),
                    new Pozisyon(1, 1),
                    new Pozisyon(0, 2) }, oyuncu))
                return true;

            return false;
        }

        private bool HepsiAyni(Tahta tahta, Pozisyon[] pozisyonlar, Durum durum)
        {
            foreach (Pozisyon pozisyon in pozisyonlar)
                if (tahta.DurumOkuma(pozisyon) != durum) return false;

            return true;
        }



        public bool Berabere(Tahta tahta)
        {
            for (int satir = 0; satir < 3; satir++)
                for (int sutun = 0; sutun < 3; sutun++)
                    if (tahta.DurumOkuma(new Pozisyon(satir, sutun)) == Durum.Belirlenmemis) return false;

            return true;
        }
    }
}
