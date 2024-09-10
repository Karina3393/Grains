namespace Grains
{
    internal class Program
    {
        static void Main()
        {
            ulong totalGrains = 0; 
            ulong grainsOnSquare = 1; 

           
            for (int square = 1; square <= 64; square++)
            {
                Console.WriteLine($"Клiтинка {square}: {grainsOnSquare} зерен");
                totalGrains += grainsOnSquare;
                grainsOnSquare *= 2;
            }

            Console.WriteLine($"\nЗагальна кiлькiсть зерен на шахiвницi: {totalGrains}");
        }
    }
}