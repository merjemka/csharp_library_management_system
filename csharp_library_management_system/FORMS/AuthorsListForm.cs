using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_library_management_system.FORMS
{
    public partial class AuthorsListForm : Form
    {
        private ManageBooksForm mngBooks = null;

        public AuthorsListForm(ManageBooksForm sourceForm)
        {
            mngBooks = sourceForm as ManageBooksForm;
            InitializeComponent();
        }
     
        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AuthorsListForm_Load(object sender, EventArgs e)
        {
            CLASSES.AUTHOR author = new CLASSES.AUTHOR();
            listBox_authors.DataSource = author.AuthorsList(true);
            listBox_authors.DisplayMember = "fullname";
            listBox_authors.ValueMember = "id";
        }

        private void button_select_close_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)listBox_authors.SelectedItem;
                string fullname = drv["fullname"].ToString();
                string id = drv["id"].ToString();

                //MessageBox.Show("ID = " + id + ", Full name = " + fullname);
                mngBooks.textBox_author.Text = fullname;
                mngBooks.label_authorid.Text = id;

                //if the listbox is empty
            } catch (Exception ex)
            {
              MessageBox.Show("No Author Selected" + ex.Message);
            }


            this.Close();

        }
    }
}
