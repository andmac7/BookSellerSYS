using BookSeller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication2.View
{
    public partial class DialogRegister : Form
    {

        private Controller ctrl = new Controller();

        public DialogRegister()
        {
            InitializeComponent();
        }

        private void newUserButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //Cancel knapp stänger fönster
        }

        private void newUserButtonRegister_Click(object sender, EventArgs e)
        {

            String LName = newUserTextBoxLname.Text;
            String FName = newUserTextBoxFname.Text;
            String PhoneNbr = newUserTextBoxPnbr.Text;
            String Mail = newUserTextBoxMail.Text;
            String City = newUserTextBoxCity.Text;
            String Password = newUserTextBoxPassw.Text;  

            ctrl.addSeller(LName, FName, PhoneNbr, Mail, City, Password); //Skickar inmatning från textrutorna till controller

        }
    }
}
