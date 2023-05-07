using csharp_library_management_system.CLASSES;
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
    public partial class ManageAuthorsForm : Form
    {

        CLASSES.AUTHOR author = new CLASSES.AUTHOR();
        public ManageAuthorsForm()
        {
            InitializeComponent();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageAuthorsForm_Load(object sender, EventArgs e)
        {
            button_add.Image = Image.FromFile("../../IMAGES/plus.png");
            button_edit.Image = Image.FromFile("../../IMAGES/updates.png");
            button_delete.Image = Image.FromFile("../../IMAGES/trash.png");

            // populate datagridview with authors
            dataGridView_authors.DataSource = author.AuthorsList(false);

            //customize datagridview header
            dataGridView_authors.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_authors.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12);
            dataGridView_authors.EnableHeadersVisualStyles = false;
            dataGridView_authors.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_authors.DefaultCellStyle.Font = new Font("Arial", 10);
        }


        private void button_add_Click(object sender, EventArgs e)
        {
            string first_name = textBox_fname.Text;
            string last_name = textBox_lname.Text;
            string education = textBox_edu.Text;
            string bio = richTextBox_bio.Text;
            
            if(first_name.Trim().Equals("") || last_name.Trim().Equals(""))
            {
                MessageBox.Show("You Need To Enter The Author First And Last Name", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(author.addAuthor(first_name,last_name,education,bio))
                {

                    MessageBox.Show("New Author Added Successfully", "New Author", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView_authors.DataSource = author.AuthorsList(false);
                }
                else
                {
                    MessageBox.Show("Author Not Added", "Add-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }


        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_ID.Text);
                string first_name = textBox_fname.Text;
                string last_name = textBox_lname.Text;
                string education = textBox_edu.Text;
                string bio = richTextBox_bio.Text;

                if (first_name.Trim().Equals("") || last_name.Trim().Equals(""))
                {
                    MessageBox.Show("You Need To Enter The Author First And Last Name", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (author.editAuthor(id, first_name, last_name, education, bio))
                    {

                        MessageBox.Show("The Author Data Has Been Updated Successfully", "Edit Author", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView_authors.DataSource = author.AuthorsList(false);
                    }
                    else
                    {
                        MessageBox.Show("Author Data Not Updated", "Edit-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Author ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_authors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_ID.Text = dataGridView_authors.CurrentRow.Cells[0].Value.ToString();
            textBox_fname.Text = dataGridView_authors.CurrentRow.Cells[1].Value.ToString();
            textBox_lname.Text = dataGridView_authors.CurrentRow.Cells[2].Value.ToString();
            textBox_edu.Text = dataGridView_authors.CurrentRow.Cells[3].Value.ToString();
            richTextBox_bio.Text = dataGridView_authors.CurrentRow.Cells[4].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_ID.Text);

                if(MessageBox.Show("Do you really want to delete this author?","Confirmation Box",MessageBoxButtons.YesNo,MessageBoxIcon .Question) == DialogResult.Yes)
                {
                    if (author.removeAuthor(id))
                    {
                        MessageBox.Show("The Author Data Has Been Deleted Successfully", "Delete Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_ID.Text = "";
                        textBox_fname.Text = "";
                        textBox_lname.Text = "";
                        textBox_edu.Text = "";
                        richTextBox_bio.Text = "";

                        dataGridView_authors.DataSource = author.AuthorsList(false);
                    }
                    else
                    {
                        MessageBox.Show("The Author Data Has Not Been Deleted Successfully", "Delete Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                            
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Author ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_show_author_books_Click(object sender, EventArgs e)
        {

        }
    }
    
}
