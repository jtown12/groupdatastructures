using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupdatastructures
{
    class Program
    {

        //----------STACK----------//

        //STACK MENU
        static void stackMenu(Stack<string> s)
        {
            
            string item;
            bool menu = true;
            while (menu)
            {
                int input = 0;
                Console.WriteLine("1. Add one time to Stack");
                Console.WriteLine("2. Add Huge List of Items to Stack");
                Console.WriteLine("3. Display Stack");
                Console.WriteLine("4. Delete from Stack");
                Console.WriteLine("5. Clear Stack");
                Console.WriteLine("6. Search Stack");
                Console.WriteLine("7. Return to main menu");

                input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Enter what you would like to add: ");
                    item = Console.ReadLine();
                    s.Push(item);
                }
                else if (input == 2)
                {
                    addHugeListStck(s);
                    
                }
                else if (input == 3)
                {
                    displayStck(s);
                    continue;
                }
                else if (input == 4)
                {
                    Console.WriteLine("Which item would you like to remove from the Stack?: ");
                    item = Console.ReadLine();
                    stckDelete(s, item);
                }
                else if (input == 5)
                {
                    s.Clear();
                    Console.WriteLine("The Stack has been cleared.");
                }
                else if (input == 6)
                {
                    Console.WriteLine("Which item would you like to find in the Stack?: ");
                    item = Console.ReadLine();
                    stckSearch(s, item);
                }
                else if (input == 7)
                {
                    menu = false;
                }
            }
        }


        //2. ADD HUGE LIST
        static void addHugeListStck(Stack<string> stack)
        {
            stack.Clear();
            Console.WriteLine("Adding the list...");
            int i = 1;
            string s = "New Entry ";
            for (i = 1; i < 2001; i++)
            {
                stack.Push(s + i);
            }
            Console.WriteLine("Entries completed.");
        }

        //3. DISPLAY STACK (Do we need to maintain the contents of the stack for use after this function?
        static void displayStck(Stack<string> s)
        {
            Stack<string> stack2 = new Stack<string>();
            string i;
            if (s.Count() <=0)
            {
                Console.WriteLine("Stack is empty...");
            }
            while (s.Count() > 0)
            {
                i = s.Pop();
                stack2.Push(i);
                Console.WriteLine(i);
            }
            while (stack2.Count() > 0)
            {
                s.Push(stack2.Pop());
            }
        }


        //4. DELETE STACK ITEM 
        //if the item is in the stack, pop each item until you find it and add those items to a second stack
        //pop the item to be deleted then add the item from the new stack back onto the original stack.
        static void stckDelete(Stack<string> s, string item)
        {
            Stack<string> stack2 = new Stack<string>();
            string current = "";

            if (s.Contains(item))   
            {
                while (item != current)
                {
                    current = s.Pop();
                    if (item == current)
                    {
                        continue;
                    }
                    else
                    {
                        stack2.Push(current);
                    }
                }
                for (int i = 0; i < s.Count(); i++ )
                {
                    stack2.Push(s.Pop());
                }
                int y = stack2.Count();
                for (int i = 0; i < y; i++ )
                {
                    s.Push(stack2.Pop());
                }
                Console.WriteLine(item + " was deleted from the stack.");
            }
            else
            {
                Console.WriteLine(item + " was not found in the stack...");
            }
        }
        //5. CLEAR is written in the menu code, since it is an existing method

        //6. SEARCH STACK checks if the item exists in the stack and returns how long it took to find
        static void stckSearch(Stack<string> s, string item)
        {
            bool contains = false;
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            //begin timer
            sw.Start();
            contains = s.Contains(item);    //check if the item is in the stack
            sw.Stop();
            if (contains)   //if the item is in the stack say so and show how long it took to find
            {
                Console.WriteLine(item + " was found");
                Console.WriteLine(sw.Elapsed.ToString());
            }
            else
            {
                Console.WriteLine(item + " was not found");
            }
        }

        //----------QUEUE----------//
        
        static void addHugeListQ(Queue<string> q)
        {
            q.Clear();
            int i = 0;
            string s = "New Entry ";
            for (i = 0; i < 2000; i++)
            {
                q.Enqueue(s + i);
            }
        }

        //DISPLAY QUEUE
        static void displayQ(Queue<string> q)
        {
            if (q.Count() > 0)
            {
                foreach (string i in q)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Queue is empty...");
            }
        }


        //DICTIONARY
        static void addHugeListD(Dictionary<string, int> d)
        {
            d.Clear();
            int i = 0;
            string s = "New Entry ";
            for (i = 0; i < 2000; i++)
            {
                d.Add(s + i, i);
            }
        }
        //DISPLAY DICTIONARY
        static void displayD(Dictionary<string, int> d)
        {
            if (d.Count() > 0)
            {
                foreach (KeyValuePair<string, int> entry in d)
                {
                    Console.WriteLine(entry.Key + " " + entry.Value);
                }
            }
            else
            {
                Console.WriteLine("Dictionary is empty...");
            }
        }


        //MAIN PROGRAM
        static void Main(string[] args)
        {
            //Outermost while loop to return to main menu
            bool menu = true ;
            int userInput;
            int userInput2;

            //Initialize data types before the while loop so they can be adjusted within other methods
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();
            Dictionary<string, int> dict = new Dictionary<string, int>();


            while (menu)
            {
                Console.WriteLine("1. Stack");
                Console.WriteLine("2. Queue");
                Console.WriteLine("3. Dictionary");
                Console.WriteLine("4. Exit");

                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 1)
                {
                 
                    
                    stackMenu(stack);
                }

                if (userInput == 2)
                {
                    Console.WriteLine("1. Add one time to Queue");
                    Console.WriteLine("2. Add Huge List of Items to Queue");
                    Console.WriteLine("3. Display Queue");
                    Console.WriteLine("4. Delete from Queue");
                    Console.WriteLine("5. Clear Queue");
                    Console.WriteLine("6. Search Queue");
                    Console.WriteLine("7. Return to main menu");

                    userInput2 = Convert.ToInt32(Console.ReadLine());
                    //queueMenu
                }

                if (userInput == 3)
                {
                    Console.WriteLine("1. Add one time to Dictionary");
                    Console.WriteLine("2. Add Huge List of Items to Dictionary");
                    Console.WriteLine("3. Display Dictionary");
                    Console.WriteLine("4. Delete from Dictionary");
                    Console.WriteLine("5. Clear Dictionary");
                    Console.WriteLine("6. Search Dictionary");
                    Console.WriteLine("7. Return to main menu");

                    userInput2 = Convert.ToInt32(Console.ReadLine());
                    //dictMenu

                }

                if (userInput == 4)
                {
                    Console.WriteLine("Goodbye");
                    menu = false;
                }

            }





        }
    }
}
