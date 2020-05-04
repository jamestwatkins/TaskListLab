using System;
using System.Collections.Generic;

namespace TaskListLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the list of tasks

            List<Task> taskList = new List<Task>();

            taskList.Add(new Task("Josh Stone", "Downstock Whole Store", DateTime.Parse("5/2/2020"), false));
            taskList.Add(new Task("Mike Ashton", "Complete Gaming Planograms", DateTime.Parse("5/10/2020"), false));
            taskList.Add(new Task("Lisa Johnson", "Install New Beats Display", DateTime.Parse("5/3/2020"), false));
            taskList.Add(new Task("Marsha May", "Validate All Clearence Sections", DateTime.Parse("5/9/2020"), false));
            taskList.Add(new Task("Sam Smart", "Clean and Bright Whole Store", DateTime.Parse("5/4/2020"), false));

            Console.WriteLine("Welcome to the Perfect Purchase Merchandising Task Manager");
            Console.WriteLine("==========================================================");
            Console.WriteLine();

            //Should all be in a while true
            //Print the menue/prompt to choose
            while (true)
            {

                Console.WriteLine("Please enter the number of the option you would like to pick:");
                Console.WriteLine();

                Console.WriteLine("1. List Tasks");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. Delete Task");
                Console.WriteLine("4. Mark Task as Complete");
                Console.WriteLine("5. Exit");

                //collect user input

                string input = Console.ReadLine();

                //validate input is in range/a number

                int taskNum = 0;

                bool isNum = int.TryParse(input, out taskNum);

                if (!isNum)
                {
                    Console.WriteLine("Please enter a valid option number");
                    continue;
                }
                else if (taskNum < 1 || taskNum > 5)
                {
                    Console.WriteLine("Please enter a valid option number");
                    continue;
                }


                //if statement to run through menue options. Create a method for each.
                //if 1, void method that takes in the list and prints it. Check if completed before printing. Use a string called "Completed"
                //if 2, method that takes in a message prompting to add a task and the list and returns the list. 
                //if 3, same as 2 but to delete a task. Should also print the list with numbers to choose.
                //if 4, same as 3 but marks a task as complete
                //Each option will bump the user back to the menue
                string again = "";

                if(taskNum == 1)
                {
                    PrintTaskList(taskList);
                }
                else if(taskNum == 2)
                {
                    taskList = AddTask(taskList);
                }
                else if(taskNum == 3)
                {
                    taskList = DeleteTask(taskList);
                }
                else if(taskNum == 4)
                {
                    taskList = MarkAsComplete(taskList);
                }
                else if(taskNum == 5)
                {
                    Console.WriteLine("Are you sure? y to exit:");

                    again = Console.ReadLine();

                    if (again == "y")
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                


                




                //if 5, ask are you sure. Then use a continue statement.


            }

                Console.WriteLine("Goodbye!");
            

        }

        public static void PrintTaskList(List<Task> list)
        {
            int count = 1;
            Console.WriteLine();

            foreach(Task task in list)
            {

                string isComplete = "No";

                if (task.Complete == true)
                {
                    isComplete = "Yes";

                }
                
                Console.WriteLine($"{count}. \nEmployee: {task.Name} \nTask: {task.Description} \nDue: {task.DueDate.ToShortDateString()} \nComplete? {isComplete}");
                count++;
                Console.WriteLine();
            }

        }

        public static List<Task> AddTask(List<Task> list)
        {
            string employee = "";
            string description = "";
            DateTime due;

            Console.Write("Employee: ");
            employee = Console.ReadLine();

            Console.Write("Task: ");
            description = Console.ReadLine();

            Console.Write("Due Date: ");
            due = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            list.Add(new Task(employee, description, due, false));

            return list;



        }

        public static List<Task> DeleteTask(List<Task> list)
        {
            string input = "";
            int num = 0;

            bool isNum = true;


            PrintTaskList(list);

            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Pick a task to delete:");

                input = Console.ReadLine();

                isNum = int.TryParse(input, out num);

                if (isNum)
                {
                    if (num > 0 && num <= list.Count)
                    {
                        list.Remove(list[num - 1]);
                        Console.WriteLine();

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid task number");
                        Console.WriteLine();
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine("Please enter a valid task number");
                    Console.WriteLine();
                    continue;
                }

            }

            return list;
        }

        public static List<Task> MarkAsComplete(List<Task> list)
        {
            string input = "";
            int num = 0;

            bool isNum = true;


            PrintTaskList(list);

            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Pick a task to mark as complete:");

                input = Console.ReadLine();

                isNum = int.TryParse(input, out num);

                if (isNum)
                {
                    if (num > 0 && num <= list.Count)
                    {
                        list[num - 1].Complete = true;
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid task number");
                        Console.WriteLine();
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine("Please enter a valid task number");
                    Console.WriteLine();
                    continue;
                }

            }

            return list;


        }
    }
}
