using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in carManager.GetAll().Data)
                {
                    if (car.CarName.Length > 1)
                    {
                        if (car.DailyPrice > 0)
                        {
                            Console.WriteLine("Araba Id : " + car.CarId +
                            " / Araba adı : " + car.CarName +
                            " / Günlük fiyatı :  " + car.DailyPrice +
                            " / Model Yılı : " + car.ModelYear +
                            " / Özellikler : " + car.Description
                            );
                        }
                        else
                        {
                            Console.WriteLine(Messages.CarDailyPriceInvalid);
                        }

                    }
                    else
                    {
                        Console.WriteLine(Messages.CarNameInvalid);
                    }
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }




           
            
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result2 = brandManager.GetAll();
            if (result2.Success==true)
            {
                foreach (var brand in brandManager.GetAll().Data)
                {
                    Console.WriteLine("Marka Id : " + brand.BrandId + " / Marka : " + brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result2.Message);
            }
            

            

            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result3 = colorManager.GetAll();
            if (result3.Success==true)
            {
                foreach (var color in colorManager.GetAll().Data)
                {
                    Console.WriteLine("Renk Id : " + color.ColorId + " / Renk : " + color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result3.Message);
            }



            var result4 = carManager.GetCarDetailDtos();
            if (result4.Success==true)
            {
                foreach (var car in carManager.GetCarDetailDtos().Data)
                {
                    Console.WriteLine("{0} / {1} / {2} / {3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result4.Message);
            }
            
        }
    }
}
