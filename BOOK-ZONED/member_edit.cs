using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOK_ZONED
{
    public partial class member_edit : Form
    {
        public member_edit()
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

        private void nameBtn_Click(object sender, EventArgs e)
        {
            if (nameField.Text.Trim() != string.Empty)
            {
                try
                {
                    string memberpath = @"C:\projects\book_zoned\Database\members.txt";
                    if (!File.Exists(memberpath))
                    {
                        File.Create(memberpath).Close();
                    }
                    members m = new members();
                    string name = nameField.Text;

                    m.name = name;
                    string search = name;
                    StreamReader sr = new StreamReader(memberpath);
                    string currentLine;
                    bool foundText = false;
                    do
                    {
                        currentLine = sr.ReadLine();
                        if (currentLine != null)
                        {
                            foundText = currentLine.Contains(search);
                        }

                    } while (currentLine != null && !foundText);

                    if (foundText)
                    {
                        string[] result = currentLine.Split('|');
                        string phno = result[7];
                        string add = result[5];
                        string email = result[8];
                        oldAddField.Text = add;
                        oldeidField.Text = email;
                        oldPhnoField.Text = phno;

                        dataBox.Text = currentLine;
                        MessageBox.Show("RECORD FOUND");
                    }
                    else
                    {
                        MessageBox.Show("RECORD NOT FOUND");
                        dataBox.Clear();
                    }
                    sr.Close();
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

        private void lcnBtn_Click(object sender, EventArgs e)
        {
            if (libcardnoField.Text.Trim() != string.Empty)
            {
                try
                {
                    string memberpath = @"C:\projects\book_zoned\Database\members.txt";
                    if (!File.Exists(memberpath))
                    {
                        File.Create(memberpath).Close();
                    }

                    members m = new members();
                    string lcn = libcardnoField.Text;
                    m.lcn = lcn;
                    string search = m.lcn;
                    StreamReader sr = new StreamReader(memberpath);
                    string currentLine;
                    bool foundText = false;
                    do
                    {
                        currentLine = sr.ReadLine();
                        if (currentLine != null)
                        {
                            foundText = currentLine.Contains(search);
                        }

                    } while (currentLine != null && !foundText);

                    if (foundText)
                    {
                        string[] result = currentLine.Split('|');
                        string phno = result[7];
                        string add = result[5];
                        string email = result[8];
                        oldAddField.Text = add;
                        oldeidField.Text = email;
                        oldPhnoField.Text = phno;

                        dataBox.Text = currentLine;
                        MessageBox.Show("RECORD FOUND","sUCCESS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("RECORD NOT FOUND", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    sr.Close();
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

        private void phnoBtn_Click(object sender, EventArgs e)
        {
            if (oldPhnoField.Text.Trim() != string.Empty && newPhnoField.Text.Trim() != string.Empty)
            {
                String oldph = oldPhnoField.Text;
                String newph = newPhnoField.Text;
                try
                {

                    members m = new members();

                    string memberpath = @"C:\projects\book_zoned\Database\members.txt";
                    m.op = oldph;
                    m.np = newph;

                    string str1 = File.ReadAllText(memberpath);

                    if (str1.Contains(m.op))
                    {
                        string value = str1.Replace(m.op, m.np);
                        File.WriteAllText(memberpath, value);
                        MessageBox.Show("SUCCESFULLY CHANGED PHONE NUMBER");


                        nameField.Clear();
                        libcardnoField.Clear();
                        oldAddField.Clear();
                        oldeidField.Clear();
                        oldPhnoField.Clear();
                        newAddField.Clear();
                        neweidField.Clear();

                        dataBox.Clear();

                    }
                    else
                    {
                        error.SetError(this.newPhnoField, "ENTER THE PROPER ADDRESS");
                        newPhnoField.Clear();
                    }
                }
                catch
                {

                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (oldAddField.Text.Trim() != string.Empty && newAddField.Text.Trim() != string.Empty)
            {
                String oldad = oldAddField.Text;
                String newad = newAddField.Text;
                try
                {

                    members m = new members();

                    string memberpath = @"C:\projects\book_zoned\Database\members.txt";
                    m.oa = oldad;
                    m.na = newad;

                    string str1 = File.ReadAllText(memberpath);

                    if (str1.Contains(m.oa))
                    {
                        string value = str1.Replace(m.oa, m.na);
                        File.WriteAllText(memberpath, value);
                        MessageBox.Show("SUCCESFULLY CHANGED ADDRESS");
                    }
                    else
                    {
                        error.SetError(this.newAddField, "ENTER THE PROPER ADDRESS");
                        newAddField.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("SOMETHING IS WRONG");
                }
            }
        }

        private void eidBtn_Click(object sender, EventArgs e)
        {
            if (oldeidField.Text.Trim() != string.Empty && neweidField.Text.Trim() != string.Empty)
            {
                String oldeid = oldeidField.Text;
                String neweid = neweidField.Text;
                try
                {

                    members m = new members();

                    string memberpath = @"C:\projects\book_zoned\Database\members.txt";
                    m.oe = oldeid;
                    m.ne = neweid;

                    string str1 = File.ReadAllText(memberpath);

                    if (str1.Contains(m.oe))
                    {
                        string value = str1.Replace(m.oe, m.oe);
                        File.WriteAllText(memberpath, value);
                        MessageBox.Show("SUCCESFULLY CHANGED EMAIL ID");
                    }
                    else
                    {
                        error.SetError(this.neweidField,"ENTER THE PROPER EMAIL");
                        neweidField.Clear();
                    }
                }
                catch
                {

                }
            }
        }

        private void newPhnoField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void nameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void libcardnoField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void newAddField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void newPhnoField_Leave(object sender, EventArgs e)
        {
            string memberpath = @"C:\projects\book_zoned\Database\members.txt";
            members m = new members();
            StreamReader sr = new StreamReader(memberpath);
            string currentLine;
            string find = newPhnoField.Text;
            m.search = find;
            bool foundText = false;
            do
            {
                currentLine = sr.ReadLine();
                if (currentLine != null)
                {
                    foundText = currentLine.Contains(m.search);
                }

            } while (currentLine != null && !foundText);

            if (foundText)
            {
                error.SetError(this.newPhnoField, "PHONE NUMBER ALREADY EXISTS");
                newPhnoField.Clear();
            }
        }

        private void neweidField_Leave(object sender, EventArgs e)
        {
            string memberpath = @"C:\projects\book_zoned\Database\members.txt";
            members m = new members();
            StreamReader sr = new StreamReader(memberpath);
            string currentLine;
            string find = neweidField.Text;
            m.search = find;
            bool foundText = false;
            do
            {
                currentLine = sr.ReadLine();
                if (currentLine != null)
                {
                    foundText = currentLine.Contains(m.search);
                }

            } while (currentLine != null && !foundText);

            if (foundText)
            {
                error.SetError(this.neweidField, "EMAIL ID ALREADY EXISTS");
                neweidField.Clear();
            }


            string pattern = "^([a-zA-Z0-9]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(neweidField.Text, pattern))
            {

            }
            else
            {
                MessageBox.Show("EMAIL NOT IN FORMAT", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

      
    }
}
