using System;

namespace HW3_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add users to list or if you want to stop enter'stop':");
            Users list = new Users();
            list.addToList();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("OK, it is users created by you:");
            list.listOfUsers();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("List in desc sorted order: ");
            list.sortedListOfUsers();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Your short list is:");
            list.RemoveRange();
            Console.ReadKey();

        }
    }
}
