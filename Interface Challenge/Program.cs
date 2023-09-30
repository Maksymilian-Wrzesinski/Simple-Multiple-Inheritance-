using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Challenge
{
    interface ILoanable
    {
        string Borrower { get; set; }
        int LoanPeriod { get; }

        void Borrow(string borrower);
        void Return();
    }

    interface IPrintable
    {
        void Print();
    }

    public class Book : IPrintable, ILoanable
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public string Borrower { get; set;}
        public int LoanPeriod 
        {
            get
            {
                return 21;
            }
        }
        public void Print()
        {
            Console.WriteLine($"Book {Title} by {Author} ISBN: {ISBN}");
        }
        public void Borrow( string borrower)
        {
            if ( borrower == null ) 
            {
                Borrower = borrower;
            }
            else
            {
                Console.WriteLine($"Book has alredy been borrowed by {Borrower}");
            }
        }
        public void Return() 
        {
            if ( Borrower != null)
            {
                Console.WriteLine($"{Borrower} has returned the book {Title} thank you!");
                Borrower = null;
            }
            else { Console.WriteLine("The book has not been borrowed"); }
        }
    }

    public class DVD : IPrintable, ILoanable
    {
        public string Director { get; set; }
        public string Title { get; set; }
        public int LengthInMinutes { get; set; }
        public string Borrower { get; set; }
        public int LoanPeriod
        {
            get
            {
                return 7;
            }
        }
        public void Print()
        {
            Console.WriteLine($"DVD {Title} by {Director} LengthInMinutes: {LengthInMinutes}");
        }
        public void Borrow(string borrower)
        {
            if (borrower == null)
            {
                Borrower = borrower;
            }
            else
            {
                Console.WriteLine($"DVD has alredy been borrowed by {Borrower}");
            }
        }
        public void Return()
        {
            if (Borrower != null)
            {
                Console.WriteLine($"{Borrower} has returned the DVD {Title} thank you!");
                Borrower = null;
            }
            else { Console.WriteLine("The DVD has not been borrowed"); }
        }
    }

    public class CD : IPrintable, ILoanable
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int NumberOfTracks { get; set; }
        public string Borrower { get; set; }
        public int LoanPeriod
        {
            get
            {
                return 7;
            }
        }
        public void Print()
        {
            Console.WriteLine($"DVD {Title} by {Artist} NumberOfTracks: {NumberOfTracks}");
        }
        public void Borrow(string borrower)
        {
            if (borrower == null)
            {
                Borrower = borrower;
            }
            else
            {
                Console.WriteLine($"CD has alredy been borrowed by {Borrower}");
            }
        }
        public void Return()
        {
            if (Borrower != null)
            {
                Console.WriteLine($"{Borrower} has returned the CD {Title} thank you!");
                Borrower = null;
            }
            else { Console.WriteLine("The CD has not been borrowed"); }
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book
            {
            Borrower = "Max",
            Title = "Cook Nook",
            Author = "Maangchi",
            ISBN = 1234
        };

            CD cd = new CD
            {
                Artist = "The Beatles",
                Title = "Abbey Road",
                NumberOfTracks = 2,
                Borrower = "John Smith"
            };

            DVD dvd = new DVD
            {
                Director = "aRNOLD sHWARCENEGER",
                Title = "Predator",
                LengthInMinutes = 60,
                Borrower = "Max"

            };

            cd.Print();
            dvd.Print();
            book.Print();

            cd.Borrow("Someone");

            cd.Print();

            cd.Return();

            cd.Print();

            Console.ReadKey();
        }
    }
}
