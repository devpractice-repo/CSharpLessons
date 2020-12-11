using System;

namespace CSharpLesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Объявление массивов и инициализация массивов
            // ### Объявление массивов
            Console.WriteLine("## Объявление массивов и инициализация массивов");
            Console.WriteLine("### Объявление массивов");

            int[] na1; // массив типа int

            int[] na2 = new int[5]; // массив из пяти элементов типа int

            int[] na3;
            na3 = new int[5]; // массив из пяти элементов типа int

            Console.WriteLine(na3[0]); // значение: 0
            Console.WriteLine(na3[1]); // значение: 0
            //Console.WriteLine(na1[0]); // ошибка компиляции
            Console.WriteLine();

            // ### Инициализация массивов
            Console.WriteLine("### Инициализация массивов");

            bool[] ba1 = new bool[3];
            Console.WriteLine("ba1[0]: " + ba1[0].ToString());

            string[] sa1 = new string[3];
            sa1[0] = "abc";
            sa1[1] = "def";
            sa1[2] = "ghi";
            Console.WriteLine($"sa1: {sa1[0]}, {sa1[1]}, {sa1[2]}");

            double[] da1 = new double[3] { 0.1, 0.2, 0.3 };
            Console.WriteLine($"da1: {da1[0]}, {da1[1]}, {da1[2]}");

            double[] da2 = { 0.4, 0.5, 0.6 };
            Console.WriteLine($"da2: {da2[0]}, {da2[1]}, {da2[2]}");

            Console.WriteLine();

            // ### Неявная типизация
            Console.WriteLine("### Неявная типизация");

            var va2 = new string[3];
            va2[0] = "John";
            va2[1] = "Mary";
            va2[2] = "Mike";
            Console.WriteLine($"va2: {va2[0]}, {va2[1]}, {va2[2]}");

            var va1 = new[] { 1, 2, 3 };
            Console.WriteLine($"va1: {va1[0]}, {va1[1]}, {va1[2]}");

            Console.WriteLine();

            // ## Доступ к элементам массива. Обход элементов массива
            Console.WriteLine("## Доступ к элементам массива. Обход элементов массива");

            int[] na4 = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"na4[0]: {na4[0]}");
            //Console.WriteLine($"na4[10]: {na4[10]}");

            for (int i = 0; i < na4.Length; i++)
            {
                Console.Write(na4[i].ToString() + " ");
            } // 1 2 3 4 5
            Console.WriteLine();

            foreach (var v in na4)
            {
                Console.Write(v.ToString() + " ");
            } // 1 2 3 4 5
            Console.WriteLine();

            for (int i = 0; i < na4.Length; i++)
            {
                na4[i] = (na4[i] + 3) * 10;
                Console.Write(na4[i].ToString() + " ");
            } // 40 50 60 70 80
            Console.WriteLine();

            // ## Передача массива в метод
            Console.WriteLine("## Передача массива в метод");

            int[] na5 = { 1, 2, 3, 4, 5 };
            foreach (var v in na5) // 1 2 3 4 5
                Console.Write(v + " ");

            Console.WriteLine();

            WorkWithArray(na5);

            foreach (var v in na5) // 123 2 3 4 5
                Console.Write(v + " ");

            Console.WriteLine();

            // ## Многомерные массивы
            // ### Прямоугольные массивы
            Console.WriteLine("## Многомерные массивы");
            Console.WriteLine("### Прямоугольные массивы");

            double[,] dm1 = new double[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    dm1[i, j] = i + j;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write($"{dm1[i, j]} ");
                Console.WriteLine();
            }

            Console.WriteLine();

            double[,] dm2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write($"{dm2[i, j]} ");
                Console.WriteLine();
            }
            Console.WriteLine();

            // ## Зубчатые массивы
            Console.WriteLine("## Зубчатые массивы");

            int[][] nm1 = new int[3][];

            for (int i = 0; i < nm1.Length; i++)
                nm1[i] = new int[i + 1];

            for (int i = 0; i < nm1.Length; i++)
            {
                for (int j = 0; j < nm1[i].Length; j++)
                    Console.Write($"{nm1[i][j]} ");

                Console.WriteLine();
            }
            
            Console.WriteLine();

            // ## Класс System.Array
            Console.WriteLine("## Класс System.Array");

            int[] na6 = { 1, 2, 3, 4, 5, 6, 7 };
            int[,] nm2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[][] nm3 = new int[3][];
            
            for (int i = 0; i < nm3.Length; i++)
                nm3[i] = new int[i + 1];

            Console.WriteLine($"na6: Length={na6.Length}, Rank={na6.Rank}"); // na6: Length=7, Rank=1
            Console.WriteLine($"nm2: Length={nm2.Length}, Rank={nm2.Rank}"); // nm2: Length=6, Rank=2
            Console.WriteLine($"nm3: Length={nm3.Length}, Rank={nm3.Rank}"); // nm3: Length=3, Rank=1
                        
            Console.WriteLine("BinarySearch result: " + Array.BinarySearch(na6, 5).ToString()); // BinarySearch result: 4

            var na7 = (int[])na6.Clone();

            Array.Clear(na7, 2, 2);

            PrintArray<int>("na6", na6); // na6: 1 2 3 4 5 6 7
            PrintArray<int>("na7", na7); // na7: 1 2 0 0 5 6 7

            Array.Copy(na7, na6, 4);
            PrintArray<int>("na6 after copy", na6); // na6 after copy: 1 2 0 0 5 6 7

            (new int[] { 1, 2, 3, 4 }).CopyTo(na6, 0);
            PrintArray<int>("na6", na6); // na6: 1 2 3 4 5 6 7

            var ans = Array.Exists<int>(na6, v => (v % 2) == 0);
            Console.WriteLine($"Is even number exists in na6? Answer: {ans}");

            Array.Fill<int>(na7, 7);
            PrintArray<int>("na7", na7); // na7: 7 7 7 7 7 7 7

            Console.WriteLine($"Value at 3 index in na6: {na6.GetValue(3)}");

            Console.WriteLine($"Index of value=5 in na6: {Array.IndexOf(na6, 5)}");

            Array.Reverse(na6);
            PrintArray<int>("na6", na6); // na6: 7 6 5 4 3 2 1

            Array.Sort(na6);
            PrintArray<int>("na6", na6); // na6: 1 2 3 4 5 6 7

        }
        public static void WorkWithArray(int[] arr)
        {
            arr[0] = 123;
        }

        public static void PrintArray<T>(string txt, T[] arr)
        {
            Console.Write($"{txt}: ");
            foreach(var v in arr)
            {
                Console.Write($"{v} ");
            }
        }
    }
}
