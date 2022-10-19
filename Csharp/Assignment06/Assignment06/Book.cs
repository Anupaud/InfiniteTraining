//Indexers
//1.Create a class called Books with BookName and AuthorName members. Instantiate the class through constructor 
//and also write a method Display() to display the details. Create an Indexer of Books Object to store 5 books in a
//class called BookShelf.Using the indexer method assign values to the books and display the same.

//(Hint : Use Composition.Books object inside BookShelf class)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06
{
    class Books
    {
        string BookName;
        string AuthorName;

        public Books(string BookName, string AuthorName)
        {
            this.BookName = BookName;
            this.AuthorName = AuthorName;
        }
        public void Display()
        {
            Console.WriteLine("Name of the Book :" + BookName);
            Console.WriteLine("Author of the Book:" + AuthorName);
        }
    }
    class BookShelf
    {
        Books[] bookobj = new Books[5];

        public Books this[int position]
        {
            get { return bookobj[position];}
            set { bookobj[position] = value;}
        }

        static void Main()
        {
            BookShelf BS = new BookShelf();
            BS[0] = new Books("Chemistry", "aa");
            BS[1] = new Books("Physics", "bb");
            BS[2] = new Books("Maths", "cc");
            BS[3] = new Books("English", "dd");
            BS[4] = new Books("Kannada", "ee");

            for (int i=0; i<5; i++)
            {
                BS[i].Display();
            }
            Console.Read();

        }
    }
    
}
