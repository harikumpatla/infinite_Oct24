using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Doctor
    {
        private String regnNO;
        private String name;
        private int feeCharged;

        public void GetData()
        {
            Console.WriteLine("Enter regn No :");
            regnNO = Console.ReadLine();
            Console.WriteLine("Enter Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Fee :");
            feeCharged = Convert.ToInt32(Console.ReadLine());
        }

        public void PutData()
        {
            Console.WriteLine("Name of the Doctor :{0}", name);
            Console.WriteLine("Regn No : {0}", regnNO);
            Console.WriteLine("Fee Charged : {0}", feeCharged);
        }
    }
    class Books
    {
        public string bookName;
        public string authorName;

        public Books(string bookName, string authorName)
        {
            this.bookName = bookName;

            this.authorName = authorName;
        }

        public void Display()
        {
            Console.WriteLine("Book Name : " + bookName);

            Console.WriteLine("Author Name : " + authorName);
        }
    }
    
    class BookShelf
    {
        Books[] booksobj = new Books[5];

        public Books this[int fav]
        {
            get
            {
                return booksobj[fav];
            }

            set
            {
                booksobj[fav] = value;
            }
        }
    }

    class DriverClass
    {
        static void Main()
        {
            Doctor doctor = new Doctor();
            doctor.GetData();
            doctor.PutData();

            Console.WriteLine("===========================");

            BookShelf books = new BookShelf();

            books[0] = new Books("Animal Farm", "George Orwell");

            books[1] = new Books("Ben Hur", "Lewis Wallance");

            books[2] = new Books("Time Machine", "H.G");

            books[3] = new Books("A Passage To India", "E.M.Forster");

            books[4] = new Books("Chitra", "R.N.Tagore");

            for (int i = 0; i < 5; i++)
            {
                books[i].Display();
            }

            Console.Read();
        }
    }
}
