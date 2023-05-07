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
    public partial class ManageBooksForm : Form
    {
        public ManageBooksForm()
        {
            InitializeComponent();
        }

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
            AuthorsListForm athls = new AuthorsListForm();
            athls.Show();
        }
    }
}
