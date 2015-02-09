using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookSeller;

namespace ConsoleApplication2.View
{
    public partial class DialogNewAd : Form
    {
        Controller ctrl = new Controller();
        public Seller user = new Seller();
        
        public DialogNewAd()
        {
            InitializeComponent();
        }

        private void createAdButtonCreateAd_Click(object sender, EventArgs e)
        {
            string title = createAdTextBoxTitle.Text;
            string author = createAdTextBoxAuthor.Text;
            string isbn = createAdTextBoxIsbn.Text;
            int price = int.Parse(createAdTextBoxPrice.Text);
            string date = System.DateTime.Today.ToShortDateString();
            string adtext = createAdTextBoxText.Text;
            string course = "SYSA11";
            string mail = createAdTextBoxMail.Text;
            
            ctrl.addBookAd(title, author, isbn, date, price, adtext, course, mail);
            //Stänger fönster
            this.Close();
        }

        private void createAdButtonCancel_Click(object sender, EventArgs e)
        {
            //Stänger fönster
            this.Close();
        }

        private void DialogNewAd_Load(object sender, EventArgs e)
        {
            createAdTextBoxMail.Text = user.mail;
            createAdTextBoxPnbr.Text = user.phoneNbr;
            createAdTextBoxCity.Text = user.city;
            createAdTextBoxSeller.Text = String.Format("{0} {1}", user.fName, user.lName);
            createAdTextBoxDate.Text = System.DateTime.Today.ToShortDateString();
        }

        private void createAdButtonAnotherAd_Click(object sender, EventArgs e)
        {
            string title = createAdTextBoxTitle.Text;
            string author = createAdTextBoxAuthor.Text;
            string isbn = createAdTextBoxIsbn.Text;
            int price = int.Parse(createAdTextBoxPrice.Text);
            string date = System.DateTime.Today.ToShortDateString();
            string adtext = createAdTextBoxText.Text;
            string course = "SYSA11";
            string mail = createAdTextBoxMail.Text;
            ctrl.addBookAd(title, author, isbn, date, price, adtext, course, mail);
            this.Close();
        }
    }
}
