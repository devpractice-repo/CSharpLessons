using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace CSharpLesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            // # Коллекции в языке C#. Пространство имен System.Collections.Generic
            // ## Класс List<T>
            // ### Создание объекта класса List<T>
            Console.WriteLine("# Коллекции в языке C#. Пространство имен System.Collections.Generic");
            Console.WriteLine("## Класс List<T>");
            Console.WriteLine("### Создание объекта класса List<T>");
            List<int> nums = new List<int> {1, 2, 3, 4, 5};
            var words = new List<string> {"one", "two", "three"};
            Console.WriteLine($"nums[0] = {nums[0]}, words[0] = {words[0]}");
            Console.WriteLine();

            // ### Работа с объектами List<T>
            Console.WriteLine("### Работа с объектами List<T>");
            Console.WriteLine("Свойства");
            Console.WriteLine($"Count: nums.Count = {nums.Count}");
            Console.WriteLine($"Capacity: nums.Capacity = {nums.Capacity}");
            Console.WriteLine();
            
            Console.WriteLine("Методы");
            Console.WriteLine($"nums: {ListToString(nums)}");            
            nums.Add(6);
            Console.WriteLine($"nums.Add(6): {ListToString(nums)}");            
            Console.WriteLine($"words.BinarySearch(\"two\"): {words.BinarySearch("two")}");
            Console.WriteLine($"nums.Contains(10): {nums.Contains(10)}");
            Console.WriteLine($"words.IndexOf(\"three\"): {words.IndexOf("three")}");
            Console.WriteLine($"nums.ForEach(v => v * 10)");
            nums.ForEach(v => Console.Write($"{v} => "));            
            nums.Insert(3, 7);
            Console.WriteLine();
            Console.WriteLine($"nums.Insert(3, 7): {ListToString(nums)}");
            Console.WriteLine($"words.Find(v => v.Length == 3): {words.Find(v => v.Length == 3)}");
            words.Remove("two");
            Console.WriteLine($"words.Remove(\"two\"): {ListToString(words)}");
            Console.WriteLine();

            Console.WriteLine("Работа с пользовательским типом");
            List<Player> players = new List<Player> {
                new Player { Name = "Psy", Skill = "Monster"},
                new Player { Name = "Kubik", Skill = "Soldier"},
                new Player { Name = "Triver", Skill = "Middle"},
                new Player { Name = "Terminator", Skill = "Very High"}
            };

            Console.WriteLine("Количество элементов в players:{0}", players.Count);
            
            //Добавим новый элемент списка players
            players.Insert(1, new Player { Name = "Butterfly", Skill = "flutter like a butterfly, pity like a bee"});

            //Посмотрим на все элементы списка
            players.ForEach(p => Console.WriteLine($"{p.Name}, skill: {p.Skill}"));

            // ## Класс Dictionary<TKey,TValue>
            // ### Создание объекта класса Dictionary<TKey,TValue>
            Console.WriteLine("## Класс Dictionary<TKey,TValue>");
            Console.WriteLine("### Создание объекта класса Dictionary<TKey,TValue>");
            
            var dict = new Dictionary<string, int>();
            var prodPrice = new Dictionary<string, double>() 
            {
                ["bread"] = 23.3,
                ["apple"] = 45.2
            };

            Console.WriteLine($"bread price: {prodPrice["bread"]}");
            Console.WriteLine();

            // ### Работа с классом Dictionary<TKey,TValue>
            Console.WriteLine("### Работа с классом Dictionary<TKey,TValue>");
            Console.WriteLine("Свойства");
            Console.WriteLine($"Словарь prodPrice: {DictToString(prodPrice)}");
            Console.WriteLine($"Count: {prodPrice.Count}");
            Console.WriteLine($"Keys: {ListToString(prodPrice.Keys.ToList<string>())}");
            Console.WriteLine($"Values: {ListToString(prodPrice.Values.ToList<double>())}");
            Console.WriteLine();

            Console.WriteLine("Методы");
            prodPrice.Add("tomate", 11.2);
            Console.WriteLine($"Словарь prodPrice: {DictToString(prodPrice)}");
            var isExistValue = prodPrice.ContainsValue(11.2);
            Console.WriteLine($"isExistValue = {isExistValue}");
            var isExistKey = prodPrice.ContainsKey("tomate");
            Console.WriteLine($"isExistKey = {isExistKey}");
            prodPrice.Remove("bread");
            Console.WriteLine($"Словарь prodPrice: {DictToString(prodPrice)}");
            var isOrangeAdded = prodPrice.TryAdd("orange", 20.1);
            Console.WriteLine($"isOrangeAdded = {isOrangeAdded}");
            double orangePrice;
            var isPriceGetted = prodPrice.TryGetValue("orange", out orangePrice);
            Console.WriteLine($"isPriceGetted = {isPriceGetted}");
            Console.WriteLine($"orangePrice = {orangePrice}");
            prodPrice.Clear();
            Console.WriteLine($"Словарь prodPrice: {DictToString(prodPrice)}");
            Console.WriteLine();
            
             // ### Кортежи Tuple и ValueTuple
            Console.WriteLine("### Кортежи Tuple и ValueTuple");
            (string, int) p1 = ("John", 21);
            (string Name, int Age) p2 = ("Mary", 23);
            Console.WriteLine($"p1: Name: {p1.Item1}, Age: {p1.Item2}");
            Console.WriteLine($"p2: Name: {p2.Name}, Age: {p2.Age}");

            var p3 = (Name: "Alex", Age: 24);
            var Name = "Lynda";
            var Age = 25;
            var p4 = (Name, Age);
            Console.WriteLine($"p3: Name: {p3.Name}, Age: {p3.Age}");
            Console.WriteLine($"p4: Name: {p4.Name}, Age: {p4.Age}");

            Console.WriteLine($"p3: Name: {p3.Item1}, Age: {p3.Item2}");
            Console.WriteLine($"p4: Name: {p4.Item1}, Age: {p4.Item2}");

            var p5 = ("Jane", 26);
            (string, int) p6 = p5;
            Console.WriteLine($"p6: Name: {p6.Item1}, Age: {p6.Item2}");
            (string name, int age) = p5;
            Console.WriteLine($"Name: {name}, Age: {age}");
            
        }
        class Player
        {
            public string Name { get; set; }
            public string Skill { get; set; }
        }

        static (bool isLonger, int count) LongerThenLimit(string str, int limit) =>
            str.Length > limit ? (true, str.Length) : (false, str.Length);
        
        static private string ListToString<T>(List<T> list) =>
            "{" + string.Join(", ", list.ToArray()) + "}";

        static private string DictToString<K, V>(Dictionary<K, V> dict) =>
            string.Join("; ", dict.Select(item => $"{item.Key} = {item.Value}").ToArray());
    }
}
