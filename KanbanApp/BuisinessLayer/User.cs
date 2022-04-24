using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanApp.BuisinessLayer
{
    internal class User
    {
        //private readonly JsonController dalController;

        public string Email { get; set; }
        public string Password { get; set; }

        public User() { }

        public User(string email, string password)
        {
           // dalController = new JsonController();
            Password = password;
            Email = email;
            this.Persist();//save to file
        }

        private void Persist()
        {
           // dalController.Write(Email, this);
        }

        public static User Load(string email)
        {
            return null;
          //return new JsonController().Load<User>(typeof(User), email);
        }

    }
}
