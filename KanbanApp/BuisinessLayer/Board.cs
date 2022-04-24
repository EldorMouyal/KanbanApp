using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanApp.BuisinessLayer
{
    internal class Board
    {
        public string name { get; set; }
        public Queue<Task> BackLog { get; set; }
        public Queue<Task> InProgress { get; set; }
        public Queue<Task> done { get; set; }
        public int backMaxLength { get; set; }
        public int InProgressMaxLength { get; set; }
        public int doneMaxLength { get; set; }
        public void TransferTask(Queue<Task> tasks, Task task)
        {
            //fill conde here
        }
        public Board(String title, int backMaxLength, int inProgressMaxLength, int doneMaxLength)
        {
            name = title;

        }

    }
}
