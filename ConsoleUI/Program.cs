using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                if (car.Description.Length > 1)
                {
                    if (car.DailyPrice > 0)
                    {
                        Console.WriteLine("Araba Id : " + car.CarId +
                            " Araba adı : " + car.Description +
                            " Günlük fiyatı :  " + car.DailyPrice +
                            " Model Yılı : " + car.ModelYear
                            );
                    }
                    else
                    {
                        Console.WriteLine("Araba günlük fiyatı 0'dan büyük olmalıdır.");
                    }

                }
                else
                {
                    Console.WriteLine("Araba ismi en az 2 harf olmalıdır.");
                }



            }

            foreach (var car in carManager.GetAllByCarId(1))
            {
                Console.WriteLine("Araba Id : " + car.CarId +
                            " Araba adı : " + car.Description +
                            " Günlük fiyatı :  " + car.DailyPrice +
                            " Model Yılı : " + car.ModelYear);
            }

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("Marka Id : " + brand.BrandId + " Marka : " +  brand.BrandName);
            }

            foreach (var brand in brandManager.GetCarsByBrandId(1))
            {
                Console.WriteLine("Marka Id : " + brand.BrandId + " Marka : " + brand.BrandName);
            }

            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("Renk Id : " + color.ColorId + " Renk : " + color.ColorName);
            }

            foreach (var color in colorManager.GetCarsByColorId(2))
            {
                Console.WriteLine("Renk Id : " + color.ColorId + " Renk : " + color.ColorName);
            }

            foreach (var car in carManager.GetCarDetailDtos())
            {
                Console.WriteLine("{0} / {1} / {2} / {3}" , car.CarName , car.BrandName , car.ColorName , car.DailyPrice);
            }
        }
    }
}
