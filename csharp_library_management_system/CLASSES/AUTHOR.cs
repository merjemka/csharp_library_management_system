using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;

namespace csharp_library_management_system.CLASSES
{
    internal class AUTHOR
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
        public Boolean addAuthor(string fname, string lname, string edu, string bio)
        {
            string query = "INSERT INTO `authors`(`first_name`, `last_name`, `education`, `bio`) VALUES (@fn, @ln, @edu, @bio)";

            MySqlParameter[] parameters = new MySqlParameter[4];

            parameters[0] = new MySqlParameter("@fn", MySqlDbType.VarChar);
            parameters[0].Value = fname;
            parameters[1] = new MySqlParameter("@ln", MySqlDbType.VarChar);
            parameters[1].Value = lname;
            parameters[2] = new MySqlParameter("@edu", MySqlDbType.VarChar);
            parameters[2].Value = edu;
            parameters[3] = new MySqlParameter("@bio", MySqlDbType.VarChar);
            parameters[3].Value = bio;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public DataTable AuthorsList()
        {
            DataTable table = new DataTable();
            table = db.getData("SELECT * FROM `authors`", null);
            return table;
        }

    }
}
