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
using System.Text.RegularExpressions;

namespace BOOK_ZONED
{
    public partial class member_add : Form
    {
        public member_add()
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

        private void submitBtn_Click(object sender, EventArgs e)
        {

            if (nameField.Text.Trim() != string.Empty && libcardnoField.Text.Trim() != string.Empty && dobField.Text.Trim() != string.Empty && ageField.Text.Trim() != string.Empty && addField.Text.Trim() != string.Empty && uidField.Text.Trim() != string.Empty && phnoField.Text.Trim() != string.Empty && emailField.Text.Trim() != string.Empty)
            {
                members mb = new members();
                string memberpath = @"C:\projects\book_zoned\Database\members.txt";
                if (!File.Exists(memberpath))
                {
                    File.Create(memberpath).Close();
                }

                mb.name = nameField.Text;
                mb.lcn = libcardnoField.Text;
                mb.dob = dobField.Text;
                mb.age = ageField.Text;
                mb.address = addField.Text;
                mb.uid = uidField.Text;
                mb.phno = phnoField.Text;
                mb.eid = emailField.Text; 

                List<string> member_line = File.ReadAllLines(memberpath).ToList();
                string member_created = "| " + mb.name + " | " + mb.lcn + " | " + mb.dob + " | " + mb.age + " | " + mb.address + " | " + mb.uid + " | " + mb.phno + " | " + mb.eid + " | ";
                member_line.Add(member_created.TrimStart());
                File.WriteAllLines(memberpath, member_line);
                MessageBox.Show("SUCCESSFULLY ADDED MEMBER");

                nameField.Clear();
                libcardnoField.Clear();
                ageField.Clear();
                addField.Clear();
                uidField.Clear();
                phnoField.Clear();
                emailField.Clear();
            }
            else
            {
                MessageBox.Show("NO FIELS SHOULD BE LEFT BLANK", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void ageField_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void uidField_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void phnoField_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
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
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void addField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void emailField_Leave(object sender, EventArgs e)
        {
            string memberpath = @"C:\projects\book_zoned\Database\members.txt";
            members m = new members();
            StreamReader sr = new StreamReader(memberpath);
            string currentLine;
            string find = emailField.Text;
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
                nameError.SetError(this.emailField, "EMAIL ID ALREADY EXISTS");
                emailField.Clear();
            }


            string pattern = "^([a-zA-Z0-9]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if(Regex.IsMatch(emailField.Text,pattern))
            {
                
            }
            else
            {
                MessageBox.Show("EMAIL NOT IN FORMAT", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            string memberpath = @"C:\projects\book_zoned\Database\members.txt";
            members m = new members();
            StreamReader sr = new StreamReader(memberpath);
            string currentLine;
            string find = nameField.Text;
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

            if(foundText)
            {
                nameError.SetError(this.nameField, "NAME ALREADY EXISTS");
                nameField.Clear();
            }
        }

        private void libcardnoField_Leave(object sender, EventArgs e)
        {
            string memberpath = @"C:\projects\book_zoned\Database\members.txt";
            members m = new members();
            StreamReader sr = new StreamReader(memberpath);
            string currentLine;
            string find = libcardnoField.Text;
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
                nameError.SetError(this.libcardnoField, "LIBRARY CARD ALREADY EXISTS");
            }
        }

        private void uidField_Leave(object sender, EventArgs e)
        {
            string memberpath = @"C:\projects\book_zoned\Database\members.txt";
            members m = new members();
            StreamReader sr = new StreamReader(memberpath);
            string currentLine;
            string find = uidField.Text;
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
                nameError.SetError(this.uidField, "AADHAR CARD ALREADY EXISTS");
            }
        }

        private void phnoField_Leave(object sender, EventArgs e)
        {
            string memberpath = @"C:\projects\book_zoned\Database\members.txt";
            members m = new members();
            StreamReader sr = new StreamReader(memberpath);
            string currentLine;
            string find = phnoField.Text;
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
                nameError.SetError(this.phnoField, "PHONE NUMBER ALREADY EXISTS");
                phnoField.Clear();
            }
        }
    }
}



