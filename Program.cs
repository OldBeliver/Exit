using System;

namespace Exit
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "exit";
            string userInput;
            bool doRepeat = true;

            while (doRepeat)
            {
                Console.WriteLine($"Введите команду для выхода:");
                userInput = Console.ReadLine();

                if(userInput == password)
                {
                    doRepeat = false;
                }
            }

            Console.WriteLine($"Выход подтвержден");
        }
    }
}
