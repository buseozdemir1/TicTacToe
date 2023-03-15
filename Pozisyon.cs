namespace TicTacToe
{
    public class Pozisyon
    {
        public int Satir { get; }
        public int Sutun { get; }

        public Pozisyon(int satir, int sutun)
        {
            Satir = satir;
            Sutun = sutun;
        }
    }
}
