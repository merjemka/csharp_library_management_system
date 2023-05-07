namespace csharp_library_management_system.FORMS
{
    partial class AuthorsListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.listBox_authors = new System.Windows.Forms.ListBox();
            this.button_select_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.HotPink;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-57, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 130);
            this.label1.TabIndex = 1;
            this.label1.Text = "Authors List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.HotPink;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.Black;
            this.label_close.Location = new System.Drawing.Point(414, 9);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(36, 31);
            this.label_close.TabIndex = 2;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // listBox_authors
            // 
            this.listBox_authors.BackColor = System.Drawing.Color.LightPink;
            this.listBox_authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_authors.FormattingEnabled = true;
            this.listBox_authors.ItemHeight = 25;
            this.listBox_authors.Location = new System.Drawing.Point(21, 143);
            this.listBox_authors.Name = "listBox_authors";
            this.listBox_authors.Size = new System.Drawing.Size(408, 304);
            this.listBox_authors.TabIndex = 3;
            // 
            // button_select_close
            // 
            this.button_select_close.BackColor = System.Drawing.Color.FloralWhite;
            this.button_select_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_select_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select_close.Location = new System.Drawing.Point(21, 453);
            this.button_select_close.Name = "button_select_close";
            this.button_select_close.Size = new System.Drawing.Size(408, 48);
            this.button_select_close.TabIndex = 46;
            this.button_select_close.Text = "Select and Close";
            this.button_select_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_select_close.UseVisualStyleBackColor = false;
            this.button_select_close.Click += new System.EventHandler(this.button_select_close_Click);
            // 
            // AuthorsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(450, 513);
            this.Controls.Add(this.button_select_close);
            this.Controls.Add(this.listBox_authors);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorsListForm";
            this.Load += new System.EventHandler(this.AuthorsListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.ListBox listBox_authors;
        private System.Windows.Forms.Button button_select_close;
    }
}