using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
    class Program
    {
        //Array to be searched
        int[] arr = new int[20];
        //Number of elements in the array
        int n;
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array;");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine
                        ("\nArray should have minimun 1 and maximum 20 elements. \n");
            }
            //Accept array elements 
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine(" Enter array elements");
            Console.WriteLine("---------------------");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                // accept the number to be searched
                Console.Write
                    ("\nEnter element want you to search ;");
                int item = Convert.ToInt32(Console.ReadLine());

                // Apply binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //obtain the index of the elements in the array
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //loop to search for the elements in the array
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;

                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at position"
                        + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString()
                        + "not found in the array\n");
                Console.WriteLine("\nNumber of comparison :" + ctr);

                Console.Write("\nContinue search (y/n):");
                ch = char.Parse(Console.ReadLine().ToUpper());
            } while ((ch == 'y'));
        }
        public void LinearSearch()
        {
            char ch;
            //search for number of comparison
            int ctr;
            do
            {
                // Accept the number to the searched
                Console.WriteLine("\nEnter the elements you want to search :");
                int item = Convert.ToInt32(Console.ReadLine());

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine
                            ("\n" + item.ToString() + " found st position "
                            + (i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                    Console.WriteLine("\n" + item.ToString()
                        + " not found in the array ");
                Console.WriteLine("\n Number of comparison: " + ctr);
                Console.Write("n\Continue search (y/n):");
                ch = char.Parse(Console.ReadLine().ToUpper());
            } while ((ch == 'y'));
        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            char ch;
            do
            {
                do
                {
                    Console.WriteLine("Menu Option");
                    Console.WriteLine("-------------");
                    Console.WriteLine("1.Linear Search");
                    Console.WriteLine("2.Binary Search");
                    Console.WriteLine("3.Exit");
                    Console.Write("Enter your choice (1,2,3) : ");
                    pilihanmenu = Convert.ToInt32(Console.ReadLine());
                    

                    }

                
        }
    }
}
