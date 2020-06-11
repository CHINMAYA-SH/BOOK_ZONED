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
    public partial class book_delete : Form
    {
        public book_delete()
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

        private void bnBtn_Click(object sender, EventArgs e)
        {
            if (bookNameField.Text.Trim() != string.Empty)
            {
                string bookpath = @"C:\projects\book_zoned\Database\books.txt";
                books b = new books();
                string find = bookNameField.Text;
                b.search = find;
                bool foundText = false;
                string currentLine;
                try
                {
                    using (StreamReader sr = new StreamReader(bookpath))
                    {
                       
                        do
                        {
                            currentLine = sr.ReadLine();
                            if(currentLine!=null)
                            {
                                foundText = currentLine.Contains(b.search);
                            }
                        } while (currentLine != null && !foundText);
                    }
                    if (foundText)
                    {
                        dispBox.Text = currentLine;
                        MessageBox.Show("RECORD FOUND");
                    }
                    else
                    {
                        MessageBox.Show("RECORD NOT FOUND");
                        dispBox.Clear();
                    }
                    var oldLines = File.ReadAllLines(bookpath);
                    var newLines = oldLines.Where(line => !line.Contains(b.search));
                    File.WriteAllLines(bookpath, newLines);
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

        private void bidBtn_Click(object sender, EventArgs e)
        {
            if (bookIdField.Text.Trim() != string.Empty)
            {
                string bookpath = @"C:\projects\book_zoned\Database\books.txt";
                books b = new books();
                string find = bookIdField.Text;
                b.search = find;
                bool foundText = false;
                string currentLine;
                try
                {
                    using (StreamReader sr = new StreamReader(bookpath))
                    {
            
                        do
                        {
                            currentLine = sr.ReadLine();
                            if (currentLine != null)
                            {
                                foundText = currentLine.Contains(b.search);
                            }
                        } while (currentLine != null && !foundText);
                    }
                    if (foundText)
                    {
                        dispBox.Text = currentLine;
                        MessageBox.Show("RECORD FOUND");
                    }
                    else
                    {
                        MessageBox.Show("RECORD NOT FOUND");
                        dispBox.Clear();
                    }
                    var oldLines = File.ReadAllLines(bookpath);
                    var newLines = oldLines.Where(line => !line.Contains(b.search));
                    File.WriteAllLines(bookpath, newLines);
                }
                catch
                {
                    MessageBox.Show("NO BLANK FIELD MUST BE LEFT", "RETRY", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
        }

        private void dataBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string bookpath = @"C:\projects\book_zoned\Database\books.txt";

                if (!File.Exists(bookpath))
                {
                    File.Create(bookpath).Close();
                    MessageBox.Show("EMPTY CONTAINER", "NULL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                var lines = File.ReadAllLines(bookpath).Where(arg => !string.IsNullOrWhiteSpace(arg));
                File.WriteAllLines(bookpath, lines);
                var str = File.ReadAllText(bookpath);
                dispBox.Text = str;
            }
            catch
            {

            }
        }

        private void bookNameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bookIdField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
