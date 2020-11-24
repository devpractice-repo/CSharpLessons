using System;
using System.Text;

namespace CSharpLesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Знакомство со строками в C#            
            Console.WriteLine("## Знакомство со строками в C#");
            string s1 = "Hello, World!";
            Console.WriteLine(s1);

            var s2 = "Create by var";
            Console.WriteLine(s2);

            string s3 = "Hello, ";
            string s4 = s3 + "John!";
            Console.WriteLine(s4);            
            
            Console.WriteLine("");

            // ## Создание и инициализация объекта класса String
            Console.WriteLine("## Создание и инициализация объекта класса String");
            string s5 = "test1";
            var s6 = "test2";

            Console.WriteLine("first line\nSecond line");
            Console.WriteLine("");
            Console.WriteLine(@"first line\nSecond line");
            Console.WriteLine("");

            int age = 27;
            Console.WriteLine(String.Format("Age: {0}", age));  // "Age: 27"
            Console.WriteLine("");
            Console.WriteLine($"Age: {age}"); // "Age: 27"
            Console.WriteLine("");

            string s7 = new string("test3");
            
            char[] charArray = {'H', 'e', 'l', 'l', 'o'};
            string s8 = new string(charArray); // "Hello"

            string s9 = new string('O', 10); // "OOOOOOOOOO"
            Console.WriteLine("");

            // ## Базовый API для работы со строками
            // ### Объединение строк. Оператор +, методы Concat и Join
            Console.WriteLine("## Базовый API для работы со строками");
            Console.WriteLine("### Объединение строк. Оператор +, методы Concat и Join");
            string s10 = "Area";
            string s11 = " 51";
            Console.WriteLine("Concate by +: " + s10 + s11);

            Console.WriteLine("Concate by Concate(): " + string.Concat(s10, s11));

            string[] sArr1 = {"First ", "Second ", "Third "};
            Console.WriteLine("Join elements in array by Concate(): " + string.Concat(sArr1));

            string[] sArr2 = {"First", "Second", "Third"};
            Console.WriteLine("Join elements in array by Join() with space: " + string.Join(" ", sArr2));
            Console.WriteLine("Join elements in array by Join() with <->: " + string.Join("<->", sArr2));
            Console.WriteLine("");

            // ### Поиск и извлечение элементов из строки. 
            // Оператор [], методы IndexOf, IndexOfAny, LastIndexOf, LastIndexOfAny, Substring
            Console.Write("### Поиск и извлечение элементов из строки. ");
            Console.Write("Оператор [], методы IndexOf, IndexOfAny, LastIndexOf, LastIndexOfAny, Substring");
            string s12 = "Hello";
            Console.WriteLine("Get element by index s12[3]: " + s12[3]);

            // s1 = "Hello, World!"
            // Поиск первого вхождения символа 'r'
            Console.WriteLine("Index of \'r\': " + s1.IndexOf('r')); 
            // Поиск первого вхождения символа 'l' начиная с позиции 4
            Console.WriteLine("Index of \'l\', start at 4: " + s1.IndexOf('l', 4));
            // Поиск первого вхождения строки "World"
            Console.WriteLine("Index of \"World\": " + s1.IndexOf("World")); 
            // Поиск первого вхождения символа из набора ['o', 'd', ',']
            Console.WriteLine("Index of pos of any symbol in array: " + s1.IndexOfAny(new char[] {'o', 'd', ','})); 

            // Поиск последнего вхождения символа 'l'
            Console.WriteLine("Last index of \'l\': " + s1.LastIndexOf('l')); 
            // Поиск последнего вхождения строки "or"
            Console.WriteLine("Last index of \"or\": " + s1.LastIndexOf("or")); 
            // Поиск последнего вхождения символа из набора ['o', 'd', ',']
            Console.WriteLine("Last index of pos of any symbol in array: " + s1.LastIndexOfAny(new char[] {'o', 'd', ','})); 

            // Извлечение подстроки
            Console.WriteLine("Substring start at pos 7: " + s1.Substring(7));  // World!
            Console.WriteLine("Substring start at pos 7 (4 chars): " + s1.Substring(7, 4)); // Worl

            // Проверка наличия подстроки
            Console.WriteLine("Contains \"World\"? " + s1.Contains("World")); // True
            Console.WriteLine("Starts with \"He\"? " + s1.StartsWith("He")); // True
            Console.WriteLine("Ends with \"ld\"? " + s1.EndsWith("ld")); // False
            Console.WriteLine("");

            // ### Сравнение срок
            Console.WriteLine("### Сравнение срок");
            string t1 = "John";
            string t2 = "John";
            string t3 = "Mary";
            Console.WriteLine("t1 == t2: " + (t1 == t2));   // True
            Console.WriteLine("t1 != t2: " + (t1 != t2));   // False
            Console.WriteLine("t1 == t3: " + (t1 == t3));   // False

            Console.WriteLine("Equals method: t1.Equals(t2)" + t1.Equals(t2));   // True
            Console.WriteLine("Equals method: t1.Equals(t3)" + t1.Equals(t3));   // False
            Console.WriteLine("");

            // ### Модификация срок ----
            Console.WriteLine("### Модификация срок");
            // Вставка, удаление и замена
            Console.WriteLine("Insert: " + "123789".Insert(3, "[456]")); // 123[456]789
            Console.WriteLine("PadLeft: ");
            Console.WriteLine("some string".PadLeft(15)); // "    some string"
            Console.WriteLine("some string".PadLeft(15, '*')); // "****some string"
            Console.WriteLine("PadRight: ");
            Console.WriteLine("some string".PadRight(15)); // "some string    "
            Console.WriteLine("some string".PadRight(15, '*')); // "some string****"
            Console.WriteLine("Remove demo1: " + "Hello".Remove(2));
            Console.WriteLine("Remove demo2: " + "Hello".Remove(2, 2));
            Console.WriteLine("Hello, World!".Replace('!', '.')); // Hello, World.
            Console.WriteLine("Hello, World!".Replace("World", "John")); // Hello, John!
            // Управление регистром
            Console.WriteLine("Hello, World!".ToUpper()); // HELLO, WORLD!
            Console.WriteLine("Hello, World!".ToLower()); // hello, world!
            // Удаление начальных и конечных символов строки
            Console.WriteLine("   hello   ".Trim());    // "hello"
            Console.WriteLine("***hello---".Trim('*'));    // "hello---"
            Console.WriteLine("***hello---".Trim(new char[] {'*', '-'}));    // "hello"
            Console.WriteLine("   hello   ".TrimStart());   // "hello   "            
            Console.WriteLine("   hello   ".TrimEnd()); // "   hello"
            Console.WriteLine("");

            //### Методы и свойства общего назначения
            Console.WriteLine("### Методы и свойства общего назначения");
            Console.WriteLine("Hello".Length); // 5
            foreach(var s in "1 2 3".Split(' '))
                Console.WriteLine(s);

            foreach(var s in "1 2 3-4-5-6".Split(new char[]{' ', '-'}))
                Console.WriteLine(s);
            
            Console.WriteLine("");

            //## Форматирование строк
            Console.WriteLine("## Форматирование строк");
            // ToString
            Console.WriteLine(12345.ToString("X"));
            
            // String.Format
            Console.WriteLine(string.Format("value: {0}", 1.23456));
            Console.WriteLine(string.Format("value: {0:F}", 1.23456));
            Console.WriteLine(string.Format("value: {0:d}", DateTime.Now));
            
            // WriteLine без использования String.Format
            Console.WriteLine("value: {0}", 1.23456);   // 1,23456
            Console.WriteLine("value: {0:F}", 1.23456); // 1.235
            Console.WriteLine("date: {0:d}", DateTime.Now); // 07.09.2020

            Console.WriteLine("Only index: {0}", 123); // Only index: 123
            Console.WriteLine("Index with aligment: {0,-5}{1,5}", 123, 456); // Index with aligment: 123    456
            Console.WriteLine("Index with format: 0x{0:X}", 123); // Index with format: 0x7B
            Console.WriteLine("");

            // ### Представление чисел
            Console.WriteLine("### Представление чисел");
            Console.WriteLine("C symbol: {0:C}", 123);      // 123,00 ₽
            Console.WriteLine("D symbol: {0:D5}", 123);     // 00123
            Console.WriteLine("E symbol: {0:E}", 123456789);// 1,234568E+008
            Console.WriteLine("F symbol: {0:F2}", 123.4567);// 123,46
            Console.WriteLine("P symbol: {0:P}", 0.123);    // 123,46
            Console.WriteLine("X symbol: 0x{0:X}", 567);    // 0x237
            Console.WriteLine("0 symbol: {0:000.00}", 12.6789);// 012,68
            Console.WriteLine("# symbol: {0:##}", 14.6789); // 15
            Console.WriteLine("");

            // ### Представление даты и времени
            Console.WriteLine("### Представление даты и времени");
            Console.WriteLine("d symbol: {0:d}", DateTime.Now);
            Console.WriteLine("D symbol: {0:D}", DateTime.Now);
            Console.WriteLine("f symbol: {0:f}", DateTime.Now);
            Console.WriteLine("F symbol: {0:F}", DateTime.Now);
            Console.WriteLine("g symbol: {0:g}", DateTime.Now);
            Console.WriteLine("G symbol: {0:G}", DateTime.Now);
            Console.WriteLine("t symbol: {0:t}", DateTime.Now);
            Console.WriteLine("T symbol: {0:T}", DateTime.Now);
            Console.WriteLine("{0:yyyy-MM-dd}", DateTime.Now);
            Console.WriteLine("{0:dd/MM/yy}", DateTime.Now);
            Console.WriteLine("{0:dd/MM/yy HH:mm:ss}", DateTime.Now);
            Console.WriteLine("");

            //## $ — интерполяция строк
            Console.WriteLine("## $ — интерполяция строк");
            int n1 = 45678;
            double d1 = 123.34567;
            bool b1 = true;
            string sv = "test";
            Console.WriteLine($"int val: {n1}, double val: {d1:#.###}");
            Console.WriteLine($"bool val: {b1}, string val: {sv}");
            Console.WriteLine("");

            // ## Управляющие символы (литералы)
            Console.WriteLine("## Управляющие символы (литералы)");
            Console.WriteLine("\aName:\t\"John\"\nAge:\t\"27\"");

            // ## @ - буквальный идентификатор
            Console.WriteLine("## @ - буквальный идентификатор");
            Console.WriteLine(@"escape is not work: \a\t\n\x1234");
            Console.WriteLine("");

            // ## Класс StringBuilder
            Console.WriteLine("## Класс StringBuilder");
            string outString = "";
            for(int i = 0; i < 10; i++)
            {
                outString += i.ToString() + " - ";
            }
            Console.WriteLine(outString);

            var sb = new StringBuilder();
            for(int i = 0; i < 10; i++)
            {
                sb.Append(i.ToString());
                sb.Append(" - ");
            }
            outString = sb.ToString();
            Console.WriteLine(outString);
        }
    }
}
