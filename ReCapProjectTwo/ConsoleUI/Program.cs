using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            Console.ReadLine();
        }
        public static void CarTest()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach(var item in result.Data)
                {
                    Console.WriteLine(item.CarName);
                }
            }
        }
    }
}
