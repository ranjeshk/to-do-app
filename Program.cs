using System.Threading.Channels;

namespace To_do_List_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TODO application");
            List<string> tasksList = new List<string>();

            string option = "";

            while (option != "e")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to add a task");
                Console.WriteLine("Enter 2 to remove a task");
                Console.WriteLine("Enter 3 to view the list");
                Console.WriteLine("Enter e to exit the program");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Enter the task name");
                    string task = Console.ReadLine();
                    tasksList.Add(task);
                    Console.WriteLine("Task added succesfully");
                }
                else if (option == "2") 
                {
                    for (int i = 0; i < tasksList.Count; i++) 
                    {
                        Console.WriteLine($"{i+1} : {tasksList[i]}" );
                    }
                    Console.WriteLine("Enter the task number to remove");
                    int taskNum = Convert.ToInt32(Console.ReadLine());
                    int finalTaskNum = taskNum - 1;

                    tasksList.RemoveAt(finalTaskNum);

                    Console.WriteLine("task removed succesfully");
                    
                    
                }
                else if(option == "3")
                {
                    Console.WriteLine("Here is the list of tasks");
                    for(int i = 0;i < tasksList.Count; i++)
                    {
                        Console.WriteLine($"{i+1} : {tasksList[i]}");
                    }
                }
                else if(option == "e")
                {
                    Console.WriteLine("thank you for using the program");
                    Console.WriteLine("exiting program");

                }
                else
                {
                    Console.WriteLine("invalid input");
                }
               

            }
        }
}   }
