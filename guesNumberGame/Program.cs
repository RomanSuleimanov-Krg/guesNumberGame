using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guesNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int minValue = 0;
            int maxValue = 100;
            int guesNumber = random.Next(minValue,maxValue);

            string difficultyLevel;
            int numberAttempts;
            
            Console.WriteLine("Приветствую дорогой друг!!!" +
                "\nТы попал в игру \"Отгадай число\". Выбери уровень сложности и в отведенное количество ходов отгадай загаданное число программой:");
            Console.Write("\n- 1.Легкий уровень сложности (20 попыток)" +
                "\n- 2.Средний уровень сложности (15 попыток)" +
                "\n- 3.Сложный уровень сложности (10 попыток)");
            Console.Write("\n\nВыберите уровень сложности : ");
            difficultyLevel = Console.ReadLine();
            
            switch (difficultyLevel)
            {
                case "1":
                    numberAttempts = 20;
                    Console.WriteLine($"\nПоздравляю вы выбрали \"Легкий уровень сложности\" у вас {numberAttempts} попыток. Хорошей вам игры!!!");
                    break;
                case "2":
                    numberAttempts = 15;
                    Console.WriteLine($"\nПоздравляю вы выбрали \"Cредний уровень сложности\" у вас {numberAttempts} попыток. Хорошей вам игры!!!");
                    break;
                case "3":
                    numberAttempts = 10;
                    Console.WriteLine($"\nПоздравляю вы выбрали \"Сложный уровень сложности\" у вас {numberAttempts} попыток. Хорошей вам игры!!!");
                    break;
                default:
                    Console.WriteLine("\nОшибочка, вы ввели не правильный уровень сложности :("); 
                    Console.WriteLine("Вам нужно ввести число которое обозначает уровень сложности : от 1 до 3");
                    break;
            }
        }
    }
}
