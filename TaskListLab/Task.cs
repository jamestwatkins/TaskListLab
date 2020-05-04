using System;
using System.Collections.Generic;
using System.Text;

namespace TaskListLab
{
    class Task
    {
        //Tasks will have a Name, Description, Due Date (DateTime), and Completion

        private string name;
        private string description;
        private DateTime dueDate;
        private bool complete;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                name = value;
            }
        }
        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value;
            }
        }
        public bool Complete
        {
            get
            {
                return complete;
            }
            set
            {
                complete = value;
            }
        }


        public Task() { }

        public Task(string _name, string _description, DateTime _dueDate, bool _complete)
        {
            name = _name;
            description = _description;
            dueDate = _dueDate;
            complete = _complete;
        }




       
    }
}
