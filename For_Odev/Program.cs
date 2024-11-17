namespace For_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Pascal Üçğeni
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                // Satır bitince bir alt satıra geç
                Console.WriteLine();


            }
            #endregion


            #region YılBaşı Ağacı 
            int yukseklık = 6; // Piramidin yüksekliği

            for (int i = 1; i <= yukseklık; i++)
            {
                // Boşluklar için döngü
                for (int j = 1; j <= yukseklık - i; j++)
                {
                    Console.Write(" ");
                }

                // Yıldızlar için döngü
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                // Satır bitince bir alt satıra geç
                Console.WriteLine();
            }

            #endregion



            for (int i = 1; i <= 10; i++) // 1Den 10a kadar döner
            {
                for (int j = 1; j <= 10; j++) // Her bir sayı için 1'den 9'a kadar çarpar
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine(); // Her sayının çarpım tablosundan sonra bir boş satır ekler
            }
        }
    }
    }

