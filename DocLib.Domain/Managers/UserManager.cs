using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocLib.Domain.Interface.Repositories;
using DocLib.Domain.Interface.Utilities;
using DocLib.Models;

namespace DocLib.Domain.Managers
{
  public  class UserManager
    {
        private IUserRepository _userRepository;
        private IEncryption _encryption;

        public UserManger(IUserRepository userRepository, IEncryption encryption)
        {
            _userRepository = userRepository;
            _encryption = encryption;
        }
        
        public UserModel SignUpUser (UserModel model, string password)
        {
            model.Validate();

            var user = _userRepository.GetUserByEmail(model.Email);
            if (user != null)
            {
                throw new Exception($"This email ({user.Email}) has been used");
            }

            user = _userRepository.Create(model);

            var passwordHash = _encryption.Encrypt(password);

            _userRepository.SetPasswordHash(user.Userid, passwordHash);
            return model;
        }

        public UserModel GetUser(string email)
        {
            return _userRepository.GetUserByEmail(email);
        }

        public UserModel SignIn(string email, string password)
        {
            var passwordHash = _encryption.Encrypt(password);
            return _userRepository.ValidateUser(email, passwordHash);
        }

        public UserModel GetUserById(int userId)
        {
            return _userRepository.GetUserById(userId);
        }
    }
}
