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
    public partial class renew : Form
    {
        public renew()
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
            if (libcardnoField.Text.Trim() != string.Empty && bookIdField.Text.Trim() != string.Empty && bookNameField.Text.Trim() != string.Empty && extendDate.Text.Trim() != string.Empty)
            {
                string circpath = @"C:\projects\book_zoned\Database\circulation.txt";
                string issuepath = @"C:\projects\book_zoned\Database\issued.txt";
                string searchstring = bookIdField.Text;
                string lcn = libcardnoField.Text;
                string bid = bookIdField.Text;
                string bname = bookNameField.Text;
                string extend = extendDate.Text;
                books b = new books();
                b.search = searchstring;


                StreamReader issue_read = new StreamReader(issuepath);
                StreamReader circ_read = new StreamReader(circpath);
                string thisline;
                string currentline;
                bool circ_found = false;
                bool issue_found = false;

                do
                {
                    thisline = issue_read.ReadLine();
                    if (thisline != null)
                    {
                        issue_found = thisline.Contains(b.search);

                    }
                } while (thisline != null && !issue_found);





                do
                {
                    currentline = circ_read.ReadLine();
                    if (currentline.Contains("ISSUE"))
                    {
                        circ_found = thisline.Contains(b.search);

                    }
                } while (currentline != null && !circ_found);

                circ_read.Close();
                issue_read.Close();





                if (circ_found)
                {
                    string[] res = thisline.Split('|');
                    string returndate = res[7];

                    string str1 = File.ReadAllText(circpath);
                    string value = str1.Replace(returndate, extend);
                    File.WriteAllText(circpath, value);
                }

                if (issue_found)
                {


                    string[] res = thisline.Split('|');

                    string issuedate = res[6];
                    string returndate = res[7];
                    string extenddate = extendDate.Text;

                    DateTime id = Convert.ToDateTime(issuedate);
                    DateTime rd = Convert.ToDateTime(returndate);
                    DateTime ed = extendDate.Value.Date;

                    if (DateTime.Compare(rd, ed) < 0)
                    {

                        string str = File.ReadAllText(issuepath);
                        string values = str.Replace(returndate, extenddate);
                        File.WriteAllText(issuepath, values);
                        MessageBox.Show("SUCCESSFULLY EXTENDED");
                        libcardnoField.Clear();
                        bookIdField.Clear();
                        bookNameField.Clear();
                        issuedateField.Clear();
                        returndateField.Clear();
                    }
                    else
                    {
                        MessageBox.Show("EXTENDED DATE IS THE SAME OR RETURN DATE IS GREATER", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }



            }
            else
            {
                MessageBox.Show("NO FIELDS SHOULD BE LEFT BLANK", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

    

        private void bookIdField_Leave(object sender, EventArgs e)
        {
            if (bookIdField.Text.Trim() != string.Empty)
            {
                string issuepath = @"C:\projects\book_zoned\Database\issued.txt";
                string searchstring = bookIdField.Text;
                books b = new books();
                b.search = searchstring;
                string currentLine;
                string currentLine2;
                bool foundText = false;
                bool foundText2 = false;

                StreamReader sr = new StreamReader(issuepath);

                //    int count;

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
                    string name = result[5];
                    bookNameField.Text = name;
                }
                else
                {
                    MessageBox.Show("WRONG BOOK ID NUMBER", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                sr.Close();


                using (StreamReader sr2 = new StreamReader(issuepath))
                {
                    do
                    {
                        currentLine2 = sr2.ReadLine();
                        if (currentLine2 != null)
                        {
                            foundText2 = currentLine2.Contains(b.search);
                        }
                    } while (currentLine2 != null && !foundText2);


                    if (foundText2)
                    {

                        string[] result = currentLine2.Split('|');
                        string issuedate = result[6];
                        string returndate = result[7];

                        issuedateField.Text = issuedate;
                        returndateField.Text = returndate;

                    }
                } 
            }
        }

        private void libcardnoField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
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
