using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // BrandTest();
            // CarTest();
            UserTest();
            Console.WriteLine("--------------------------------------------------------");

            Console.Read();


        }
        public static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { Email = "deneme1", FirstName = "deneme1", LastName = "deneme1", Id = 1, Password = 123 });
            userManager.Add(new User { Email = "deneme2", FirstName = "deneme2", LastName = "deneme2", Id = 2, Password = 321 });
            foreach (var item in userManager.GetAll().Data)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine();
        }
        public static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandId = 1, BrandName = "Ford" });
            foreach (var item in brandManager.GetAll().Data)
            {
                Console.WriteLine(item.BrandName);
            }
        }
        public static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { BrandId = 1, CarName = "Kırmızı", ColorId = 1, Description = "Kırmızı Araba", Id = 1, ModelYear = 1990, Price = 20 });

            carManager.Add(new Car { BrandId = 2, CarName = "Mor", ColorId = 2, Description = "Mor Araba", Id = 2, ModelYear = 2000, Price = 4 });

            foreach (var item in carManager.GetAll().Data)
            {
                Console.WriteLine(item.Description);
            }
            //  carManager.Update(new Car { BrandId = 2, CarName = "Sarı", ColorId = 2, Description = "Sarı Araba", Id = 2, ModelYear = 2001, Price = 2 });
            Console.WriteLine("//////////////////////////////////////////////////");
            //Console.WriteLine(carManager.GetById(2).Data.CarName);

        }


    }
}
