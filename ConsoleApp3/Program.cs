using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass("Base");
            baseClass.MethFromBC("Оля", "Луценко");
            Console.Write("\n");
            InhClass inhClass = new InhClass("Наслідування", "Привіт всім.");
            inhClass.MethodInh();
            inhClass.InfoProp();
            Console.ReadKey();
        }
    }

    class BaseClass
    {
        public string TypeOfClass { get; set; }
        public BaseClass(string typeofcl)
        {
            this.TypeOfClass = typeofcl;
        }
        public void MethFromBC(string name, string surname)
        {
            Console.WriteLine($"Name - {name}, Surname - {surname}");
            Console.WriteLine($"Тип класа - {TypeOfClass}");
        }
    }
    class InhClass : BaseClass
    {
        public string Line { get; set; }
        public InhClass(string typeofcl, string line)
            : base(typeofcl)
        {
            this.Line = line;
        }
        public void MethodInh()
        {
            Console.WriteLine($"Тип класа - {TypeOfClass}");
            Console.WriteLine(Line);
        }

        public void InfoProp()
        {
            Type type = typeof(BaseClass);
            PropertyInfo[] propertyInfos = type.GetProperties();
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Property {propertyInfo.Name}, Type - {propertyInfo.PropertyType}");
            }
        }

    }
}
