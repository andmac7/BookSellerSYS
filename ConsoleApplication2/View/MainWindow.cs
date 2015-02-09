using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;
using BookSeller;
using ConsoleApplication2.View;

namespace ConsoleApplication2
{
    public partial class MainWindow : Form
    {
        private DataGridView dataGridView = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private Controller ctrl = new Controller();

        public MainWindow()
        {
            InitializeComponent();
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new MainWindow());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            string cm = "Select * From BookAd";
            bookListDataGridView.DataSource = BookAdDb.Read(cm);*/
            //bookListBox.Items.AddRange(ctrl.getAllBookAds().ToArray());
            /*
            List<BookAd> l = ctrl.getAllBookAds();
            for (int i = 0; i < l.Count; i++)
            {
                bookListBox.Items.Add(l);
            }*/
            //bookListBox.DataSource = l;
            //bookListBox.ValueMember = "Isbn";
            DataTable dt = new DataTable();
            dt = ctrl.getDataTableBookAds();
            DataRow tempRow = null;
            foreach (DataRow tempRowVar in dt.Rows)
            {
                tempRow = tempRowVar;
                bookListBox.Items.Add(tempRow["Title"] + "       |       " + tempRow["Author"] + "       |       " + tempRow["Price"] + "       |       " + tempRow["Date"]);
            }
        }

        private void userAcButtonLogin_Click(object sender, EventArgs e)
        {
            string username = userAcTextBoxMail.Text;
            string password = userAcTextBoxPassw.Text;

            Seller tmpSeller = new Seller();
            tmpSeller = ctrl.getSeller(username);


            //Rätt användarnamn men fel lösenord
            if (tmpSeller.mail == username && tmpSeller.password != password)
            {
                userAcLabelMessageBox.ForeColor = System.Drawing.Color.Red; //Röd färg för negativ feedback
                userAcLabelMessageBox.Text = "Wrong Password";
            }

            //Rätt användarnamn och lösenord
            else if(tmpSeller.mail == username && tmpSeller.password == password)
            {
                                               
                userAcLabelMessageBox.ForeColor = System.Drawing.Color.Green; //Grön färg för positiv feedback
                userAcLabelMessageBox.Text = "ACCESS GRANTED";
                                
            //Textrutor visas
            userAcTextBoxFname.Visible = true;
            userAcTextBoxLname.Visible = true; 
            userAcTextBoxPnbr.Visible = true;
            userAcTextBoxCity.Visible = true;
            
            //Labels visas
            userAcLabelFname.Visible = true;
            userAcLabelLname.Visible = true;
            userAcLabelPnbr.Visible = true;
            userAcLabelCity.Visible = true;
           
            //Knappar och annat visas
            userAcButtonUpdateInfo.Visible = true;
            userAcButtonRemoveAc.Visible = true;
            userAcLabelAds.Visible = true;
            userAcFlowLayoutPanel.Visible = true;
            userAcButtonCreateAd.Visible = true;
            userAcButtonRemoveAd.Visible = true;
            userAcButtonRefresh.Visible = true;
            userAcButtonLogout.Visible = true;
            userAcButtonCreateUsr.Visible = false;
            userAcButtonLogin.Visible = false;

            //Textrutor fylls i med tmpSellers uppgifter
            userAcTextBoxFname.Text = tmpSeller.fName;
            userAcTextBoxLname.Text = tmpSeller.lName;
            userAcTextBoxPnbr.Text = tmpSeller.phoneNbr;
            userAcTextBoxCity.Text = tmpSeller.city;
            }
            
            //Användarnamn finns inte
            else
            {
                userAcLabelMessageBox.ForeColor = System.Drawing.Color.Red; //Röd färg för negativ feedback
                userAcLabelMessageBox.Text = "User does not exist";
            }
        }

        private void userAcButtonLogout_Click(object sender, EventArgs e)
        {
        }

        private void userAcButtonCreateUsr_Click(object sender, EventArgs e)
        {
            DialogRegister dialogRegister = new DialogRegister();
            dialogRegister.ShowDialog();
        }

        private void userAcButtonCreateAd_Click(object sender, EventArgs e)
        {
            DialogNewAd dialogNewAd = new DialogNewAd();
            dialogNewAd.ShowDialog();
        }

        private void bookListBox_DoubleClick(object sender, EventArgs e)
        {
            /*
            if (bookListBox.SelectedItem != null)
            {
                viewAdTextBoxTitle.Text = bookListBox.Items[0].ToString();
                viewAdTextBoxAuthor.Text = bookListBox.Items[1].ToString();
                viewAdTextBoxIsbn.Text = bookListBox.Items[2].ToString();
            }*/

            foreach (var item in bookListBox.SelectedItems)
            {
                MessageBox.Show(item.ToString());
                viewAdTextBoxTitle.Text = item.ToString();
            }
        }

        private void viewAdTextBoxTitle_TextChanged(object sender, EventArgs e)
        {
        }

        private void userActabPage_Click(object sender, EventArgs e)
        {
        }

        private void bookListBtnLogin_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(userActabPage);
        }
    }
}
