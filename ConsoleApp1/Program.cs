using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationLicense applicationLicense = new ApplicationLicense();
            Console.WriteLine("Введіть ключ доступу: ");
            try
            {
                applicationLicense.Key = Convert.ToInt32(Console.ReadLine());
                if (applicationLicense.Key == 1)
                {
                    Trial trial = new Trial();
                    trial.AllowTrial();
                }
                else if (applicationLicense.Key == 2)
                {
                    Pro pro = new Pro();
                    pro.AllowPro();
                }
                else if (applicationLicense.Key == 3)
                {
                    Free free = new Free();
                    free.AllowCommon();
                }
                else
                {
                    Console.WriteLine("Ключ не підходить!");
                    Free free = new Free();
                    free.AllowCommon();
                }
            }
            catch
            {
                Console.WriteLine("Не правильне значення");
            }

            Console.ReadKey();
        }
    }
    class ApplicationLicense
    {
        public int Key { get; set; }
        
        public virtual void AllowTrial()
        {
            Console.WriteLine("Триальний режим!");
        }
        public virtual void AllowPro()
        {
            Console.WriteLine("Платна версія!");
        }
        public virtual void AllowCommon()
        {
            Console.WriteLine("Безкоштовна версія!");
        }

    }
    class Trial : ApplicationLicense  
    {
        public override void AllowTrial()
        {
            base.AllowTrial(); 
            Console.WriteLine("Користування пробною версією 2 тижні!");
        }
    }
    class Pro : ApplicationLicense 
    {
        public override void AllowPro()
        {
            base.AllowPro();
            Console.WriteLine("Всі функції ввімкнені! У вас про-версія");
        }
    }
    class Free : ApplicationLicense  
    {
        public override void AllowCommon()
        {
            base.AllowCommon();
            Console.WriteLine("У вас обмежена версія!!! Купіть про-версію!");
        }
    }
}
