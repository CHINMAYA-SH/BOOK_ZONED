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
    public partial class issue : Form
    {

        public DateTime date;
        public issue()
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
            if (nameField.Text.Trim() != string.Empty && libcardnoField.Text.Trim() != string.Empty && bookIdField.Text.Trim() != string.Empty && bookNameField.Text.Trim() != string.Empty && issueDateField.Text.Trim() != string.Empty)
            {
                books b = new books();
                members m = new members();
                circulation c = new circulation();
                string memberpath = @"C:\projects\book_zoned\Database\members.txt";
                string bookpath = @"C:\projects\book_zoned\Database\books.txt";
                string circpath = @"C:\projects\book_zoned\Database\circulation.txt";
                string issuepath = @"C:\projects\book_zoned\Database\issued.txt";

                var lines = File.ReadAllLines(bookpath).Where(arg => !string.IsNullOrWhiteSpace(arg));
                File.WriteAllLines(bookpath, lines);

                if (!File.Exists(circpath))
                {
                    File.Create(circpath).Close();
                }
             
         


                m.name = nameField.Text;
                m.lcn = libcardnoField.Text;
                b.bookid = bookIdField.Text;
                b.bookname = bookNameField.Text;
                c.iss = issueDateField.Text;
                c.rtn = returnDateField.Text;

                using (StreamReader member_read = new StreamReader(memberpath)) // using1
                {
                    string findlib = libcardnoField.Text;
                    string findname = nameField.Text;

                    bool foundText = false;
                    bool foundLib = false;
                    bool foundname = false;

                   
                    string thisline;

                    // find library card number

                    do
                    {
                        thisline = member_read.ReadLine();
                        if (thisline != null)
                        {
                            foundLib = thisline.Contains(findlib);
                        }
                    } while (thisline != null && !foundLib);                 


                    if (foundLib) 
                    {

                        do
                        {
                            if (thisline != null)
                            {
                                foundname = thisline.Contains(findname);
                            }
                        } while (thisline != null && !foundname);

                        if (foundname)
                        {
                            using (StreamReader book_read = new StreamReader(bookpath)) //using2
                            {
                                string searchString = bookIdField.Text;
                                b.search = searchString;
                                string currentLine;
                                //    int count;

                                do
                                {
                                    currentLine = book_read.ReadLine();
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



                                    if (int.Parse(counter) >= 1)
                                    {
                                        List<string> circ_line = File.ReadAllLines(circpath).ToList();
                                        string circ_created = "| ISSUE | " + m.name + " | " + m.lcn + " | " + b.bookid + " | " + b.bookname + " |  " + c.iss + " | " + c.rtn + " | ";
                                        circ_line.Add(circ_created);
                                        File.WriteAllLines(circpath, circ_line);
                                        MessageBox.Show("CONFIRM THE ORDER ONCE");


                                        // inserting book details 

                                        string searchstring = bookIdField.Text;
                                        b.search = searchstring;

                                        using (StreamReader read2 = new StreamReader(bookpath))
                                        {
                                            bool found = false;
                                            string current;
                                            int count2;


                                            do
                                            {
                                                current = read2.ReadLine();
                                                if (current != null)
                                                {
                                                    found = current.Contains(b.search);
                                                }
                                            } while (current != null && !found);


                                            if (found)
                                            {
                                                string[] result2 = currentLine.Split('|');
                                                string bookid2 = result2[1];
                                                string bookname2 = result2[2];
                                                string author2 = result2[3];
                                                string publication2 = result2[4];
                                                string costprice2 = result2[5];
                                                string counter2 = result2[6];
                                                int count3;

                                                count2 = int.Parse(counter2);
                                                count3 = count2 - 1;
                                                result[6] = count3.ToString();

                                                read2.Close();

                                                string insert2 = "| " + bookid2 + " | " + bookname2 + " | " + author2 + " | " + publication2 + " | " + costprice2 + " | " + result[6] + " | ";

                                                hideBox.Text = insert2;
                                                

                                                List<string> issue_line = File.ReadAllLines(issuepath).ToList();
                                                string issue_created = "| ISSUE | " + m.name + " | " + m.lcn + " | " + b.bookid + " | " + b.bookname + " |  " + c.iss + " | " + c.rtn + " |";
                                                issue_line.Add(issue_created);
                                                File.WriteAllLines(issuepath, issue_line);

                                                dataBox.Text = issue_created;

                                            }

                                        }     // end of    if (found)

                                        //end of entering book details
                                        
                                    }  // end of if (int.Parse(counter) >= 1)


                                    else
                                    {
                                        MessageBox.Show("NO BOOKS AVAILABLE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }    //end if(foundtext)


                                else
                                {
                                    MessageBox.Show("BOOK DOES NOT EXIST", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                               
                                } //else


                            } // end of using (StreamReader sr = new StreamReader(bookpath))

                        } //if for name
                        else
                        {
                            MessageBox.Show("NAME DOESNT EXIST", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("LIBRARY CARD DOESNT EXIST", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }

                }// end of  using (StreamReader member_read = new StreamReader(memberpath))

            } // string validation
            else
            {
                MessageBox.Show("NO FIELDS SHOULD BE LEFT BLANK", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
           

            
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
                }
                sr.Close();
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {

            if (dataBox.Text.Trim() != string.Empty)
            {
                string bookpath = @"C:\projects\book_zoned\Database\books.txt";
                string searchstring = bookIdField.Text;
                books b = new books();
                b.search = searchstring;
                bool foundText = false;

                StreamReader sread4 = new StreamReader(bookpath);
                string currentLine;
             
                do
                {
                    currentLine = sread4.ReadLine();
                    if (currentLine != null)
                    {
                        foundText = currentLine.Contains(b.search);
                    }
                } while (currentLine != null && !foundText);
                sread4.Close();

                if (foundText)
                {
                    MessageBox.Show("success");
                   
                    var oldLines = File.ReadAllLines(bookpath);
                    var newLines = oldLines.Where(line => !line.Contains(b.search));
                    File.WriteAllLines(bookpath, newLines);

                    List<string> book_line = File.ReadAllLines(bookpath).ToList();
                    string write = hideBox.Text.Trim();
                    book_line.Add(write.TrimStart());
                    File.WriteAllLines(bookpath, book_line);
                    MessageBox.Show("UPDATED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var lines = File.ReadAllLines(bookpath).Where(arg => !string.IsNullOrWhiteSpace(arg));
                    File.WriteAllLines(bookpath, lines);

                    dataBox.Clear();
                    nameField.Clear();
                    libcardnoField.Clear();
                    bookIdField.Clear();
                    bookNameField.Clear();

                }
                else
                {
                    MessageBox.Show("not found", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("NO FIELDS SHOULD BE LEFT BLANK", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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

