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


            



            for (int i = 1; i <= 10; i++) // 1Den 10a kadar döner
            {
                for (int j = 1; j <= 10; j++) // Her bir sayı için 1'den 10'a kadar çarpar
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine(); // Her sayının çarpım tablosundan sonra bir boş satır ekler
            }
        }
    }
    }

