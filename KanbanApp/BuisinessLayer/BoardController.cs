using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanApp.BuisinessLayer
{
    internal class BoardController
    {
        private readonly Dictionary<string, Board> boards = new Dictionary<string, Board>();
        public BoardController() { }
        internal void CreateBoard(string title, int backMaxLength, int inProgressMaxLength, int doneMaxLength)
        {
            if (title is null)
            {
                //log.Debug("User with null email attempted register");       ********
                throw new Exception($"Title is null");
            }

            if (backMaxLength is 0)
            {
                //log.Debug("User with null email attempted register");       ********
                throw new Exception($"Back max length can not be 0");
            }
            if (inProgressMaxLength is 0)
            {
                //log.Debug("User with null email attempted register");       ********
                throw new Exception($"In progress max length can not be 0");
            }
            if (doneMaxLength is 0)
            {
                //log.Debug("User with null email attempted register");       ********
                throw new Exception($"done max length can not be 0");
            }
            if (boards.ContainsKey(title))
            {
                throw new Exception($"Title {title} already exists");
            }
            Board b = new Board(title,backMaxLength, inProgressMaxLength, doneMaxLength);
            boards[title] = b; //ading to dictionary of existing boards
        }

        internal void LoadAllBoards()
        {
            //List<DataAccessLayer.User> users = dalController.LoadAllUsers();
            // foreach (var user in users)
            //{
            //  User u = new User(user.Email, user.Password);
            //users[u.Email] = u;
            //}
        }
        public void DeleteBoard(int key) { }
        public void GetBoard(int key) { } // type User?
        public void addTaskToBoard(String title, Task t) { }
        public void UpdateBoardTitle(String title) { }


    }
}

