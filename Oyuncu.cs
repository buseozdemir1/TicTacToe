using System;

namespace TicTacToe
{
    public class Oyuncu
    {
        public Pozisyon PozisyonOkuma(Tahta tahta)
        {
            int pozisyon = Convert.ToInt32(Console.ReadLine());
            Pozisyon istenenKoordinat = NumaraPozisyonCevir(pozisyon);
            return istenenKoordinat;
        }

        private Pozisyon NumaraPozisyonCevir(int pozisyon)
        {
            switch (pozisyon)
            {
                case 1: return new Pozisyon(2, 0); // Alt Left
                case 2: return new Pozisyon(2, 1); // Alt Orta 
                case 3: return new Pozisyon(2, 2); // Alt Sag
                case 4: return new Pozisyon(1, 0); // Orta Sol
                case 5: return new Pozisyon(1, 1); // Orta Orta
                case 6: return new Pozisyon(1, 2); // Orta Sag
                case 7: return new Pozisyon(0, 0); // Ust Sol
                case 8: return new Pozisyon(0, 1); // Ust Orta
                case 9: return new Pozisyon(0, 2); // Ust Sag
                default: return null;
            }
        }
    }


}
