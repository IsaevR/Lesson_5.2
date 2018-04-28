using System;

namespace BioPing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t\t СКОРОСТЬ РЕАКЦИИ ИЛИ БИОЛОГИЧЕСКИЙ ПИНГ");
            Console.WriteLine("\n\n У разных людей время реакции может быть от 0,11 до 0,3 секунды и больше. ");
            Console.WriteLine("Для того что бы измерить время вашей реакции, программа втечении 5-ти секунд\n" +
                "выведет на экран случайный символ. Вам следует как можно скорее нажать\n" +
                "на соответствующую клавишу.");
            Console.Write("\n\n\t\t\tВы готовы? y/n: \b");

            char dicision = char.Parse(Console.ReadLine());
            while (dicision != 'n')
            {
                Bioping bioping = new Bioping();
                bioping.Test();
                Console.WriteLine("\n\nВремя вашей реакции : {0:F1} миллисекунд ", bioping.Duration);

                if (Bioping.Best <= bioping.Duration)
                    Console.WriteLine("\nПоздравляю!\n У Вас супер-быстрая реакция!");
                else if (Bioping.Good <= bioping.Duration)
                    Console.WriteLine("\nУ Вас хорошая реакция!");
                else if (Bioping.Weak <= bioping.Duration)
                    Console.WriteLine("\nУ Вас нeплохая реакция.");
                else
                    Console.WriteLine("\nВам следует немного потренироваться.");

                Console.Write("\n\n\t\tПродолжить тестирование? y/n: \b");
                dicision = char.Parse(Console.ReadLine());
            }
        }  
                                                         
    }
}
