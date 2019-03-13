using System;
using System.Collections.Generic;

namespace HW3_Task2
{
    class Users
    {
        bool added = true;
        string newuser;


        List<string> users = new List<string>() { };
        public void addToList()
        {
            while (added)
            {
                newuser = Console.ReadLine();

                if (newuser == "stop")
                {
                    break;
                }

                users.Add(newuser);
            }
        }

        public void listOfUsers()
        {
            foreach (string newuser in users)
                Console.Write($"{newuser} ");
            
        }
        public void sortedListOfUsers()
        {
            users.Sort();
            users.Reverse();
            foreach (var newuser in users)
                Console.Write($"{newuser} ");
        }
        public void RemoveRange()
        {
            int n = users.Count - 2;
            users.RemoveRange(1, n);
            foreach (var newuser in users)
                Console.Write($"{newuser} ");
        }
    }
}
