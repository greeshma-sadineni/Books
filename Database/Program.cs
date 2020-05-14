using System;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Database
{
    class Program
    {
      
        static void Main(string[] args)
        {
            // string[] lines = new string[1000];
            List<string> Books = new List<string>();
            Books = File.ReadAllLines(@"C:\Users\91970\Desktop\Book\Books.txt").ToList();
            string Title,Author;
            
           
                Console.WriteLine("Enter Title");
                Title = Console.ReadLine();
                Console.WriteLine("Enter Author");
                Author = Console.ReadLine();
                Books.Add(Title + " " + Author);
                File.WriteAllLines(@"C:\Users\91970\Desktop\Book\Books.txt",Books);
           
            
               
            
            Console.WriteLine("Contents of Textfile :");
            foreach (string line in Books)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("Enter Title  or Author of book");
            
            
                String search = Console.ReadLine();
           search= search.ToLower();
                foreach (string line in Books)
                {
                if (line.Contains(search))
                {
                    Console.WriteLine( "Books with given title and author: "+line);
                }
              
            
            }
                
            Console.WriteLine("enter row no to delete :");
          
                int num;
                num = Convert.ToInt32(Console.ReadLine());
                if (num > Books.Count())

                {

                    Console.WriteLine("No Book Exits At that position Try again");

                }
                else
                {

                    Console.WriteLine("Deleted  " + Books[num-1] + " from no " + num);
                    Books.RemoveAt(num-1);
                    File.WriteAllLines(@"C:\Users\91970\Desktop\Book\Books.txt", Books);
                int i=Books.Count();
               
                Console.WriteLine("no of books in text file  :"+ i--);
               
                Console.Read();
                }

        }

    }
}

        
    


