using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dog1 = new Dogs("Біл", 2, "чорний");
            dog1.MethodDogs();
            Dogs dog2 = new Dogs("Лін", 4, "білий");
            dog2.MethodDogs();
            Cats cat1 = new Cats("Карл", 10, "блакитний");
            cat1.MethodCats();
            Cats cat2 = new Cats("Оскар", 22, "зелений");
            cat2.MethodCats();
            Fishs fish1 = new Fishs("Кол", 1, "Філ");
            fish1.MethodFishs();
            Fishs fish2 = new Fishs("Доббі", 2, "Кара");
            fish2.MethodFishs();
            Console.Write("\n");
            PropInfo();
            Console.ReadKey();


        }
        public static void PropInfo()
        {
            Console.WriteLine("Інформація про всі властивості класу Animals: ");
            Animals animals = new Animals();
            Type mytype = animals.GetType();
            PropertyInfo[] propertyInfos = mytype.GetProperties();
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                
                Console.WriteLine($"Property {propertyInfo.Name}, Type - {propertyInfo.PropertyType}");
            }
        }
        class Animals
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string TailColour { get; set; }
            public string EyCol { get; set; }
            public string OwnerName { get; set; }

        }
        class Dogs : Animals
        {
            public Dogs(string name, int age, string tcol)
            {
                this.Name = name;
                this.Age = age;
                this.TailColour = tcol;
            }
            public void MethodDogs()
            {
                Console.WriteLine($"Ім'я - {Name}, Вік - {Age}, Колір шерсті - {TailColour}");
            }
        }
        class Cats : Animals
        {
            public Cats(string name, int age, string ecol)
            {
                this.Name = name;
                this.Age = age;
                this.EyCol = ecol;
            }
            public void MethodCats()
            {
                Console.WriteLine($"Ім'я - {Name}, Вік - {Age}, Колір глаз - {EyCol}");
            }
        }
        class Fishs : Animals
        {
            public Fishs(string name, int age, string owname)
            {
                this.Name = name;
                this.Age = age;
                this.OwnerName = owname;
            }
            public void MethodFishs()
            {
                Console.WriteLine($"Ім'я - {Name}, Вік - {Age}, Ім'я власника - {OwnerName}");
            }
        }
    }
}
