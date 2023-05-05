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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            pictureBox_User.Image = Image.FromFile("../../IMAGES/user.png");
            pictureBox_Pass.Image = Image.FromFile("../../IMAGES/lock.png");
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_User_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Black;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.White;
        }

        private void textBox_password_Click(object sender, EventArgs e)
        {

        }
        //manipulate the dashboard from the login form
        private Dashboard_Form dashF = null;
        public Login_Form (Dashboard_Form SourceForm)
        {
            dashF = SourceForm as Dashboard_Form;
            InitializeComponent();
        }
        //the login button
        private void button_login_Click(object sender, EventArgs e)
        {
            dashF.Enabled = true;
            this.Close();
        }
    }
}
