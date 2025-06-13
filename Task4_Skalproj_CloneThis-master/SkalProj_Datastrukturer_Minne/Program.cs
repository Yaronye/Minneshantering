using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        
        
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n5. ReverseString"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        ReverseString(); 
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /*
        
        1. När ökar listans kapacitet? (Alltså den underliggande arrayens storlek) 
            När man når full kapacitet, då ökar den med 4 platser.

        2. Med hur mycket ökar kapaciteten?
            4 slots

        3. Varför ökar inte listans kapacitet i samma takt som element läggs till? 
            För att det skulle innebära en extra händelse varje gång något läggs till i listan.smth smth bit sizes

        4. Minskar kapaciteten när element tas bort ur listan? 
            Nej.

        5. När är det då fördelaktigt att använda en egendefinierad array istället för en lista? 
            När man vet hur stor man behöver att containern ska vara är det bättre med en array då den har en konstant access time genom indexing.


        */
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            Console.WriteLine("Please write '+string' to add the string to the list, '-string' to remove the string from the list or 0 to exit to the main menu.");

            List<string> theList = new List<string>();
            string input;
            char nav;
            string value;

            //switch(nav){...}
            bool exit = false;
            while(!exit)
            {
                input = Console.ReadLine()!;
                nav = input[0];
                value = input.Substring(1);
                switch (nav)
                {
                    case '0':
                        exit = true;
                        break;
                    case '+':
                        theList.Add(value);
                        Console.WriteLine("Current list has " + theList.Count + " entries, and " + theList.Capacity + " total capacity."); 
                        break;
                    case '-':
                        RemoveFromList(value, theList);
                        Console.WriteLine("Current list has " + theList.Count + " entries, and " + theList.Capacity + " total capacity.");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input: +string, -string or 0 to exit to the main menue.");
                        break;
                }
            }

        }
        static void RemoveFromList(string value, List<string> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("The list is empty.");
            }
            else if (list.Contains(value))
            {
                list.Remove(value);
            }
            else
            {
                Console.WriteLine("List does not contain " + value);
            }
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            var theQueue = new Queue<string>();
            string input;
            char nav;
            string value;

            bool exit = false;
            Console.WriteLine("Please write '+string' to add the string to the queue, '-' to remove the first element from the queue or 0 to exit to the main menu.");
            while (!exit)
            {
                input = Console.ReadLine()!;
                nav = input[0];
                value = input.Substring(1);
                switch (nav)
                {
                    case '0':
                        exit = true;
                        break;
                    case '+':
                        theQueue.Enqueue(value);
                        Console.WriteLine("Current head of the queue: " + theQueue.Peek());
                        break;
                    case '-':
                        if(theQueue.Count == 0)
                        {
                            Console.WriteLine("The queue is empty.");
                        }
                        else
                        {
                            theQueue.Dequeue();
                            Console.WriteLine("Current head of the queue: " + theQueue.Peek());
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input: +string, -string or 0 to exit to the main menue.");
                        break;
                }
            }
        }
        /// <summary>
        /// Examines the datastructure Stack
        /*
        
        1. Simulera ännu en gång ICA-kön på papper. Denna gång med en stack. Varför är det inte så smart att använda en stack i det här fallet? 

            För att den som ställer sig i kön senast alltid kommer få hjälp först, medans de som ställde sig i kön tidigt måste vänta tills ingen annan ställer sig i kön innan de får hjälp.



        2. Implementera en ReverseText-metod som läser in en sträng från användaren och med hjälp av en stack vänder ordning på teckenföljden för att sedan skriva ut den omvända strängen till användaren. 
            



        */
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            var theStack = new Stack<string>();
            string input;
            char nav;
            string value;

            bool exit = false;
            Console.WriteLine("Please write '+string' to add the string to the stack, '-' to remove the head from the stack or 0 to exit to the main menu.");
            while (!exit)
            {
                input = Console.ReadLine()!;
                nav = input[0];
                value = input.Substring(1);
                switch (nav)
                {
                    case '0':
                        exit = true;
                        break;
                    case '+':
                        theStack.Push(value);
                        Console.WriteLine("Current head of the Stack: " + theStack.Peek());
                        break;
                    case '-':
                        if (theStack.Count == 0)
                        {
                            Console.WriteLine("The stack is empty.");
                        }
                        else
                        {
                            theStack.Pop();
                            Console.WriteLine("Current head of the queue: " + theStack.Peek());
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input: +string, -string or 0 to exit to the main menue.");
                        break;
                }
            }
        }

        static void CheckParanthesis()      //referenced from https://www.geeksforgeeks.org/check-for-balanced-parentheses-in-an-expression/
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            var theStack = new Stack<char>();
            Console.WriteLine("Please enter a string to be checked. ");
            string input = Console.ReadLine()!;
            char value;

            for (int i = 0; i < input.Length; i++)
            {
                value = input[i];
                if(value == '(' || value == '{' || value == '[')
                {
                    theStack.Push(value);
                }
                else
                {
                    if((theStack.Count > 0 &&
                    ((theStack.Peek() == '(' && value == ')') ||
                     (theStack.Peek() == '{' && value == '}') ||
                     (theStack.Peek() == '[' && value == ']'))))
                    {
                        theStack.Pop();
                    }
                }
            }
            if(theStack.Count == 0)
            {
                Console.WriteLine("The brackets are balanced.");
            }
            else
            {
                Console.WriteLine("The brackets are unbalanced.");
            }
        }

        static void ReverseString()
        {
            var theStack = new Stack<char>();
            Console.WriteLine("Please enter a string to be reversed. ");
            string input = Console.ReadLine()!;
            string newString = "";
            char value;
            int count = input.Length;
            for (int i = 0; i < count; i++)
            {
                value = input[i];
                theStack.Push(value);
            }
            for (int i = 0; i < count; i++)
            {
                newString += theStack.Pop()!;
            }
            Console.WriteLine(newString + "\n");
        }

    }
}

