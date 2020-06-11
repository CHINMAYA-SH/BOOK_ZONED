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


struct login
{
    public string username;
    public string password;
}
struct books
{
    public string bookid;
    public string bookname;
    public string author;
    public string publication;
    public string costprice;

    public string search;

}
struct members
{
    public string name;
    public string lcn;
    public string dob;
    public string age;
    public string address;
    public string uid;
    public string phno;
    public string eid;

    public string oa;
    public string na;

    public string op;
    public string np;

    public string oe;
    public string ne;

    public string search;
}
struct circulation
{
    public string iss;
    public string rtn;
    public string rtndate;

}

namespace BOOK_ZONED
{
    public partial class a_mainpage : Form
    {
        public a_mainpage()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string memberpath = @"C:\projects\book_zoned\Database\members.txt";
            string bookpath = @"C:\projects\book_zoned\Database\books.txt";
            string circpath = @"C:\projects\book_zoned\Database\circulation.txt";
            string issuepath = @"C:\projects\book_zoned\Database\issued.txt";

            if(!File.Exists(memberpath))
            {
                File.Create(memberpath).Close() ;
            }
            if (!File.Exists(bookpath))
            {
                File.Create(bookpath).Close();
            }
            if (!File.Exists(circpath))
            {
                File.Create(circpath).Close();
            }
            if (!File.Exists(issuepath))
            {
                File.Create(issuepath).Close();
            }


            if (usernameField.Text.Trim() != string.Empty && passwordField.Text.Trim() != string.Empty)
            {
                login l = new login();
                string user = usernameField.Text;
                string pass = passwordField.Text;
                l.username = usernameField.Text;
                l.password = passwordField.Text;

                if (user.Contains("ewitise") && pass.Contains("ewitise"))
                {
                    a_welcome wc = new a_welcome();
                    wc.Show();
                    this.Hide();
                    MessageBox.Show("LOGGED IN SUCCESSFULLY", "logged in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("INCORRECT USERNAME OR PASSWORD", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("NO BLANK FIELD MUST BE LEFT", "RETRY", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
