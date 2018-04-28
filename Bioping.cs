using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BioPing
{
    class Bioping
    {
        // поля данных
        public const double Best = 250.0F;   // лучшее время реакции 
        public const double Good = 500.0F;   // хорошее время реакции 
        public const double Weak = 850.0F;   // неплохое время реакции

        public double Duration { get; private set; } // свойство изменения set закрыт. свойство доступа get доступен 
        private char ExpectedChar;
        private Random ran = new Random();

        // методы
        private void Generate()
        { 
            ExpectedChar = (char)ran.Next(97, 122);    //привидение к типу char рандомного значения
        }                                              // от 97 до 122 (коды символов ASCII)
                                                       // для вывода случайного  символа в заданом диапазоне
       

        public void Test()
        {
            int n = ran.Next(1000, 6000);              // получение случайного значения в заданом диапазоне
            Thread.Sleep(n);                           // остановка программы на заданый прериод времени переменной n
            Generate();
            Console.WriteLine(ExpectedChar);           // вывод случайного символа
            Console.Beep();                            // воспроизведение сигнала

            var start = DateTime.Now;                  // сохранение текущего времени в переменой
                  
            while (Console.ReadKey().KeyChar != ExpectedChar)
            {
                // до тех пор пока не введен соответствующий символ
                // программа остается в этом цикле, 
                // а счет времени продолжается
            }

            TimeSpan time = DateTime.Now - start;      // вычитаем текущее время от времени начала отчета
            Duration = time.TotalMilliseconds;         // передаем значение в поле класса Bioping
   
        }

    }
}
