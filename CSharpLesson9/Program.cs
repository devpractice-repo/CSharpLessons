using System;

namespace CSharpLesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Классы
            Console.WriteLine("## Классы");
            
            // Создание объекта класса DemoClass
            DemoClass demo = new DemoClass();
            // Вызов метода Method объекта demo
            demo.Method();

            Console.WriteLine();

            // ## Инициализация объектов класса
            Console.WriteLine("## Инициализация объектов класса");
           
            DemoClass d2 = new DemoClass(1);
            d2.Method(); // field: 1, Property: 0
            DemoClass d3 = new DemoClass(1, 2);
            d3.Method(); // field: 1, Property: 2

            var d4 = new DemoClass();

            var d5 = new DemoClass(10) { Property = 11 };
            d5.Method(); // field: 10, Property: 11

            Console.WriteLine();

            // ## Методы
            // ### Работа с модификатором доступа
            Console.WriteLine("## Методы");
            Console.WriteLine("### Работа с модификатором доступа");
           
            var d6 = new DemoClass(11) { Property = 12 };
            d6.Printer(); // field: 11, Property: 12

            var d7 = new DemoClass();
            //d7.PrivateMethod(); // Ошибка компиляции!!!

            Console.WriteLine();

            // ### Статические методы и методы объекта
            Console.WriteLine("### Статические методы и методы объекта");
            
            DemoClass.StaticMethod(); // Message from static method
            var d8 = new DemoClass();
            d8.NoneStaticMethod(); // Message from none static method

            Console.WriteLine();

            // ### Методы принимающие аргументы и возвращающие значения
            Console.WriteLine("### Методы принимающие аргументы и возвращающие значения");
            
            var d9 = new DemoClass(10);
            Console.WriteLine($"MulField() result: {d9.MulField(2)}"); // MulField() result: 20

            Console.WriteLine();

            // ## Поля
            Console.WriteLine("## Поля");
            var d10 = new DemoClass();
            // Доступ к private полям запрещен
            // Console.WriteLine($"Get private field: {d10.field}"); // Compile ERROR           
            // Доступ к полю объекта
            d10.publicField = 123;
            Console.WriteLine($"Get public field: {d10.publicField}"); // Get public field: 123
                                                                       // Доступ к статическому полю класса
            DemoClass.publicStaticField = 456;
            Console.WriteLine($"Get public static field: {DemoClass.publicStaticField}"); // Get public static field: 456
            
            var b1 = new Building();
            b1.SetHeight(12);
            Console.WriteLine($"Height of building: {b1.GetHeight()}");

            Console.WriteLine();

            // ## Свойства
            Console.WriteLine("## Свойства");
            var b2 = new Building();
            b2.Height = 456;
            Console.WriteLine($"Height of building: {b2.Height}"); // Height of building: 456
        }
    }

    class Building
    {
        float height;

        public float GetHeight() => height;

        public float SetHeight(float height) => this.height = height;

        public float Height
        {
            get => height;
            set => height = value;
        }

        public float Width { get; set; }
        public float Length { get; set; }
    }

    class DemoClass
    {
        // Поле класса
        int field = 0;
        public int publicField = 0;
        public static int publicStaticField = 0;

        // Свойство класса
        public int Property { get; set; }

        // Конструкторы класса
        public DemoClass()
        { }

        public DemoClass(int field)
        {
            this.field = field;
        }

        public DemoClass(int field, int prop)
        {
            this.field = field;
            Property = prop;
        }

        // Методы класса
        public void Method()
        {
            Console.WriteLine("Method");
        }

        public void Printer()
        {
            Console.WriteLine($"field: {field}, Property: {Property}");
        }

        private void PrivateMethod()
        {
            Console.WriteLine($"Secret method");
        }

        public void PublicMethod()
        {
            Console.WriteLine($"Public method");
            PrivateMethod();
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Message from static method");
        }

        public void NoneStaticMethod()
        {
            Console.WriteLine("Message from non static method");
        }

        public int MulField(int value)
        {
            return field * value;
        }
    }
}
