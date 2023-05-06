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
    public partial class ManageGenresForm : Form
    {
        public ManageGenresForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        CLASSES.GENRE genre = new CLASSES.GENRE();
        private void ManageGenresForm_Load(object sender, EventArgs e)
        {
                        button_add.Image = Image.FromFile("../../IMAGES/plus.png");
                        button_edit.Image = Image.FromFile("../../IMAGES/updates.png");
                        button_delete.Image = Image.FromFile("../../IMAGES/trash.png");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;

            if (name.Trim().Equals(""))
            {
                MessageBox.Show("Enter The Genre Name", "Empty Genre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                genre.addGenre(name);
            }

        }
    }
}
