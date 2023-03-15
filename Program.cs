using System;



namespace TicTacToe

{

    public class Program

    {
        static void Main(string[] args)
        {
            Tahta tahta = new Tahta();
            KazananDenetleyici kazananDenetleyici = new KazananDenetleyici();
            Gosterici gosterici = new Gosterici();
            Oyuncu oyuncu1 = new Oyuncu();
            Oyuncu oyuncu2 = new Oyuncu();

            while (!kazananDenetleyici.Berabere(tahta) && kazananDenetleyici.Kontrol(tahta) == Durum.Belirlenmemis)
            {
                gosterici.Goster(tahta);

                Pozisyon sonrakiHareket;
                if (tahta.SonrakiSira == Durum.X)
                    sonrakiHareket = oyuncu1.PozisyonOkuma(tahta);
                else
                    sonrakiHareket = oyuncu2.PozisyonOkuma(tahta);
                if (!tahta.DurumAtama(sonrakiHareket, tahta.SonrakiSira))
                    Console.WriteLine("Geçerli bir hareket değil!");
            }

            gosterici.Goster(tahta);
            gosterici.KazananiGoster(kazananDenetleyici.Kontrol(tahta));
        }

    }

}