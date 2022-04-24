using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanApp.BuisinessLayer
{
    internal class Task
    {
        public int key { get; set; }
        public string title { get; set; }
        public string creationTime { get; set; }
        public string description { get; set; }
        public Task(string title, string description) {
            this.title = title; 
            this.description = description;
            fillTAskAuto();
        }

        private void fillTAskAuto()
        {

        }

        
    }
}
