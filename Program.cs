using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void PrintMenu(List<string> l)   // helper function to print the menu
        {
            if(l.Count > 0)
            {
                Console.WriteLine("1. Create an Item");
                Console.WriteLine("2. List all Items");
                Console.WriteLine("3. Update an Item");
                Console.WriteLine("4. Delete an Item");
                Console.WriteLine("5. Exit");
            }
            else
            {
                Console.WriteLine("1. Create an Item");
                Console.WriteLine("5. Exit");
            }
        }
        static void Main(string[] args)
        {
            var list = new List<string>();  // the list holding items
            Console.WriteLine("Welcome to Assignment 1 by Ryan Ratkovich");
            PrintMenu(list);
            string input = Console.ReadLine();
            while (input != "5"){
                if(list.Count > 0)
                {
                    switch (input)
                    {
                        case "1":
                            Console.WriteLine("Enter a new Item:");
                            string newStr = Console.ReadLine();
                            list.Add(newStr);
                            Console.WriteLine("\n");
                            PrintMenu(list);
                            break;
                        case "2":
                            Console.WriteLine("Current Items:");
                            if (list.Count > 5)
                            {
                                bool listing = true;
                                int count = 5;
                                while (listing)
                                {
                                    if (list.Count - count > 0)
                                    {
                                        for (var i = count - 5; i < count; ++i)
                                        {
                                            Console.WriteLine($"{i} - {list[i]}");
                                        }
                                    }
                                    else
                                    {
                                        for (var i = count - 5; i < list.Count; ++i)
                                        {
                                            Console.WriteLine($"{i} - {list[i]}");
                                        }
                                    }
                                    if (count > 5)
                                        Console.WriteLine("p - Previous");
                                    if (count <= list.Count)
                                        Console.WriteLine("n - Next");
                                    string list_input = Console.ReadLine();
                                    if (list_input == "n" && count <= list.Count)
                                    {
                                            count += 5;
                                    }
                                    else if (list_input == "p" && count > 5)
                                    {
                                            count -= 5;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice.");
                                        break;
                                    }
                                }
                                Console.WriteLine("\n");
                                PrintMenu(list);
                                break;
                            }
                            else
                            {
                                for (var i = 0; i < list.Count; ++i)
                                {
                                    Console.WriteLine($"{i} - {list[i]}");
                                }
                            }
                            Console.WriteLine("\n");
                            PrintMenu(list);
                            break;
                        case "3":
                            Console.WriteLine("Enter the index [0,1,2,...] of the Item to update:");
                            string str = Console.ReadLine();    // user enters index
                            int index = Convert.ToInt32(str);   // convert to int
                            if (index < 0 || index >= list.Count)   // bound check
                            {
                                Console.WriteLine("Invalid index.");
                                PrintMenu(list);
                                break;
                            }
                            Console.WriteLine("Enter the new Item:");
                            newStr = Console.ReadLine();
                            list[index] = newStr;   // update item at index
                            Console.WriteLine("\n");
                            PrintMenu(list);
                            break;
                        case "4":
                            Console.WriteLine("Enter the index [0,1,2,...] of the Item to delete:");
                            str = Console.ReadLine();    // user enters index
                            index = Convert.ToInt32(str);   // convert to int
                            if (index < 0 || index >= list.Count)   // bound check
                            {
                                Console.WriteLine("Invalid index.");
                                PrintMenu(list);
                                break;
                            }
                            list.RemoveAt(index);   // remove item at index
                            Console.WriteLine("\n");
                            PrintMenu(list);
                            break;
                        case "5":
                            return; // Exit program.
                        default:
                            Console.WriteLine("Invalid option. Enter a number [1-5].\n"); // print error if invalid input
                            PrintMenu(list);
                            break;
                    }

                }
                else
                {
                    switch (input)
                    {
                        case "1":
                            Console.WriteLine("Enter a new Item:");
                            string newStr = Console.ReadLine();
                            list.Add(newStr);
                            Console.WriteLine("\n");
                            PrintMenu(list);
                            break;
                        case "5":
                            return; // Exit program.
                        default:
                            Console.WriteLine("Invalid option. Enter 1 or 5.\n"); // print error if invalid input
                            PrintMenu(list);
                            break;
                    }
                }
                input = Console.ReadLine(); // get new user input
            }
        }
    }
}
