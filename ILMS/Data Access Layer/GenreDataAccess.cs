using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILMS.Data_Access_Layer
{
    class GenreDataAccess:DataAccess
    {
        public List<Genre> GetAllGenres()
        {
            string sql = "SELECT * FROM [Genres]";
            SqlDataReader reader = GetData(sql);
            List<Genre> genres = new List<Genre>();
            while (reader.Read())
            {
                Genre genre = new Genre();
                genre.Id = (int)reader[0];
                genre.Name = reader[1].ToString();
                genres.Add(genre);
            }

            return genres;
        }

        public bool GenreExists(string name)
        {
            List<Genre> genres = GetAllGenres();
            for (int i = 0; i < genres.Count(); i++)
            {
                if (genres[i].Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public String AddNewGenre(string name)
        {
            
            String sql = "INSERT INTO [Genres](GenreName)" +
                        " VALUES('" + name + "')";
            int result = this.ExecuteQuery(sql);

            if (result > 0)
            {
                return "Genra added successfully";
            }
            return "Task failed try again";
        } 

        public String editGenreName(string id, string name)
        {
            String sql = "UPDATE [Genres] SET GenreName='" + name + 
                         "' WHERE Id='" + id + "'";
            int result = this.ExecuteQuery(sql);

            if (result > 0)
            {
                return "Genre updated successfully";
            }
            return "Task failed\nPlease try again";
        }


        public String deleteGenreName(string id)
        {
            String sql = "DELETE FROM [Genres] WHERE Id='" + id + "'";
            int result = this.ExecuteQuery(sql);

            if (result > 0)
            {
                return "Genre deleted successfully";
            }
            return "Task failed\nPlease try again";
        }

        public List<String> GetAllGenreName()
        {
            List<Genre> genres = GetAllGenres();
            List<String> names = new List<String>();
            for (int i = 0; i < genres.Count(); i++)
            {
                names.Add(genres[i].Name);
            }
            return names;
        }

        public String GetGenreNameById(string id)
        {
            List<Genre> genres = GetAllGenres();
            for (int i = 0; i < genres.Count(); i++)
            {
                if (genres[i].Id == Convert.ToInt32(id))
                {
                    return genres[i].Name;
                }
            }
            return "-1";
        }

        public int GetGenreIdByName(string name)
        {
            List<Genre> genres = GetAllGenres();
            for (int i = 0; i < genres.Count(); i++)
            {
                if (genres[i].Name == name)
                {
                    return genres[i].Id;
                }
            }
            return -1;
        }

    }
}
