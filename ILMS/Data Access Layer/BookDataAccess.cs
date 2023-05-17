using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILMS.Data_Access_Layer
{
    class BookDataAccess:DataAccess
    {
        public bool BookExists(Book book)
        {
            List<Book> books = GetAllBooks();
            for (int i = 0; i < books.Count(); i++)
            {
                if (books[i].Title == book.Title && books[i].Author==book.Author && books[i].Edition==book.Edition)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Book> GetAllBooks()
        {
            string sql = "SELECT * FROM [Books]";
            SqlDataReader reader = GetData(sql);
            List<Book> books = new List<Book>();
            while (reader.Read())
            {
                Book book = new Book();
                book.Id = (int)reader[0];
                book.Title = reader[1].ToString();
                book.Genre = reader[2].ToString();               
                book.Author = reader[3].ToString();
                book.PublishedDate = reader[4].ToString();
                book.Edition = reader[5].ToString();
                book.Issued = reader[6].ToString();

                books.Add(book);
            }

            return books;

        }

        public List<Book> GetBooksByGenre(int genre)
        {
            string sql = "SELECT * FROM [Books] WHERE Genre='"+genre+"'";
            SqlDataReader reader = GetData(sql);
            List<Book> books = new List<Book>();
            while (reader.Read())
            {
                Book book = new Book();
                book.Id = (int)reader[0];
                book.Title = reader[1].ToString();
                book.Genre = reader[2].ToString();
                book.Author = reader[3].ToString();
                book.PublishedDate = reader[4].ToString();
                book.Edition = reader[5].ToString();
                book.Issued = reader[6].ToString();

                books.Add(book);
            }

            return books;

        }

        public String AddNewBook(Book book)
        {            
            GenreDataAccess genreDataAccess = new GenreDataAccess();
            String genreId = genreDataAccess.GetGenreIdByName(book.Genre).ToString();

            String sql = "INSERT INTO [Books](Title,Genre,Author,PublishedDate,Edition,Issued)" +
                        " VALUES('" + book.Title + "','"+ genreId + "','"+book.Author+"'," +
                        "'"+book.PublishedDate+"','"+book.Edition+"','No')";
            int result = this.ExecuteQuery(sql);

            if (result > 0)
            {
                return "Book added successfully";
            }
            return "Task failed\ntry again";
        }

        public String UpdateBook(Book book)
        {
            GenreDataAccess genreDataAccess = new GenreDataAccess();
            String genreId = genreDataAccess.GetGenreIdByName(book.Genre).ToString();

            String sql = "UPDATE [Books] SET Title = '" + book.Title + "', Genre = '" + genreId + "', Author ='" + book.Author + "', " +
                "PublishedDate = '" + book.PublishedDate + "', Edition = '" + book.Edition + "',Issued = '"+book.Issued+"' WHERE Id = '"+book.Id+"'";
            int result = this.ExecuteQuery(sql);

            if (result > 0)
            {
                return "Book updated successfully";
            }
            return "Task failed\ntry again";
        }

        public String deleteBook(string id)
        {
            String sql = "DELETE FROM [Books] WHERE Id='" + id + "'";
            int result = this.ExecuteQuery(sql);

            if (result > 0)
            {
                return "Book deleted successfully";
            }
            return "Task failed\nPlease try again";
        }
        public List<Book> searchBooksByTitle(string title)
        {
            string sql = "SELECT * FROM [Books] Where Title LIKE '%"+title+"%'";
            SqlDataReader reader = GetData(sql);
            List<Book> books = new List<Book>();
            while (reader.Read())
            {
                Book book = new Book();
                book.Id = (int)reader[0];
                book.Title = reader[1].ToString();
                book.Genre = reader[2].ToString();
                book.Author = reader[3].ToString();
                book.PublishedDate = reader[4].ToString();
                book.Edition = reader[5].ToString();
                book.Issued = reader[6].ToString();

                books.Add(book);
            }

            return books;
        }

        public List<Book> searchBooksByAurthor(string aurthor)
        {
            string sql = "SELECT * FROM [Books] Where Author LIKE '%" + aurthor + "%'";
            SqlDataReader reader = GetData(sql);
            List<Book> books = new List<Book>();
            while (reader.Read())
            {
                Book book = new Book();
                book.Id = (int)reader[0];
                book.Title = reader[1].ToString();
                book.Genre = reader[2].ToString();
                book.Author = reader[3].ToString();
                book.PublishedDate = reader[4].ToString();
                book.Edition = reader[5].ToString();
                book.Issued = reader[6].ToString();

                books.Add(book);
            }

            return books;
        }
    }
}
