namespace csharp_library_management_system.FORMS
{
    partial class ManageAuthorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_author = new System.Windows.Forms.PictureBox();
            this.label_close = new System.Windows.Forms.Label();
            this.label_header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox_bio = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_edu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_fname = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.dataGridView_authors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_author)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_authors)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_author
            // 
            this.pictureBox_author.ImageLocation = "../../IMAGES/typewriter.png";
            this.pictureBox_author.Location = new System.Drawing.Point(18, 12);
            this.pictureBox_author.Name = "pictureBox_author";
            this.pictureBox_author.Size = new System.Drawing.Size(89, 79);
            this.pictureBox_author.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_author.TabIndex = 8;
            this.pictureBox_author.TabStop = false;
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Transparent;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.White;
            this.label_close.Location = new System.Drawing.Point(1094, 12);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(36, 31);
            this.label_close.TabIndex = 7;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // label_header
            // 
            this.label_header.BackColor = System.Drawing.Color.Transparent;
            this.label_header.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_header.Location = new System.Drawing.Point(113, 12);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(307, 79);
            this.label_header.TabIndex = 6;
            this.label_header.Text = "AUTHORS";
            this.label_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pictureBox_author);
            this.panel1.Controls.Add(this.label_close);
            this.panel1.Controls.Add(this.label_header);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 100);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.button_edit);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Location = new System.Drawing.Point(-6, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 353);
            this.panel2.TabIndex = 10;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FloralWhite;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(18, 144);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(126, 52);
            this.button_delete.TabIndex = 13;
            this.button_delete.Text = " Delete";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_delete.UseVisualStyleBackColor = false;
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.FloralWhite;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.Location = new System.Drawing.Point(18, 82);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(126, 52);
            this.button_edit.TabIndex = 12;
            this.button_edit.Text = " Edit";
            this.button_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_edit.UseVisualStyleBackColor = false;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FloralWhite;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(18, 24);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(126, 52);
            this.button_add.TabIndex = 11;
            this.button_add.Text = " Add";
            this.button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBox_bio);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBox_edu);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox_lname);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox_fname);
            this.panel3.Controls.Add(this.textBox_ID);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label_ID);
            this.panel3.Location = new System.Drawing.Point(157, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 332);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // richTextBox_bio
            // 
            this.richTextBox_bio.Location = new System.Drawing.Point(112, 209);
            this.richTextBox_bio.Name = "richTextBox_bio";
            this.richTextBox_bio.Size = new System.Drawing.Size(240, 120);
            this.richTextBox_bio.TabIndex = 19;
            this.richTextBox_bio.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bio:";
            // 
            // textBox_edu
            // 
            this.textBox_edu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_edu.Location = new System.Drawing.Point(112, 160);
            this.textBox_edu.Name = "textBox_edu";
            this.textBox_edu.Size = new System.Drawing.Size(240, 30);
            this.textBox_edu.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Education:";
            // 
            // textBox_lname
            // 
            this.textBox_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lname.Location = new System.Drawing.Point(112, 111);
            this.textBox_lname.Name = "textBox_lname";
            this.textBox_lname.Size = new System.Drawing.Size(240, 30);
            this.textBox_lname.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name:";
            // 
            // textBox_fname
            // 
            this.textBox_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fname.Location = new System.Drawing.Point(112, 62);
            this.textBox_fname.Name = "textBox_fname";
            this.textBox_fname.Size = new System.Drawing.Size(240, 30);
            this.textBox_fname.TabIndex = 12;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.Location = new System.Drawing.Point(112, 18);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(160, 30);
            this.textBox_ID.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "First Name:";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(76, 20);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(37, 25);
            this.label_ID.TabIndex = 9;
            this.label_ID.Text = "ID:";
            // 
            // dataGridView_authors
            // 
            this.dataGridView_authors.AllowUserToAddRows = false;
            this.dataGridView_authors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_authors.Location = new System.Drawing.Point(520, 113);
            this.dataGridView_authors.Name = "dataGridView_authors";
            this.dataGridView_authors.RowHeadersWidth = 51;
            this.dataGridView_authors.RowTemplate.Height = 24;
            this.dataGridView_authors.Size = new System.Drawing.Size(596, 322);
            this.dataGridView_authors.TabIndex = 12;
            // 
            // ManageAuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1128, 450);
            this.Controls.Add(this.dataGridView_authors);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAuthorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAuthorsForm";
            this.Load += new System.EventHandler(this.ManageAuthorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_author)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_authors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_author;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_fname;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_bio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_edu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_authors;
    }
}