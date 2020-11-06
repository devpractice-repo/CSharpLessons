using System;

namespace CSharpLesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Числовые типы
            // ### Приведение типов
            Console.WriteLine("## Числовые типы");
            Console.WriteLine("### Приведение типов");
            Console.WriteLine("byte to short");
            byte bt1 = 100;
            short s1 = bt1;  // расширение типа
            Console.WriteLine($"byte value: {bt1}, short value: {s1}");
            Console.WriteLine("");

            Console.WriteLine("short to byte");
            short s2 = 100;
            //byte b2 = s2;   // приведет к ошибке компиляции

            byte bt2 = (byte)s2; // явное приведение к типу byte
            Console.WriteLine($"byte value: {bt2}, short value: {s2}");
            Console.WriteLine("");

            Console.WriteLine("short to byte with overflow");
            short s3 = 150;
            short s4 = 150;
            byte bt3 = (byte)(s3 + s4); // переполнение для типа byte
            Console.WriteLine($"Result: {bt3}");
            Console.WriteLine("");

            // ### Проверка переполнения
            Console.WriteLine("#### Проверка переполнения");
            Console.WriteLine("Checked example 1");
            try
            {
                short s5 = 150;
                short s6 = 150;
                byte bt4 = checked((byte)(s5 + s6));
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow is detected!");
            }
            Console.WriteLine("");

            Console.WriteLine("Checked example 2");
            // Контроль переполнения для группы операторов
            try
            {
                checked
                {
                    short s5 = 150;
                    short s6 = 150;
                    byte bt4 = (byte)(s5 + s6);
                    byte bt5 = (byte)(s5 * 100);
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow is detected!");
            }
            Console.WriteLine("");

            // #### Класс System.Convert
            Console.WriteLine("#### Класс System.Convert");
            short s7 = 100;
            byte bt6 = System.Convert.ToByte(s7);
            Console.WriteLine($"byte value: {bt6}, short value: {s7}");

            short s8 = 500;
            //byte bt7 = System.Convert.ToByte(s8);  // Console.WriteLine("");
            //Console.WriteLine($"byte value: {bt7}, short value: {s8}");

            Console.WriteLine("");

            // ### Арифметические операции
            Console.WriteLine("### Арифметические операции");
            Console.WriteLine($"3 + 4 = {3 + 4}");
            Console.WriteLine($"7 - 5 = {(7 - 5)}");
            Console.WriteLine($"2 * 9 = {(2 * 9)}");
            Console.WriteLine($"8 / 4 = {(8 / 4)}");
            Console.WriteLine($"4.5 / 2 = {(4.5 / 2)}");
            Console.WriteLine($"8 % 4 = {(8 % 4)}");
            Console.WriteLine($"7 % 3 = {(7 % 3)}");
            Console.WriteLine("");

            int n1 = 5;
            Console.WriteLine($"n1++: {n1++}");
            Console.WriteLine($"n1 = {n1}");
            Console.WriteLine("");

            int n2 = 5;
            Console.WriteLine($"++n2: {++n2}");
            Console.WriteLine($"n2 = {n2}");
            Console.WriteLine("");

            int n3 = 9;
            Console.WriteLine($"n3--: {n3--}");
            Console.WriteLine($"n3 = {n3}");
            Console.WriteLine("");

            int n4 = 9;
            Console.WriteLine($"--n4: {--n4}");
            Console.WriteLine($"n4 = {n4}");
            Console.WriteLine("");

            int d1 = 10;
            int d2 = 3;
            Console.WriteLine($"d1 = {d1}\nd2 = {d2}");

            d1 += d2;
            Console.WriteLine($"d1 += d2: {d1}");

            d1 -= d2;
            Console.WriteLine($"d1 -= d2: {d1}");

            d1 *= d2;
            Console.WriteLine($"d1 *= d2: {d1}");

            d1 /= d2;
            Console.WriteLine($"d1 /= d2: {d1}");

            d1 %= d2;
            Console.WriteLine($"d1 %= d2: {d1}");
            Console.WriteLine("");

            // ### Класс Math
            // #### Функции округления
            Console.WriteLine("### Класс Math");
            Console.WriteLine("#### Функции округления");
            Console.WriteLine(Math.Ceiling(4.5)); // ответ: 5
            Console.WriteLine(Math.Floor(4.5)); // ответ: 4
            Console.WriteLine(Math.Round(4.7)); // ответ: 5
            Console.WriteLine(Math.Round(4.5)); // ответ: 4            
            Console.WriteLine(Math.Round(5.5)); // ответ: 6
            Console.WriteLine("");

            // #### Тригонометрические функции
            Console.WriteLine("#### Тригонометрические функции");
            Console.WriteLine(Math.Cos(30));
            Console.WriteLine(Math.Sin(30));
            Console.WriteLine(Math.Tan(30));
            Console.WriteLine("");

            // #### Разное
            Console.WriteLine("#### Разное");
            Console.WriteLine(Math.Exp(Math.E)); // ответ: 1
            Console.WriteLine(Math.Log(Math.E)); // ответ: 1
            Console.WriteLine(Math.Log(9, 3));  // ответ: 2
            Console.WriteLine(Math.Log10(100)); // ответ: 2
            Console.WriteLine(Math.Log2(128)); // ответ: 7
            Console.WriteLine(Math.Pow(5, 2)); // ответ: 25
            Console.WriteLine(Math.Abs(-10)); // ответ: 10
            Console.WriteLine(Math.Min(10, 7)); // ответ: 7
            Console.WriteLine(Math.Max(5, 2)); // ответ: 5
            Console.WriteLine(Math.Sign(-2)); // ответ: -1
            Console.WriteLine("");

            // ### Преобразование числа в строку
            Console.WriteLine("### Преобразование числа в строку");
            Console.WriteLine(123.ToString());

            int n5 = 701;
            Console.WriteLine(n5.ToString());

            Console.WriteLine(5.234.ToString());

            Console.WriteLine("");

            // ### Преобразование строки в число
            // #### Класс Convert
            Console.WriteLine("### Преобразование строки в число");
            Console.WriteLine("#### Класс Convert");
            int n6 = Convert.ToInt32("123");
            int n7 = Convert.ToInt32(true);
            Console.WriteLine($"n6 = {n6}, n7 = {n7}");

            int n8 = Convert.ToInt32("0x0d", 16);
            string str1 = Convert.ToString(n8, 16);
            Console.WriteLine($"n8 = {n8}, hex format: n3 = 0x{str1}");

            Console.WriteLine($"From bin: {Convert.ToInt32("1111011", 2)}");
            Console.WriteLine($"From oct: {Convert.ToInt32("173", 8)}");
            Console.WriteLine($"From hex: {Convert.ToInt32("7b", 16)}");

            Console.WriteLine("");

            // #### Методы числовых типов            
            Console.WriteLine("#### Методы числовых типов");

            int value;
            if (int.TryParse("123", out value))
            {
                Console.WriteLine($"Value: {value}");
            } // Будет выведено: Value: 123

            if (int.TryParse("hello", out value))
            {
                Console.WriteLine($"Value: {value}");
            }
            else
            {
                Console.WriteLine("Can't parse string");
            } // Будет выведено: Can't parse string

            Console.WriteLine(int.Parse("123"));
            try
            {
                int n9 = int.Parse("hello");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("");

            // ## Тип данных Boolean
            // ### Логические операторы 
            Console.WriteLine("## Тип данных Boolean");
            Console.WriteLine("### Логические операторы");

            bool b1 = true;
            bool b2 = !b1; // false
            bool b3 = true & b1; // true
            bool b4 = false & b1; // true
            bool b5 = b1 && b2; // false
            bool b6 = b1 || b2; // true
            b1 &= true; // true
            b1 |= false; // true
        }
    }
}
