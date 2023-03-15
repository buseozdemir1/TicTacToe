namespace TicTacToe
{
    public class Tahta
    {
        private Durum[,] durum;
        public Durum SonrakiSira { get; private set; }

        public Tahta()
        {
            durum = new Durum[3, 3];
            SonrakiSira = Durum.X;
        }

        public Durum DurumOkuma(Pozisyon pozisyon)
        {
            return durum[pozisyon.Satir, pozisyon.Sutun];
        }

        public bool DurumAtama(Pozisyon pozisyon, Durum yeniDurum)
        {
            if (yeniDurum != SonrakiSira) return false;
            if (durum[pozisyon.Satir, pozisyon.Sutun] != Durum.Belirlenmemis) return false;

            durum[pozisyon.Satir, pozisyon.Sutun] = yeniDurum;
            SiradakiKisiyeGec();
            return true;
        }

        private void SiradakiKisiyeGec()
        {
            if (SonrakiSira == Durum.X) SonrakiSira = Durum.O;
            else SonrakiSira = Durum.X;
        }
    }

}
