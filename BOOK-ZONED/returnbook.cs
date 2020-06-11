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
    public partial class returnbook : Form
    {
        public returnbook()
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

        public int fineamt;


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
            string circpath = @"C:\projects\book_zoned\Database\circulation.txt";
            string bookpath = @"C:\projects\book_zoned\Database\books.txt";
            string issuepath = @"C:\projects\book_zoned\Database\issued.txt";


            if (libcardnoField.Text.Trim() != string.Empty && bookIdField.Text.Trim() != string.Empty && bookNameField.Text.Trim() != string.Empty && returnDateField.Text.Trim() != string.Empty)
            {
                members m = new members();
                circulation c = new circulation();
                books b = new books();
                string lcn = libcardnoField.Text;
                string mname = nameField.Text;
                string bid = bookIdField.Text;
                string bnm = bookNameField.Text;
                string rtndate = returnDateField.Text;
                m.lcn = lcn;
                m.name = mname;
                b.bookid = bid;
                b.bookname = bnm;
                c.rtndate = rtndate;




                // finding book issued
                StreamReader sread = new StreamReader(issuepath);

                string thisline;
                string lcn1 = libcardnoField.Text;
                m.lcn = lcn1;
                string searchS = m.lcn;
                bool foundText = false;

                do
                {
                    thisline = sread.ReadLine();
                    if (thisline != null)
                    {
                        foundText = thisline.Contains(searchS);
                    }
                }
                while (thisline != null && !foundText);



                if (foundText)
                {

                    string[] result = thisline.Split('|');
                    string issorret = result[1];
                    string name = result[2];
                    string lcn2 = result[3];
                    string bid2 = result[4];
                    string bname = result[5];
                    string issdat = result[6];
                    string retdat = result[7];

                    DateTime isdt = Convert.ToDateTime(issdat);
                    DateTime rndt = Convert.ToDateTime(rtndate);

                    DateTime returnDate = returnDateField.Value.Date;
                    TimeSpan differnce = returnDate - isdt;
                    int days = differnce.Days;
                    if (days > 15)
                    {
                        fineamt = (days - 15) * 1;
                    }


                    sread.Close();


                    List<string> circ_line = File.ReadAllLines(circpath).ToList();
                    string circ_created = "| RETURN | " + m.lcn + " | " + m.name + " | " + b.bookid + " | " + b.bookname + " |  " + c.rtndate + " | ";
                    circ_line.Add(circ_created);
                    File.WriteAllLines(circpath, circ_line);

                    dataBox.Text = circ_created;

                }
                else
                {
                    MessageBox.Show("NO RECORD FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                StreamReader sr = new StreamReader(bookpath);

                string currentLine;
                string searchString = b.bookid;
                bool foundTxt = false;

                do
                {
                    currentLine = sr.ReadLine();
                    if (currentLine != null)
                    {
                        foundTxt = currentLine.Contains(searchString);
                    }
                }
                while (currentLine != null && !foundTxt);

                if (foundTxt)
                {
                    string[] result = currentLine.Split('|');
                    string bookid = result[1];
                    string bookname = result[2];
                    string author = result[3];
                    string publication = result[4];
                    string costprice = result[5];
                    string counter = result[6];


                    int add = int.Parse(counter);
                    int sum = add + 1;

                    result[6] = sum.ToString();

                    // funtion to display fine

                    sr.Close();


                    List<string> book_line = File.ReadAllLines(bookpath).ToList();
                    string book_created = "| " + bookid + "|" + bookname + "|" + author + "|" + publication + "|" + costprice + "|" + result[6] + "|";
                 
                    hideBox.Text = book_created;

                    MessageBox.Show("CONFIRM THE ORDER ONCE");


                    MessageBox.Show("YOU ARE LATE BY " + fineamt + " NUMBER OF DAYS. FINE AMOUNT IS " + fineamt);


                    
                }
            }
            else
            {
                MessageBox.Show("NO BLANK FIELD MUST BE LEFT", "RETRY", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }



        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string bookpath = @"C:\projects\book_zoned\Database\books.txt";
            string issuepath = @"C:\projects\book_zoned\Database\issued.txt";
            string searchstring = bookIdField.Text;
            books b = new books();
            b.search = searchstring;


            StreamReader sread = new StreamReader(issuepath);
 
            string thisline;
            string lcn = libcardnoField.Text;
            members m = new members();
            m.lcn = lcn;
            string searchS = m.lcn;
            bool foundText = false;

            do
            {
                thisline = sread.ReadLine();
                if (thisline != null)
                {
                    foundText = thisline.Contains(searchS);
                }
            }
            while (thisline != null && !foundText);
            sread.Close();

            if (foundText)
            {
               

                var oldLines = File.ReadAllLines(issuepath);
                var newLines = oldLines.Where(line => !line.Contains(b.search));
                File.WriteAllLines(issuepath, newLines);

                var oldLines1 = File.ReadAllLines(bookpath);
                var newLines1 = oldLines1.Where(line => !line.Contains(b.search));
                File.WriteAllLines(bookpath, newLines1);
            }
            

            List<string> book_line = File.ReadAllLines(bookpath).ToList();
            string write = hideBox.Text;
            book_line.Add(write.TrimStart());
            File.WriteAllLines(bookpath, book_line);
            MessageBox.Show("UPDATED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var lines = File.ReadAllLines(bookpath).Where(arg => !string.IsNullOrWhiteSpace(arg));
            File.WriteAllLines(bookpath, lines);

            dataBox.Clear();
        }

        private void libcardnoField_Leave(object sender, EventArgs e)
        {
            if (libcardnoField.Text.Trim() != string.Empty)
            {
                string memberpath = @"C:\projects\book_zoned\Database\members.txt";
                string searchstring = libcardnoField.Text;
                members m = new members();
                m.search = searchstring;


                StreamReader sr = new StreamReader(memberpath);
                string currentLine;
                bool foundText = false;
                //    int count;

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

                    string[] result = currentLine.Split('|');
                    string name = result[1];
                    nameField.Text = name;

                }
                else
                {
                    MessageBox.Show("WRONG LIBRARY CARD NUMBER", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                sr.Close();
            }
        }

        private void bookIdField_Leave(object sender, EventArgs e)
        {
            if (bookIdField.Text.Trim() != string.Empty)
            {
                string bookpath = @"C:\projects\book_zoned\Database\books.txt";
                string searchstring = bookIdField.Text;
                books b = new books();
                b.search = searchstring;


                StreamReader sr = new StreamReader(bookpath);
                string currentLine;
                bool foundText = false;
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
                    string name = result[2];
                    bookNameField.Text = name;
                }
                else
                {
                    MessageBox.Show("WRONG BOOK ID NUMBER", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }sr.Close();
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
