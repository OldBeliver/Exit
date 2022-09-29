using System;

namespace Exit
{
    class Program
    {
        static void Main(string[] args)
        {
            string exitCommand = "exit";
            string userInput = "";            

            while (userInput != exitCommand)
            {
                Console.WriteLine($"Введите команду для выхода:");
                userInput = Console.ReadLine();                
            }

            Console.WriteLine($"Выход подтвержден");
        }
    }
}
