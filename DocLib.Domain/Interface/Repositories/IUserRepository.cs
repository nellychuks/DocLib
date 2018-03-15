using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocLib.Models;
using DocLib.Models.Models;

namespace DocLib.Domain.Interface.Repositories
{
    public interface IUserRepository
    {
        UserModel ValidateUser(string email, string password);
        UserModel GetUserById(int userId);
        UserModel GetUserByEmail(string email);
        UserModel Create(UserModel model);
        void SetPasswordHash(int userId, string passwordHash);
        void AddRole(int userId, int roleId);

        ICollection<CategoryModel> GetCategories();
        
    }
}
