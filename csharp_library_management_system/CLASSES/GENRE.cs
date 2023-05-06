using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Xml.Linq;

namespace csharp_library_management_system.CLASSES
{
    internal class GENRE
    {
        THE_DATABASE.MYDB db =new THE_DATABASE.MYDB();
        // create a function to add a genre

        public Boolean addGenre(string name)
        {
            string query = "INSERT INTO `genres`(`name`) VALUES (@genre_name)";

            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@genre_name", MySqlDbType.VarChar);
            parameters[0].Value = name;

            db.setData(query, parameters);

            return true;
        }

        // create a function to edit a genre
        public Boolean editGenre(int id, string name)
        {
            return true;
        }

        // create a function to remove a genre
        public Boolean removeGenre(int id)
        {
            return true;
        }

        // create a function to return a table of genres
        public DataTable GenresList()
        {
            return new DataTable();
        }
    }
}
