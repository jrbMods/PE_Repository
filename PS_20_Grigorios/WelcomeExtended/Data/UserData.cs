using System;
using System.Collections.Generic;
using System.Linq;
using Welcome.Model;
using Welcome.Others;
using WelcomeExtended;

namespace WelcomeExtended.Data
{
    public class UserData
    {
        private List<User> _users;
        private int _nextId;

        public UserData()
        {
            _users = new List<User>();
            _nextId = 0;
        }

        public void AddUser(User user)
        {
            user.Id = _nextId++;
            _users.Add(user);
        }

        public void DeleteUser(User user)
        {
            _users.Remove(user);
        }

        public bool ValidateUser(string name, string password)
        {
            foreach (var user in _users)
            {
                if (user.Names == name && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidateUserLambda(string name, string password)
        {
            return _users.Any(x => x.Names == name && x.Password == password);
        }

        public bool ValidateUserLinq(string name, string password)
        {
            var ret = (from user in _users
                       where user.Names == name && user.Password == password
                       select user.Id).FirstOrDefault();

            return ret != 0;
        }

        public User GetUser(string name, string password)
        {
            var user = _users.FirstOrDefault(x => x.Names == name && x.Password == password);

            if (user == null)
            {
                throw new InvalidOperationException("User not found");
            }

            return user;
        }


        public void SetActive(string name, DateTime validDate)
        {
            var user = _users.FirstOrDefault(x => x.Names == name);
            if (user != null)
            {
                user.Expires = validDate;
            }
        }

        public void AssignUserRole(string name, UserRolesEnum.UserRole role)
        {
            var user = _users.FirstOrDefault(x => x.Names == name);
            if (user != null)
            {
                user.Role = role;
            }
        }
    }
}