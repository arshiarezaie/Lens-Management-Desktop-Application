using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;
using UnitOfWork;
using Lens_Management.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using User = DataLayer.Model.User;

namespace Lens_Management.Classes
{
    public static class Authorize
    {
        private static User _user;
        public static User user
        {
            get { return _user; }
        }

        public static bool Login(string userName, string passWord)
        {
            bool result = default(bool);
            using (UnitOfWorkDB db = new UnitOfWorkDB())
            {
                userName = userName.ToLower().Trim();
                passWord = Cryptography.ToMD5(passWord);
                _user = db.UserRepository.Get(u => u.Username == userName && u.Password == passWord).SingleOrDefault();
                if (_user != null)
                    result = true;
                else
                    result = false;
            }
            return result;
        }


        public static void LogOut()
        {
            _user = null;
        }

        public static bool Register(User user)
        {
            bool result = default(bool);
            using (UnitOfWorkDB db = new UnitOfWorkDB())
            {
                user.Username = user.Username.ToLower().Trim();
                if (db.UserRepository.Get(u => u.Username == user.Username).Any())
                {
                    result = false;
                    return result;
                }
                user.Password = Cryptography.ToMD5(user.Password);
                user.Hint = Cryptography.ToMD5(user.Hint);
                db.UserRepository.Insert(user);
                result = db.Save();

            }
            return result;
        }

        public static bool ForgetPasssword(string userName, string hint, string newPassword)
        {
            bool result = default(bool);
            hint = Cryptography.ToMD5(hint);
            using (UnitOfWorkDB db = new UnitOfWorkDB())
            {
                userName = userName.ToLower().Trim();
                User user = db.UserRepository.Get(u => u.Username == userName
                && u.Hint == hint).FirstOrDefault();
                if (user != null)
                {
                    user.Password = Cryptography.ToMD5(newPassword);
                    db.UserRepository.Update(user);
                    result = db.Save();
                }
                else
                    result = false;
            }

            return result;
        }


        public static bool ChangePassword(string currentPassword, string newPassword)
        {
            bool result = default(bool);

            if (_user.Password != Cryptography.ToMD5(currentPassword))
            {
                result = false;
                return result;
            }

            using (UnitOfWorkDB db = new UnitOfWorkDB())
            {
                _user.Password = Cryptography.ToMD5(newPassword);
                db.UserRepository.Update(_user);
                result = db.Save();
            }

            return result;
        }

    }
}
