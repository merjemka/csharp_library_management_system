using csharp_library_management_system.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_library_management_system.FORMS
{
    public partial class ManageBooksForm : Form
    {
        public ManageBooksForm()
        {
            InitializeComponent();
        }

        CLASSES.BOOK book = new CLASSES.BOOK();

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_close_Click(object sender, EventArgs e)
        {
                      this.Close();
        }

        private void ManageBooksForm_Load(object sender, EventArgs e)
        {
            button_add.Image = Image.FromFile("../../IMAGES/plus.png");
            button_edit.Image = Image.FromFile("../../IMAGES/updates.png");
            button_delete.Image = Image.FromFile("../../IMAGES/trash.png");
            button_select.Image = Image.FromFile("../../IMAGES/upload.png");

            //combobox with genres

            CLASSES.GENRE genre = new CLASSES.GENRE();
            comboBox_genre.DataSource = genre.GenresList();
            comboBox_genre.DisplayMember = "name";
            comboBox_genre.ValueMember = "id";


        }

        private void button_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                //display image in the picturebox
                pictureBox_cover.Image = Image.FromFile(opf.FileName);
            }
        }
        //show authors list
        private void button_select_authorid_Click(object sender, EventArgs e)
        {
            AuthorsListForm athls = new AuthorsListForm(this);
            athls.Show();
        }

        private void button_addbook_Click(object sender, EventArgs e)
        {
            //get data
            int id;
            string isbn = textBox_isbn.Text;
            string title = textBox_title.Text;
            int author_id ;
            int genre_id;
            int quantity;
            double price;
            string publisher = textBox_publisher.Text;
            string description = richTextBox_descript.Text;
            DateTime dt_rcv = dateTimePicker1.Value;

            MemoryStream ms = new MemoryStream();
            pictureBox_cover.Image.Save(ms, pictureBox_cover.Image.RawFormat);
            byte[] image = ms.ToArray();


            try
            {
                id = Convert.ToInt32(textBox_ID.Text);
                author_id = Convert.ToInt32(label_authorid.Text);
                genre_id = Convert.ToInt32(comboBox_genre.SelectedValue);
                quantity = Convert.ToInt32(numericUpDown_quantity.Value);
                price = Convert.ToDouble(textBox_price.Text);

                if (!book.doesIsbnExist(isbn))
                { 

                if (book.addBook(id, isbn, title, author_id, genre_id, quantity, price, publisher, dt_rcv, description, image))
                {
                    MessageBox.Show("New Book Added Successfully", "New Book", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Book Not Added", "Add-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                }
                else
                {
                    MessageBox.Show("This Book's ISBN Already Exists", "ISBN-Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Data-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button_clearfields_Click(object sender, EventArgs e)
        {
            //textBox_author.Text = "";
            foreach(var control in panel_add.Controls)
            {
                if (control.GetType()== typeof(TextBox))
                {
                    TextBox tb = (TextBox)control;
                    tb.Text = "";
                }
            }
            int numberofBooks = book.BooksList().Rows.Count + 1;
            textBox_ID.Text = numberofBooks.ToString();

            richTextBox_descript.Text = "";
            label_authorid.Text = "ID";
            comboBox_genre.SelectedIndex = 0;
            numericUpDown_quantity.Value = 0;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_cover.ImageLocation = "../../IMAGES/default.png";
        }
    }
}
