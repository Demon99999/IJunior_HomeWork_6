using System;

namespace IJinior_HomeWork_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictures = 52;
            int picturesInRow = 3;
            int fullRows = pictures / picturesInRow;
            int extraPictures = pictures % picturesInRow;
            Console.WriteLine($"Заполненные ряды - {fullRows}. Лишние картинки - {extraPictures}");
        }
    }
}
