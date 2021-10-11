using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            A aclass = new A();
            aclass.Method();
            Console.Write("\n");
            PropInfo();
            Console.ReadKey();
        }
        public static void PropInfo()
        {
            Type type = typeof(FirstClass);
            PropertyInfo[] propertyInfos = type.GetProperties(); 
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {

                Console.WriteLine($"Property {propertyInfo.Name}, Type - {propertyInfo.PropertyType}");
            }
            Type type2 = typeof(SecondClass);
            PropertyInfo[] propertyInfos2 = type2.GetProperties(); 
            foreach (PropertyInfo propertyInfo in propertyInfos2)
            {

                Console.WriteLine($"Property {propertyInfo.Name}, Type - {propertyInfo.PropertyType}");
            }
            Type type3 = typeof(ThirdClass);
            PropertyInfo[] propertyInfos3 = type3.GetProperties(); 
            foreach (PropertyInfo propertyInfo in propertyInfos3)
            {

                Console.WriteLine($"Property {propertyInfo.Name}, Type - {propertyInfo.PropertyType}");
            }
        }
    }
    class B 
    {
        public virtual void Class1()
        {
            Console.WriteLine("Метод для 1 класса");
        }
        public virtual void Class2()
        {
            Console.WriteLine("Метод для 2 класса");
        }
        public virtual void Class3()
        {
            Console.WriteLine("Метод для 3 класса");
        }

    }
    class FirstClass : B
    {
        public string ClassName1 { get; set; }
        public override void Class1()
        {
            base.Class1();
            ClassName1 = "Class1";
            Console.WriteLine($"Вітаю вас в Одесі!! {ClassName1}");
        }
    }
    class SecondClass : B
    {
        public string ClassName2 { get; set; }
        public override void Class2()
        {
            base.Class2();
            ClassName2 = "Class2";
            Console.WriteLine($"Вітаю вас в Одесі!! {ClassName2}");
        }
    }
    class ThirdClass : B
    {
        public string ClassName3 { get; set; }
        public override void Class3()
        {
            base.Class3();
            ClassName3 = "Class3";
            Console.WriteLine($"Вітаю вас в Одесі!! {ClassName3}");
        }
    }
    class A
    {
        public void Method()
        {
            FirstClass firstClass = new FirstClass();
            firstClass.Class1();
            SecondClass secondClass = new SecondClass();
            secondClass.Class2();
            ThirdClass thirdClass = new ThirdClass();
            thirdClass.Class3();
        }
    }


}
