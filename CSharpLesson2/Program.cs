using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Объявление и инициализация переменных 
            int nVal; 
            string strVal;

            int radius = 10;    // объявление и инициализация
            
            string name;        // объявление
            name = "John";      // присвоение значения

            // Перед использованием переменная должна быть проинициализированна
            // Если раскомментировать следующие две строки, то проект не будет скомпилирован
            // int notInitedVal;
            // Console.Write(notInitedVal);

            // ### Ключевое слово new
            Console.WriteLine("Keyword: new");
            
            Rectangle rect = new Rectangle();
            Console.WriteLine($"Rectangle Width={rect.Width}, Height={rect.Height}");
            
            int newInitedValue = new int();
            Console.WriteLine("Default int value: " + newInitedValue);
            Console.WriteLine("");

            // ### Ключевое слово var. Неявная типизация
            Console.WriteLine("Keyword: var");

            int v1 = 12345;
            var v2 = 12345;
            Console.WriteLine($"Type of v1: {v1.GetType()}\nType of v2: {v2.GetType()}");
            Console.WriteLine("");

            // ## Ссылочные типы данных и типы-значения в C#
            // ### Типы значения
            // #### Простые типы
            // ##### Целочисленные типы
            int n1 = 1000;
            System.Int32 n2 = 1000;

            var l1 = 1000L;     // число типа long
            var l2 = 1000UL;    // число типа ulong

            int nDec = 456;     // десятичный формат
            int nHex = 0x1C8;   // шестнадцатеричный формат: используется префикс 0x или 0X
            int nBin = 0b_1101; // двоичный формат, используется префикс 0b или 0B


            // ##### Типы с плавающей запятой
            float f1 = 0.123f;  // тип данных float, литеры f или F
            double d1 = 0.123d; // тип данных double, литеры d или D либо без литеры
            decimal dd1 = 0.123m;   // тип данных decimal, литеры m или M

            // ##### Тип bool
            bool b1 = false;
            System.Boolean b2 = true;

            // ##### Тип char
            char c1 = 'a';
            char c2 = '\u0026';
            char c3 = '\x0026';
            char c4 = (char)38;

            // #### Типы перечисления
            Console.WriteLine("Data type: enum");

            Day day1 = Day.Monday;
            var day2 = Day.Tuesday;
            Console.WriteLine($"day1={day1}, day2={day2}");
            Console.WriteLine("");

            // #### Типы структур
            Console.WriteLine("Data type: struct"); 

            Point p1 = new Point(1,2);
            Console.WriteLine($"Point: ({p1.X}, {p1.Y})");
            Console.WriteLine("");

            // #### Типы кортежей
            (double, double) tp1 = (1.0, 2.0); // явное задание типов элементов кортежа
            var tp2 = (8.1, 4.3); // использование var для объявления кортежа

            // Объявления кортежей с именованием полей
            (double X, double Y) tp3 = (3.2, 5.34);
            var tp4 = (X: 1.2, Y: 3.4);
            var X = 5.6;
            var Y = 7.8;
            var tp5 = (X, Y);

            // ### Ссылочные типы            
            // #### Типы классов
            Console.WriteLine("Data type: class"); 

            Persone persone1 = new Persone("John", 21);
            Console.WriteLine($"Persone: Name: {persone1.Name}, Age: {persone1.Age})");
            Console.WriteLine("");

            // #### Типы интерфейсов
            Console.WriteLine("Interface");   

            IPersone persone2 = new Persone("Jim", 25);
            Console.WriteLine($"Persone: Name: {persone2.Name}, Age: {persone2.Age})");
            Console.WriteLine("");

            // #### Типы массивов
            // Создание и инициализация массивов
            int[] nArr1 = new int[5];
            nArr1[0] = 0;
            nArr1[1] = 1;
            nArr1[2] = 2;
            nArr1[3] = 3;
            nArr1[4] = 4;

            int[,] nMx = new int[2,2]; // прямоугольный массив
            nMx[0,0]=0;
            nMx[0,1]=1;
            nMx[1,0]=2;
            nMx[1,1]=3;

            int[][] jg = new int[2][]; // зубчатый массив
            jg[0] = new int[3];
            jg[1] = new int[1];

            // ## Nullable-типы (нулевые типы) и операция ??
            // ### Объявление и инициализация Nullable-переменных
            
            // int nv = null;  // так делать нельзя
            // bool bv = null; // и так тоже

            int? nv1 = null;
            bool? nv2 = null;

            // Nullable<int> nv1 = null;
            // Nullable<bool> nv2 = null;

            // ### Проверка на null. Работа с HasValue и Value
            Console.WriteLine("Nullable values"); 

            bool? flagA = true;
            if(flagA is bool valueOfFlag)
            {
                Console.WriteLine($"flagA is not null, value: {valueOfFlag}");
            }

            bool? flagB = false;
            if(flagB.HasValue)
            {
                Console.WriteLine($"flagB is not null, value: {flagB.Value}");
            }

            // ### Приведение Nullable-переменной к базовому типу
            double? nvd1 = 12.3;
            // double nvd2 = nvd1; // так делать нельзя

            double nvd3 = (double) nvd1;

            double nvd4 = nvd1 ?? 0.0;
            Console.WriteLine(nvd4);

            bool? nvb1 = null;
            bool nvb2 = nvb1 ?? false;
            Console.WriteLine(nvb1);
            Console.WriteLine(nvb2);
            
            int test1 = GetValue(true) ?? 123;
            Console.WriteLine(test1);

            int test2 = GetValue(false) ?? 123;
            Console.WriteLine(test2);

            Console.WriteLine(""); 

            // ## Ключевое слово dynamic
            Console.WriteLine("dynamic values"); 

            // Создадим переменную типа dynamic и проинициализиуем ее double значением
            dynamic dval1 = 12.3;

            // Посмотрим на ее значение и тип
            Console.WriteLine("Double value");
            Console.WriteLine($"Value: {dval1}");
            Console.WriteLine($"Type: {dval1.GetType()}");

            // Изменим значение переменной:
            dval1 += 17;
            Console.WriteLine("Mod double value");
            Console.WriteLine($"Value: {dval1}");
            Console.WriteLine($"Type: {dval1.GetType()}");

            // Присвоим переменной значение другого типа: bool
            dval1 = true;
            
            // Посмотрим на ее значение и тип
            Console.WriteLine("Convert to bool");
            Console.WriteLine($"Value: {dval1}");
            Console.WriteLine($"Type: {dval1.GetType()}");
            
            dynamic dval2 = "hello"; // в переменной dval2 хранится строковое значение
            Console.WriteLine("String value");
            Console.WriteLine($"Value: {dval2}");
            Console.WriteLine($"Type: {dval2.GetType()}");

            dval2 = 123; // теперь значение типа int
            // dval2 = dval2.ToUpper(); // попытка вызвать на ней .ToUpper() приведет к ошибке
            Console.WriteLine("");
            
            // ## Оператор default
            Console.WriteLine("default operator"); 

            int n3 = new int();
            Console.WriteLine($"Default int value: {n3}");

            int n4 = default(int);
            Console.WriteLine($"Value of int that inited by default(T): {n4}");

            int n5 = default;
            Console.WriteLine($"Value of int that inited by default: {n5}");

            PrintDefaultValue<int>(5);
            PrintDefaultValue<bool>(true);
        }

        static void PrintDefaultValue<T>(T val)
        {
            Console.WriteLine($"Type of val: {val.GetType()}, default value: {default(T)}, current value: {val}");
        }
        
        static int? GetValue(bool flag)
        {
            if (flag == true)
                return 1000;
            else
                return null;
        }
    }

    class Rectangle
    {
        public double Width = 0;
        public double Height = 0;
    }

    enum Day { Sunday, Monday, Tuesday,  Wednesday,  Thursday,  Friday,  Saturday };

    struct Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X {get;}
        public double Y {get;}
    }

    class Persone: IPersone
    {
        public Persone(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name {get;set;}
        public int Age {get;set;}
    }

    interface IPersone
    {
        string Name {get;set;}
        int Age {get;set;}
    }
}
