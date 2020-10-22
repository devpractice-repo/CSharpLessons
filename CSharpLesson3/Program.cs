using System;

namespace CSharpLesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Класс Console. Вывод данных в консоль
            // ### Метод Write
            Console.WriteLine("## Класс Console. Вывод данных в консоль");
            Console.WriteLine("### Метод Write");
            Console.WriteLine();
            // Примеры работы с методом Write без форматирования
            Console.Write("Текущая дата: ");
            Console.Write(DateTime.Now);
            Console.Write("\n");

            Console.Write($"Текущая дата: {DateTime.Now}\n");

            // Примеры работы с методом Write с использованием форматирования
            Console.Write("Текущая дата: {0}\n", DateTime.Now);
            Console.Write("Число: {0:E}\n", 123.456789);

            // ### Метод WriteLine
            Console.WriteLine("### Метод WriteLine");
            Console.WriteLine();
            Console.WriteLine("Текущая дата: ");
            Console.WriteLine(DateTime.Now);

            DateTime nowDate = DateTime.Now;
            string someText = "Сегодня";
            int number = 924;
            Console.WriteLine(nowDate);
            Console.WriteLine(someText);
            Console.WriteLine(number);

            Console.WriteLine($"{someText} {nowDate} Число: {number}");
            Console.WriteLine("{1}:{0:yyyy-MM-dd}, Число: {2}", nowDate, someText, number);

            // ## Класс Console. Чтение данных из консоли
            // ### Метод Read
            Console.WriteLine("## Класс Console. Чтение данных из консоли");
            Console.WriteLine("### Метод Read");
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу, а затем Enter");
            int key1 = Console.Read();
            Console.WriteLine($"Код нажатой клавиши: {key1}");
            Console.WriteLine("Cимвольное представление: " + Convert.ToChar(key1));

            // ### Метод ReadLine
            Console.WriteLine("### Метод ReadLine");
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("Введите ваше имя, а затем нажмите Enter");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");

            Console.WriteLine("Сколько вам лет?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш рост в см?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Привет {0}, вам уже {1} полных лет и ваш рост {2} см", name, age, height);

            // ### Метод ReadKey
            Console.WriteLine("### Метод ReadKey");
            Console.WriteLine();
            
            Console.WriteLine("Нажмите любую клавишу:");
            var key2 = Console.ReadKey();
            Console.WriteLine(key2.Key);
            Console.WriteLine(key2.KeyChar);
        }
    }
}
