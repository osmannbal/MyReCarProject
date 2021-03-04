using Business.Concrete;
using Business.Constants;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //var result5 = rentalManager.Add(new Rental
            //{ CarId = 4, CustomerId = 4, RentalId = 4, RentDate = new DateTime(2021, 02, 15), ReturnDate = null }) ;
            //Console.WriteLine(result5.Message);

            //var result6 = rentalManager.Update(new Rental { RentalId=3, CarId=1, CustomerId=3, RentDate = new DateTime(2021, 02, 16), ReturnDate = new DateTime(2021, 02, 17) });
            //Console.WriteLine(result6.Message);

            //var result7 = rentalManager.GetAll();
            //foreach (var rental in rentalManager.GetAll().Data)
            //{
            //    Console.WriteLine("{0} / {1} / {2} / {3} / {4}", rental.RentalId, rental.CarId, rental.CustomerId, rental.RentDate, rental.ReturnDate);
            //}
            //Console.WriteLine(result7.Message);    
            

            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //var result8 = customerManager.Add(new Customer { UserId = 4, CustomerId = 9, CompanyName = "C7" });
            //Console.WriteLine(result8.Message);

            //var result9 = customerManager.Update(new Customer { CustomerId = 2, UserId = 2, CompanyName = "Tunç" });
            //Console.WriteLine(result9.Message);

            //var result12 = customerManager.GetAll();
            //foreach (var customer in customerManager.GetAll().Data)
            //{
            //    Console.WriteLine("{0} / {1} / {2}", customer.UserId, customer.CustomerId, customer.CompanyName);
            //}
            //Console.WriteLine(result12.Message);

            //UserManager userManager = new UserManager(new EfUserDal());
            //var result10 = userManager.Add(new User { UserId = 6, FirstName = "Henry", LastName = "Onyekuru", Email = "henry@gmail.com", PasswordHash = "hdmnd6521d", });
            //Console.WriteLine(result10.Message);

            //var result11 = userManager.Update(new User { UserId = 4, FirstName = "Nando", LastName = "Muslera", Email = "nando@gmail.com", PasswordHash = "nfls55sals8", });
            //Console.WriteLine(result11.Message);

            //var result13 = userManager.GetAll();
            //foreach (var user in userManager.GetAll().Data)
            //{
            //    Console.WriteLine("{0} / {1} / {2} / {3} / {4}", user.UserId, user.FirstName, user.LastName, user.Email, user.PasswordHash);
            //}
            //Console.WriteLine(result13.Message);

            //CarManager carManager = new CarManager(new EfCarDal());
            //var result = carManager.GetAll();
            //if (result.Success == true)
            //{
            //    foreach (var car in carManager.GetAll().Data)
            //    {
            //        if (car.CarName.Length > 1)
            //        {
            //            if (car.DailyPrice > 0)
            //            {
            //                Console.WriteLine("Araba Id : " + car.CarId +
            //                " / Araba adı : " + car.CarName +
            //                " / Günlük fiyatı :  " + car.DailyPrice +
            //                " / Model Yılı : " + car.ModelYear +
            //                " / Özellikler : " + car.Description
            //                );
            //            }
            //            else
            //            {
            //                Console.WriteLine(Messages.CarDailyPriceInvalid);
            //            }

            //        }
            //        else
            //        {
            //            Console.WriteLine(Messages.CarNameInvalid);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}






            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //var result2 = brandManager.GetAll();
            //if (result2.Success == true)
            //{
            //    foreach (var brand in brandManager.GetAll().Data)
            //    {
            //        Console.WriteLine("Marka Id : " + brand.BrandId + " / Marka : " + brand.BrandName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result2.Message);
            //}




            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //var result3 = colorManager.GetAll();
            //if (result3.Success == true)
            //{
            //    foreach (var color in colorManager.GetAll().Data)
            //    {
            //        Console.WriteLine("Renk Id : " + color.ColorId + " / Renk : " + color.ColorName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result3.Message);
            //}



            //var result4 = carManager.GetCarDetailDtos();
            //if (result4.Success == true)
            //{
            //    foreach (var car in carManager.GetCarDetailDtos().Data)
            //    {
            //        Console.WriteLine("{0} / {1} / {2} / {3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result4.Message);
            //}

        }
    }
}
