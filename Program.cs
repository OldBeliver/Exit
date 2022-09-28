using System;

namespace Exit
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "exit";
            string userInput = "";            

            while (userInput != password)
            {
                Console.WriteLine($"Введите команду для выхода:");
                userInput = Console.ReadLine();                
            }

            Console.WriteLine($"Выход подтвержден");
        }
    }
}
