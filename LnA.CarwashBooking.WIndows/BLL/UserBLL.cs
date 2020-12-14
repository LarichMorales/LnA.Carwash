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
    public static class UserBLL
    {
        private static CarwashDBContext db = new CarwashDBContext();

        public static Paged<User> Search(int pageIndex = 1, int pageSize = 1, string sortBy = "lastname", string sortOrder = "asc",string keyword = "")
        {
            IQueryable<User> allUsers = db.Users;
            Paged<User> users = new Paged<User>();

            if (!string.IsNullOrEmpty(keyword))
            {
                allUsers = allUsers.Where(e => e.FirstName.Contains(keyword) || e.LastName.Contains(keyword));
            }
            var queryCount = allUsers.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)(Math.Ceiling((decimal)(queryCount / pageSize)));
            if (sortBy.ToLower() == "last name" && sortOrder.ToLower() == "asc")
            {
                users.Items = allUsers.OrderBy(e => e.LastName).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "last name" && sortOrder.ToLower() == "desc")
            {
                users.Items = allUsers.OrderByDescending(e => e.LastName).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "first name" && sortOrder.ToLower() =="desc")
            {
                users.Items = allUsers.OrderByDescending(e => e.FirstName).Skip(skip).Take(pageSize).ToList();
            }
            else
            {
                users.Items = allUsers.OrderBy(e => e.FirstName).Skip(skip).Take(pageSize).ToList();
            }

            users.PageCount = pageCount;
            users.PageCount = pageIndex;
            users.PageSize = pageSize;
            users.QueryCount = queryCount;

            return users;
        }

        public static Operation Add(User user)
        {
            try
            {
                db.Users.Add(user);
                    db.SaveChanges();

                return new Operation()
                {
                    Code = "200",
                    Message = "Ok",
                    ReferenceId = user.UserId
                };
            }
            catch(Exception e)
            {
                return new Operation()
                {
                    Code = "500",
                    Message = e.Message
                };
            }
        }

        public static User GetbyId(Guid? id)
        { 
            return db.Users.FirstOrDefault(u => u.UserId == id); 
        }

        public static Operation Login(string emailAddress = "", string password = "")
        {
            if (string.IsNullOrEmpty(emailAddress))
            {
                return new Operation()
                {
                    Code = "500",
                    Message = "Invalid Login"
                };
            }

            if (string.IsNullOrEmpty(password))
            {
                return new Operation()
                {
                    Code = "500",
                    Message = "Invalid Login"
                };
            }

            try
            {
                User user = db.Users.FirstOrDefault(e => e.Email.ToLower() == emailAddress.ToLower());

                if (user == null)
                {
                    return new Operation()
                    {
                        Code = "500",
                        Message = "Invalid Login"
                    };
                }

                if (password == user.Password)
                {
                    return new Operation()
                    {
                        Code = "200",
                        Message = "Successful Login",
                        ReferenceId = user.UserId
                    };
                }

                return new Operation()
                {
                    Code = "500",
                    Message = "Invalid Login"
                };
            }
            catch (Exception e)
            {
                return new Operation()
                {
                    Code = "500",
                    Message = e.Message
                };
            }
        }

    }
}

