using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanApp.BuisinessLayer
{
    internal class TaskController
    {
        private readonly Dictionary<int, Task> tasks = new Dictionary<int, Task>();
        public TaskController() { }

        internal void CreateTAsk(string CreationTime, string dueDate, string title, int key, string description)
        {
            if (title is null)
            {
                //log.Debug("User with null email attempted register");       ********
                throw new Exception($"Title is null");
            }
            if (dueDate is null)
            {
                //log.Debug("User with null email attempted register");       ********
                throw new Exception($"Due date is null");
            }
            if (tasks.ContainsKey(key))
            {
                throw new Exception($"Title {title} already exists");
            }
            Task t = new Task(title, description);
            tasks[key] = t; //ading to dictionary of existing users
        }

        internal void LoadAllTasks()
        {
            //List<DataAccessLayer.User> users = dalController.LoadAllUsers();
            // foreach (var user in users)
            //{
            //  User u = new User(user.Email, user.Password);
            //users[u.Email] = u;
            //}
        }
        public void DeleteTask(int key) { }
        public void GetTask(int key) { } // type User?
        public void UpdateTask(int key, string title, string description) { }


    }

}
