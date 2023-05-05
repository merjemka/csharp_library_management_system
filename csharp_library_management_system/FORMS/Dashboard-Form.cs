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
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            pictureBox_Logo.Image = Image.FromFile("../../IMAGES/book.png");
            button_close.Image = Image.FromFile("../../IMAGES/close.png");
            button_books.Image = Image.FromFile("../../IMAGES/literature.png");
            button_authors.Image = Image.FromFile("../../IMAGES/author.png");
            button_genres.Image = Image.FromFile("../../IMAGES/tag.png");
            button_circulation.Image = Image.FromFile("../../IMAGES/loop.png");
            button_users.Image = Image.FromFile("../../IMAGES/users.png");

       
        } 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button_books_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Form_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;
            //show login_form
            Login_Form lgf = new Login_Form(this);
            lgf.Show();

        }
    }
}
