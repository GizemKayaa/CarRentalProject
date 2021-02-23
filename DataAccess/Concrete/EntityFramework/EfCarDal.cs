using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var result = from car in context.Cars
                             join c in context.Colors
                             on car.ColorId equals c.ColorId
                             join b in context.Brands
                             on car.BrandId equals b.BrandId
                             
                             select new CarDetailDto { CarName = car.Name, ColorName = c.ColorName, DailyPrice = car.DailyPrice, BrandName = b.BrandName };
                return result.ToList();
            }
        }
    }
}
