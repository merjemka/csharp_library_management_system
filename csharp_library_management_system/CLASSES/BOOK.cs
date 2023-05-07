using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace csharp_library_management_system.CLASSES
{
    internal class BOOK
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

        //create a function to add a new book
        //SELECT `id`, `isbn`, `title`, `author_id`, `genre_id`, `quantity`, `price`, `publisher`, `date_received`, `description`, `cover` FROM `books`
        public Boolean addBook(int id, string isbn, string title, int author_id, int genre_id, int quantity, double price, string publisher, DateTime date_received, string description, byte[] cover )
        {
            string query = "INSERT INTO `books`(`id`, `isbn`, `title`, `author_id`, `genre_id`, `quantity`, `price`, `publisher`, `date_received`, `description`, `cover`) VALUES (@id, @isbn, @title, @author, @genre, @qty, @price, @publisher, @rec, @descr, @img)";

            MySqlParameter[] parameters = new MySqlParameter[11];

            //@id, @isbn, @title, @author, @genre, @qty, @price, @publisher, @rec, @descr, @img
            parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[0].Value = id;
            parameters[1] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            parameters[1].Value = isbn;
            parameters[2] = new MySqlParameter("@title", MySqlDbType.VarChar);
            parameters[2].Value = title;
            parameters[3] = new MySqlParameter("@author", MySqlDbType.Int32);
            parameters[3].Value = author_id;
            parameters[4] = new MySqlParameter("@genre", MySqlDbType.Int32);
            parameters[4].Value = genre_id;
            parameters[5] = new MySqlParameter("@qty", MySqlDbType.Int32);
            parameters[5].Value = quantity;
            parameters[6] = new MySqlParameter("@price", MySqlDbType.Double);
            parameters[6].Value = price;
            parameters[7] = new MySqlParameter("@publisher", MySqlDbType.VarChar);
            parameters[7].Value = publisher;
            parameters[8] = new MySqlParameter("@rec", MySqlDbType.Date);
            parameters[8].Value = date_received;
            parameters[9] = new MySqlParameter("@descr", MySqlDbType.VarChar);
            parameters[9].Value = description;
            parameters[10] = new MySqlParameter("@img", MySqlDbType.Blob);
            parameters[10].Value = cover;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

            //return true;
        }
        public Boolean editBook()
        {

            return true;
        }
        public Boolean removeBook()
        {

            return true;
        }

        public DataTable BooksList()
        {
            string query = "SELECT * FROM `books`";

            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        public Boolean doesIsbnExist(string isbn)
        {
            string query = " SELECT * FROM `books` WHERE `isbn`= @isbn";

            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            parameters[0].Value = isbn;

            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else {
                return false;

            }
        }
    }
}
