using RBAProject.DTOs;
using RBAProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace RBAProject.DataAccess
{
    public class EfCarDAL
    {

        public List<CarDetailDTO> GetCarDetails()
        {
            using (ModelContext context = new ModelContext())
            {
                var result = from cr in context.Cars
                             join cl in context.Colors
                             on cr.Colorid equals cl.Id
                             join b in context.Brands
                             on cr.Brandid equals b.Id
         

                             select new CarDetailDTO
                             {

                                 BrandName = b.Brandname,
                                 ColorName = cl.Colorname
                             };

                return result.ToList();


            }

        }
    }
}
