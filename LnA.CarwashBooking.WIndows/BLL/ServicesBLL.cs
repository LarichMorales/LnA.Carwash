using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LnA.CarwashBooking.WIndows.DAL;
using LnA.CarwashBooking.WIndows.BLL;
using LnA.CarwashBooking.WIndows.Helpers;
using LnA.CarwashBooking.WIndows.Models;


namespace LnA.CarwashBooking.WIndows.BLL
{
    public static class ServicesBLL
    {
        private static CarwashDBContext db = new CarwashDBContext();

        public static Paged<Service> Search(int pageIndex = 1, int pageSize = 1, string sortBy = "lastname", string sortOrder = "asc")
        {
            IQueryable<Service> allServices = db.Services;
            Paged<Service> services = new Paged<Service>();

 
            var queryCount = allServices.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)(Math.Ceiling((decimal)(queryCount / pageSize)));


                    services.Items = allServices.OrderBy(e => e.Price).Skip(skip).Take(pageSize).ToList();


            services.PageCount = pageCount;
            services.PageCount = pageIndex;
            services.PageSize = pageSize;
            services.QueryCount = queryCount;
            
            return services;
        }
    }
}
