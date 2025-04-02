using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    internal class TodoItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public TodoItem(string title)
        {
            Title = title;
            IsDone = false;
        }

        public void MarkAsDone()
        {
            IsDone = true;
        }
    }
}
