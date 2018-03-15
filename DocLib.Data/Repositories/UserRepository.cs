using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DocLib.Domain.Interface.Repositories;
using DocLib.Models;
using DocLib.Data.Entities;
using DocLib.Models.Models;

namespace DocLib.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DataEntities _context;
        public UserRepository(DataEntities context)
        {
            _context = context;
        }

        public void AddRole(int userId, int roleId)
        {
            var user = _context.Users.Find(userId);
            if (user == null)
            {
                throw new Exception("User Not Found");
            }
            var role = _context.Roles.Find(roleId);
            user.Role = role;
            _context.SaveChanges();
        }

        public UserModel Create(UserModel model)
        {
            if (model != null)
            {
                var user = new User
                {
                    FirstName = model.Firstname,
                    LastName = model.LastName,
                    Email = model.Email,
                };
            }
            return model;
        }

        public ICollection<CategoryModel> GetCategories()
        {
            var query = from category in _context.Categories
                        orderby category.CategoryName
                        select new CategoryModel
                        {
                            Categoryid = category.Categoryid,
                            CategoryName = category.CategoryName
                        };
            return query.ToArray();
        }

        public UserModel GetUserByEmail(string email)
        {
            var query = from user in _context.Users
                        where user.Email == email
                        select new
                        {
                            user,
                            role = user.Role.Name

                        };

            var record = query.FirstOrDefault();
            if (record != null)
            {
                var transform = new UserModel
                {
                    Userid = record.user.Userid,
                    Firstname = record.user.FirstName,
                    LastName = record.user.LastName,
                    Email = record.user.Email,
                    Role = record.role
                };
                return transform;
            }
            return null;
        }

        public UserModel GetUserById(int userId)
        {
            var query = from user in _context.Users
                        where user.Userid == userId
                        select new
                        {
                            user,
                            role = user.Role.Name
                        };
            var record = query.FirstOrDefault();

            if (record != null)
            {
                var transform = new UserModel
                {
                    Userid = record.user.Userid,
                    Firstname = record.user.FirstName,
                    LastName = record.user.LastName,
                    Email = record.user.Email,
                    Role = record.role
                };
                return transform;
            }
            return null;
        }

        public void SetPasswordHash(int userId, string passwordHash)
        {
            var user = _context.Users.Find(userId);
            if (user == null)
                throw new Exception("User Not Found");
            user.Password = passwordHash;
            _context.SaveChanges();
        }

        public UserModel ValidateUser(string email, string password)
        {
            var query = from user in _context.Users
                        where user.Email == email
                        where user.Password == password
                        select new
                        {
                            user,
                            role = user.Role.Name
                        };
            var record = query.FirstOrDefault();
            if (record != null)
            {
                return new UserModel
                {
                    Userid = record.user.Userid,
                    Email = record.user.Email,
                    Firstname = record.user.FirstName,
                    LastName = record.user.LastName,
                    Role = record.role
                };
            }
            return null;
        }
    }
}
