using System;

namespace CSharpLesson7
{
    class Program
    {
        enum TypeOS
        {
            Windows, Linux, MacOS, Android
        }
        enum WeekDay
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        enum Season
        {
            Spring, Summer, Autumn, Winter
        }

        [Flags]
        enum Mounts
        {
            January = 2,
            February = 4,
            March = 8,
            April = 16,
            May = 32,
            June = 64,
            July = 128,
            August = 256,
            September = 512,
            October = 1024,
            November = 2048,
            December = 4096,
            Winter = November | December | January
        }

        static void Main(string[] args)
        {
            // ## Работа с переменными типа перечисления
            Console.WriteLine("## Работа с переменными типа перечисления");

            WeekDay wd;
            int dayNum;
            wd = WeekDay.Friday;
            Console.WriteLine($"Пример дня недели: {wd}");

            dayNum = (int)wd;
            Console.WriteLine($"{wd} идет в перечислении под номером {dayNum}");

            wd -= 3;
            dayNum = (int)wd;
            Console.WriteLine($"{wd} идет в перечислении под номером {dayNum}");

            WorkAtDay(WeekDay.Monday);
            WorkAtDay(WeekDay.Friday);
            WorkAtDay((WeekDay)3);
            WorkAtDay(WeekDay.Sunday);

            Console.WriteLine();

            // ## Тип System.Enum
            Console.WriteLine("## Тип System.Enum");
            // ### Определение типа элемента перечисления
            Console.WriteLine("### Определение типа элемента перечисления");
            Console.WriteLine($"Тип элемента Season.Spring: {Season.Spring.GetType()}");
            Console.WriteLine($"Базовый тип элемента Season.Spring: {Enum.GetUnderlyingType(Season.Spring.GetType())}");
            Console.WriteLine();

            // ### Конвертация числа в константу перечисления
            Console.WriteLine("### Конвертация числа в константу перечисления");
            Type enumType = Season.Spring.GetType();
            int n1 = 3;
            int n2 = 0;
            Console.WriteLine($"Преобразование числа {n1} в перечисление Season: {Enum.ToObject(enumType, n1)}");
            Console.WriteLine($"Преобразование числа {n2} в перечисление Season: {Enum.ToObject(enumType, n2)}");

            int n3 = 5;
            Console.WriteLine($"Преобразование числа {n3} в перечисление Season {Enum.ToObject(enumType, n3)}");
            Console.WriteLine();

            // ### Проверка наличия целочисленного (или строкового) значения в заданном перечислении
            Console.WriteLine("### Проверка наличия целочисленного (или строкового) значения в заданном перечислении");
            int n4 = 5;
            Console.WriteLine($"Существует ли элемент под номером {n4} в перечислении: {Enum.IsDefined(enumType, n4)}");
            Console.WriteLine();

            // ### Форматированное строковое представление значения перечисления
            Console.WriteLine("### Форматированное строковое представление значения перечисления");
            var season = Season.Winter;
            Console.WriteLine($"Численное значение времени года {season}: {Enum.Format(typeof(Season), season, "d")}.");
            Console.WriteLine($"Значение в формате hex времени года {season}: {Enum.Format(typeof(Season), season, "x")}.");
            Console.WriteLine();

            // ### Преобразование строки или числа в значение перечисления
            Console.WriteLine("### Преобразование строки или числа в значение перечисления");
            string[] arr = { "5", "0", "3", "Autumn", "Summer, Winter" };
            foreach (var strVal in arr)
            {
                var seasonVal = (Season)Enum.Parse(typeof(Season), strVal, true);
                Console.WriteLine($"Преобразовали \"{strVal}\" в {seasonVal}");
            }
            Console.WriteLine();

            // ### Получение имен элементов перечисления их численных значений в виде массивов
            Console.WriteLine("### Получение имен элементов перечисления их численных значений в виде массивов");
            Console.WriteLine("Элементы перечисления Season:");
            foreach (string s in Enum.GetNames(typeof(Season)))
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Численные значения элементов перечисления Season:");
            foreach (int s in Enum.GetValues(typeof(Season)))
            {
                Console.WriteLine(s);
            }

            // ## Битовые флаги
            Console.WriteLine("## Битовые флаги");

            Mounts summerMount = Mounts.June | Mounts.July | Mounts.August;
            Console.WriteLine($"Летние месяцы: {summerMount}");            
            Mounts secondSemester = summerMount | Mounts.September | Mounts.October | Mounts.November;
            Console.WriteLine($"Осенние месяцы: { summerMount ^ secondSemester}");
        }

        static void WorkAtDay(WeekDay wd)
        {
            switch (wd)
            {
                case WeekDay.Monday:
                    Console.WriteLine($"{wd} - Физкультура");
                    break;
                case WeekDay.Friday:
                    Console.WriteLine($"{wd} - Литература");
                    break;
                case WeekDay.Wednesday:
                    Console.WriteLine($"{wd} - Математика");
                    break;
                default:
                    Console.WriteLine($"{wd} - День отдыха");
                    break;
            }
        }

    }
}
