using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanApp.BuisinessLayer
{
    internal class UserController
    {
        private readonly Dictionary<string, User> users = new Dictionary<string, User>();
        public UserController() { }

        internal void CreateUser(string email, string password)
        {
            if (email is null)
            {
                //log.Debug("User with null email attempted register");       ********
                throw new Exception($"Email is null");
            }
            if (users.ContainsKey(email))
            {
                throw new Exception($"Email {email} already exists");
            }
            User u = new User(email, password);
            users[email] = u; //ading to dictionary of existing users
        }

        internal void LoadAllUsers()
        {
            //List<DataAccessLayer.User> users = dalController.LoadAllUsers();
           // foreach (var user in users)
            //{
              //  User u = new User(user.Email, user.Password);
                //users[u.Email] = u;
            //}
        }
        public void DeleteUser(String email) { }
        public void getUser(String email) { } // type User?
        public void UpdateUser(String email, String password) { }


    }
}
