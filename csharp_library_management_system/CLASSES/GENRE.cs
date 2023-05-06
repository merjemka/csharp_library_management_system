using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Xml.Linq;
using System.Windows.Forms;

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

            if(db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        }

        // create a function to edit a genre
        public Boolean editGenre(int id, string name)
        {
            string query = "UPDATE `genres` SET `name`= @genre_name WHERE `id`=@id";

            MySqlParameter[] parameters = new MySqlParameter[2];
            parameters[0] = new MySqlParameter("@genre_name", MySqlDbType.VarChar);
            parameters[0].Value = name;

            parameters[1] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[1].Value = id;


            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // create a function to remove a genre
        public Boolean removeGenre(int id)
        {
            string query = "DELETE FROM `genres` WHERE `id`= @id";

            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[0].Value = id;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // create a function to return a table of genres
        public DataTable GenresList()
        {
            DataTable table = new DataTable();
            table = db.getData("SELECT * FROM `genres`", null);
            return table;
        }
    }
}
