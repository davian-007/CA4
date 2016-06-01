using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA4
{
    class Book
    {
        private int bookid;
        private string bookname;
        private string bookauthor;
        private double bookprice;
        public double size;

        private struct book
        {
            public int bookid;
            public string bookname;
            public string bookauthor;
            public double bookprice;
        };

        private static book[] books;

        //constructor
        public Book()
        {
            bookid = 0;
            bookname = "";
            bookauthor = "";
            bookprice = 0;
        }

        //contructor con parámetros
        public Book(int id, string name, string author, double price)
        {
            bookid = id;
            bookname = name;
            bookauthor = author;
            bookprice = price;
        }

        //propiedades 
        /*public int BookID
        {
            get { return bookid; }
            set { bookid = value; }
        }

        public string BookName
        {
            get { return bookname; }
            set { bookname = value; }
        }*/

        //propiedades 
        public void SetBookID(int id)
        {
            bookid = id;
        }

        public int GetBookID()
        {
            return bookid;
        }

        public void SetBookName(string name)
        {
            bookname = name;
        }

        public string GetBookName()
        {
            return bookname;
        }

        //Pendientes propiedades de autor y precio

        public void SetSize(int Size)
        {
            size = Size;
            books = new book[Size];
        }

        public void Initdata()
        {
            //inicializar
            for (int i = 0; i < books.Length; i++)
            {
                books[i].bookid = 0;
                books[i].bookname = "";
                books[i].bookauthor = "";
                books[i].bookprice = 0;
            }
        }

        public bool AddData(Book Book)
        {
            //agregar datos
            int i;
            for (i = 0; i < books.Length; i++)
            {
                if (books[i].bookid == 0)
                {
                    break;
                }
            }

            if (i < books.Length)
            {
                books[i].bookid = Book.bookid;
                books[i].bookname = Book.bookname;
                books[i].bookauthor = Book.bookauthor;
                books[i].bookprice = Book.bookprice;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SeekData(int record)
        {
            //buscar datos
            int i;
            for (i = 0; i < books.Length; i++)
            {
                if (books[i].bookid == record)
                {
                    break;
                }
            }

            if (i < books.Length)
            {
                bookid = books[i].bookid;
                bookname = books[i].bookname;
                bookauthor = books[i].bookauthor;
                bookprice = books[i].bookprice;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateData(Book Book, int record)
        {
            //actualizar datos
            int i;
            for (i = 0; i < books.Length; i++)
            {
                if (books[i].bookid == record)
                {
                    break;
                }
            }

            if (i < books.Length)
            {
                books[i].bookid = Book.bookid;
                books[i].bookname = Book.bookname;
                books[i].bookauthor = Book.bookauthor;
                books[i].bookprice = Book.bookprice;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteData(int record)
        {
            //borrar datos
            int i;
            for (i = 0; i < books.Length; i++)
            {
                if (books[i].bookid == record)
                {
                    break;
                }
            }

            if (i < books.Length)
            {
                books[i].bookid = 0;
                books[i].bookname = "";
                books[i].bookauthor = "";
                books[i].bookprice = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintData(int pos)
        {
            //imprimir todo el registro
            bookid = books[pos].bookid;
            bookname = books[pos].bookname;
            bookauthor = books[pos].bookauthor;
            bookprice = books[pos].bookprice;
        }

        // destructor
        ~Book()
        {

        }
    }
}
