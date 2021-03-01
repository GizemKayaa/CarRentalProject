using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, CarDatabaseContext>, ICarImageDal
    {
       // public List<CarImageDetailDto> GetCarImageDetails()
      //  {
            //using (CarDatabaseContext context = new CarDatabaseContext())
            //{
            //    var result = from ci in context.CarImages
            //                 join c in context.Cars
            //                 on ci.CarId equals c.Id
            //                 join b in context.Brands
            //                 on c.BrandId equals b.BrandId
            //                 join cl in context.Colors
            //                 on c.ColorId equals cl.ColorId

            //                 select new CarImageDetailDto
            //                 {
            //                     Id = ci.Id,
            //                     BrandName = b.BrandName,
            //                     ColorName = cl.ColorName,
            //                     Date = (DateTime)ci.Date,
            //                     DailyPrice = c.DailyPrice,
            //                     ImagePath = ci.ImagePath,
            //                     ModelYear = c.ModelYear

            //                 };


            //    return result.ToList();

            //}
        //}
    }
}
