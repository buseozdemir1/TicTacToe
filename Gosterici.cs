using System;

namespace TicTacToe
{
    public class Gosterici
    {
        public void Goster(Tahta tahta)
        {
            Console.Clear();
            char[,] semboller = new char[3, 3];
            for (int satir = 0; satir < 3; satir++)
                for (int sutun = 0; sutun < 3; sutun++)
                    semboller[satir, sutun] = DurumIcinSembol(tahta.DurumOkuma(new Pozisyon(satir, sutun)));

            Console.WriteLine($" {semboller[0, 0]} | {semboller[0, 1]} | {semboller[0, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {semboller[1, 0]} | {semboller[1, 1]} | {semboller[1, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {semboller[2, 0]} | {semboller[2, 1]} | {semboller[2, 2]} ");
        }

        private char DurumIcinSembol(Durum durum)
        {
            switch (durum)
            {
                case Durum.O: return 'O';
                case Durum.X: return 'X';
                default: return ' ';
            }
        }

        public void KazananiGoster(Durum kazanan)
        {
            switch (kazanan)
            {
                case Durum.O:
                case Durum.X:
                    Console.WriteLine(DurumIcinSembol(kazanan) + " Kazandı!");
                    break;
                case Durum.Belirlenmemis:
                    Console.WriteLine("Beraberlik!");
                    break;
            }
        }
    }

}
