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

namespace BOOK_ZONED
{
    public partial class book_add : Form
    {
        
        public book_add()
        {
            InitializeComponent();
            customizeDesign();
        }
       
        private void customizeDesign()
        {
            PanelBook.Visible = false;
            PanelMembers.Visible = false;
            PanelCirculation.Visible = false;
            PanelDatabase.Visible = false;
            PanelSearch.Visible = false;
        }

        private void hideSubMenu()
        {
            if (PanelBook.Visible == true)
            {
                PanelBook.Visible = false;
            }
            if (PanelMembers.Visible == true)
            {
                PanelMembers.Visible = false;
            }
            if (PanelCirculation.Visible == true)
            {
                PanelCirculation.Visible = false;
            }
            if (PanelDatabase.Visible == true)
            {
                PanelDatabase.Visible = false;
            }
            if (PanelSearch.Visible == true)
            {
                PanelSearch.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }



        private void memberBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelMembers);
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelBook);
        }

        private void circulationBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelCirculation);
        }

        private void dbBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelDatabase);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSearch);
        }

        private void addmemberBtn_Click(object sender, EventArgs e)
        {
            member_add ma = new member_add();
            this.Close();
            ma.Show();
        }

        private void remMemberBtn_Click(object sender, EventArgs e)
        {
            member_remove mr = new member_remove();
            this.Close();
            mr.Show();
        }

        private void editMemberBtn_Click(object sender, EventArgs e)
        {
            member_edit me = new member_edit();
            this.Close();
            me.Show();
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            book_add ba = new book_add();
            this.Close();
            ba.Show();
        }

        private void remBookBtn_Click(object sender, EventArgs e)
        {
            book_delete bd = new book_delete();
            this.Close();
            bd.Show();
        }


        private void vabBtn_Click(object sender, EventArgs e)
        {
            bookdb bdb = new bookdb();
            this.Close();
            bdb.Show();
        }

        private void vamBtn_Click(object sender, EventArgs e)
        {
            memberdb md = new memberdb();
            this.Close();
            md.Show();
        }

        private void vaibBtn_Click(object sender, EventArgs e)
        {
            circulationdb cd = new circulationdb();
            this.Close();
            cd.Show();
        }

        private void issueBtn_Click(object sender, EventArgs e)
        {
            issue i = new issue();
            this.Close();
            i.Show();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            returnbook rb = new returnbook();
            this.Close();
            rb.Show();
        }

        private void renewBook_Click(object sender, EventArgs e)
        {
            renew rn = new renew();
            this.Close();
            rn.Show();
        }

        private void findBookBtn_Click(object sender, EventArgs e)
        {
            search_book sb = new search_book();
            this.Close();
            sb.Show();
        }

        private void findmemBtn_Click(object sender, EventArgs e)
        {
            search_members sm = new search_members();
            this.Close();
            sm.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LOGGED OUT SUCCESSFULLY", "LOGGED OUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            a_mainpage am = new a_mainpage();
            this.Close();
            am.Show();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if(bookIdField.Text.Trim() != string.Empty && bookNameField.Text.Trim() != string.Empty && authorField.Text.Trim() != string.Empty && publicationField.Text.Trim() != string.Empty && costField.Text.Trim() != string.Empty)
            {
                books b = new books();
                string bookpath = @"C:\projects\book_zoned\Database\books.txt";
                b.bookid = bookIdField.Text;
                b.bookname = bookNameField.Text;
                b.author = authorField.Text;
                b.publication = publicationField.Text;
                b.costprice = costField.Text;
                int count = 1;

                try
                {
                    string searchString = bookIdField.Text;
                    bool foundText = false;
                    b.search = searchString;

                    using (StreamReader sr = new StreamReader(bookpath))
                    {
                        string currentLine;

                        do
                        {
                            currentLine = sr.ReadLine();
                            if (currentLine != null)
                            {
                                foundText = currentLine.Contains(b.search);
                            }
                        } while (currentLine != null && !foundText);


                        if (foundText)
                        {
                            string[] result = currentLine.Split('|');
                            string bookid = result[1];
                            string bookname = result[2];
                            string author = result[3];
                            string publication = result[4];
                            string costprice = result[5];
                            string counter = result[6];

                            count = int.Parse(counter);
                            count = count + 1;
                            result[6] = count.ToString();

                            MessageBox.Show("Book Already Exists", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string insert = "|" + bookid + "|" + bookname + "|" + author + "|" + publication + "|" + costprice + "|" + result[6] + "|";

                            bookData.Text = insert;

                            sr.Close();

                        }
                        else
                        {
                            hideBox.Text = "| " + b.bookid + " | " + b.bookname + " | " + b.author + " | " + b.publication + " | " + b.costprice + " | " + count + " | ";
                            MessageBox.Show("Confirm The Book Details", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                catch
                {

                }    
            }

            else
            {
                MessageBox.Show("NO FIELS SHOULD BE LEFT BLANK", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
               
            }
            
        }
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string bookpath = @"C:\projects\book_zoned\Database\books.txt";

            List<string> book_line = File.ReadAllLines(bookpath).ToList();
            book_line.Add(hideBox.Text);
            File.WriteAllLines(bookpath, book_line);
            MessageBox.Show("SUCCESFULLY UPDATED", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bookIdField.Clear();
            bookNameField.Clear();
            authorField.Clear();
            publicationField.Clear();
            costField.Clear();
            bookData.Clear();
            hideBox.Clear();
        }

        private void bookIdField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void costField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

     

        private void authorField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
        private void existingBtn_Click(object sender, EventArgs e)
        {
            string bookpath = @"C:\projects\book_zoned\Database\books.txt";
            string searchstring = bookIdField.Text;
            books b = new books();
            b.search = searchstring;
            bool foundText = false;


            using (StreamReader sr = new StreamReader(bookpath))
            {
                string currentLine;

                do
                {
                    currentLine = sr.ReadLine();
                    if (currentLine != null)
                    {
                        foundText = currentLine.Contains(b.search);
                    }
                } while (currentLine != null && !foundText);

                sr.Close();

            }
                if (foundText)
                {

                    var oldLines = File.ReadAllLines(bookpath);
                    var newLines = oldLines.Where(line => !line.Contains(b.search));
                    File.WriteAllLines(bookpath, newLines);

                }
            


            List<string> book_line = File.ReadAllLines(bookpath).ToList();
            string write = bookData.Text;
            book_line.Add(write);
            File.WriteAllLines(bookpath, book_line);
            MessageBox.Show("UPDATED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bookIdField.Clear();
            bookNameField.Clear();
            authorField.Clear();
            publicationField.Clear();
            costField.Clear();
            bookData.Clear();
            hideBox.Clear();

        }

        private void book_add_Load(object sender, EventArgs e)
        {

        }

     

        private void bookIdField_Leave(object sender, EventArgs e)
        {
            if (bookIdField.Text.Trim() != string.Empty)
            {
                books b = new books();
                string bookpath = @"C:\projects\book_zoned\Database\books.txt";

                try
                {
                    StreamReader sr = new StreamReader(bookpath);
                    string currentLine;
                    string searchString = bookIdField.Text;
                    b.search = searchString;
                    bool foundText = false;

                    do
                    {
                        currentLine = sr.ReadLine();
                        if (currentLine != null)
                        {
                            foundText = currentLine.Contains(b.search);
                        }
                    }
                    while (currentLine != null && !foundText);

                    if (foundText)
                    {
                        string[] result = currentLine.Split('|');
                        bookNameField.Text = result[2];
                        authorField.Text = result[3];
                        publicationField.Text = result[4];
                        costField.Text = result[5];
                    }
                    else
                    {
       
                    }
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("NO BLANK FIELD MUST BE LEFT", "RETRY", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void bookNameField_Leave(object sender, EventArgs e)
        {
            if (bookNameField.Text.Trim() != string.Empty)
            {
                books b = new books();
                string bookpath = @"C:\projects\book_zoned\Database\books.txt";

                try
                {
                    StreamReader sr = new StreamReader(bookpath);
                    string currentLine;
                    string searchString = bookNameField.Text;
                    b.search = searchString;
                    bool foundText = false;

                    do
                    {
                        currentLine = sr.ReadLine();
                        if (currentLine != null)
                        {
                            foundText = currentLine.Contains(b.search);
                        }
                    }
                    while (currentLine != null && !foundText);

                    if (foundText)
                    {
                        error.SetError(this.bookNameField, "BOOK NAME EXISTS \" " + bookNameField.Text.ToUpper() + "\"");
                        bookNameField.Clear();
                    }
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("NO BLANK FIELD MUST BE LEFT", "RETRY", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void bookNameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void publicationField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
