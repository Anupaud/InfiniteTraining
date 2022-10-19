//2.Create a structure
//struct Books
//   private string title;
//private string author;
//private string subject;
//private int book_id;
//Include 2 methods called GetValues() and ShowValues() to accept and display details.

//create a Class called TestStructures that invokes the above methods of the structure to accept and display the details of the book

using System;

namespace Assignment06
{
    struct Book
    {
        private string tittle;
        private string author;
        private string subject;
        private int book_id;

        public void getvalues(string t, string a, string s, int id)
        {
            tittle = t;
            author = a;
            subject = s;
            book_id = id;

        }
        public void showvalues()
        {
            Console.WriteLine("Tittle of the book : {0}", tittle);
            Console.WriteLine("Author of the book : {0}", author);
            Console.WriteLine("Subject of the book: {0}", subject);
            Console.WriteLine("Book id : {0}", book_id);
        }
    }
    class TestStructures
    { 
        static void Main(string[] args)
        {
            Book obj1 = new Book();
            obj1.getvalues("Science", "KM", "Physical science", 16688);
            obj1.showvalues();
            Console.Read();
        }
    }
}
