using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());


            //TestGetCarById(carManager, 1); //Test getting a car by ID.

            //TestAddCar(carManager); //Test adding a car into DB.
            //TestDeleteCar(carManager); //Test deleting a car from DB.
            //TestUpdateCar(carManager); //Test updating a car in DB.

            //TestGetAllColors(colorManager); // Test getting all colors in DB.

            //TestAddCustomer(customerManager); //Test adding a customer into DB.
            //TestAddRental(rentalManager); //Test adding a rental into DB.
        }


        private static void TestGetCarById(CarManager carManager, int carId)
        {
            var result = carManager.GetById(carId);

            if (result.Success)
            {
                Console.WriteLine(result.Data.Id + "-" + result.Data.Name + "-" + result.Data.DailyPrice + "-" + result.Data.Description);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }


        private static void TestAddCar(CarManager carManager)
        {
            var result = carManager.Add(new Car { BrandId = 5, ColorId = 1, Name = "Renault Megane", ModelYear = "2021", DailyPrice = 150, Description = "Renault Megane, Diesel, Automatic Transmission" });
            Console.WriteLine(result.Message);
        }

        private static void TestDeleteCar(CarManager carManager)
        {
            var result = carManager.Delete(new Car { Id = 1004 });
            Console.WriteLine(result.Message);
        }

        private static void TestUpdateCar(CarManager carManager)
        {
            var result = carManager.Update(new Car { Id = 11, BrandId = 5, ColorId = 2, Name = "Renault Symbol", ModelYear = "2016", DailyPrice = 100, Description = "Renault Symbol, Diesel, Manual Transmission" });
            Console.WriteLine(result.Message);
        }

        private static void TestGetAllColors(ColorManager colorManager)
        {
            var result = colorManager.GetAll();

            foreach (var color in result.Data)
            {
                Console.WriteLine(color.ColorId + "-" + color.ColorName);
            }
        }





        public static void TestAddCustomer(CustomerManager customerManager)
        {
            var Result = customerManager.Add(new Customer { UserId = 1, CompanyName = "Siemens" });
            Console.WriteLine(Result.Message);
        }

        public static void TestAddRental(RentalManager rentalManager)
        {
            //var Result = rentalManager.GetByRentalId(5);
            var Result = rentalManager.Add(new Rental { CarId = 1, CustomerId = 4, RentDate = new DateTime(2021, 1, 20, 10, 30, 00), ReturnDate = new DateTime(2021, 2, 1, 15, 00, 00) });
            Console.WriteLine(Result.Message);
        }


    }
}

