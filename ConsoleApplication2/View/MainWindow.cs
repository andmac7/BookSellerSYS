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
        private Seller user = new Seller();

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
            //listBox1.Items.AddRange(ctrl.getAllBookAds().ToArray());
            /*
            List<BookAd> l = ctrl.getAllBookAds();
            for (int i = 0; i < l.Count; i++)
            {
                listBox1.Items.Add(l);
            }*/
            //listBox1.DataSource = l;
            //listBox1.ValueMember = "Isbn";
            /*DataTable dt = new DataTable();
            dt = ctrl.getDataTableBookAds();
            DataRow tempRow = null;
            foreach (DataRow tempRowVar in dt.Rows)
            {
                tempRow = tempRowVar;
                listBox1.Items.Add(tempRow["Title"] + "       |       " + tempRow["Author"] + "       |       " + tempRow["Price"] + "       |       " + tempRow["Date"]);
            }*/

            List<BookAd> tmpList = ctrl.getAllBookAds();
            foreach(BookAd tmpBookAd in tmpList)
            {
                ListViewItem tmpLwi = new ListViewItem("Title");
                tmpLwi.SubItems.Add("Author");
                tmpLwi.SubItems.Add("Price");
                tmpLwi.SubItems.Add("Comment");
                tmpLwi.SubItems[0].Text = tmpBookAd.title;
                tmpLwi.SubItems[1].Text = tmpBookAd.author;
                tmpLwi.SubItems[2].Text = tmpBookAd.price.ToString();
                tmpLwi.SubItems[3].Text = tmpBookAd.adText;
                //tmpLwi.Text = tmpBookAd.title;
                tmpLwi.Tag = tmpBookAd;
                listView1.Items.Add(tmpLwi);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                BookAd book = ctrl.getBookAd(listView1.SelectedItems[0].Text.ToString());
                //List<BookAd> tmpBookAds = ctrl.getAllBookAds();
                //MessageBox.Show(listView1.SelectedItems[0].Text.ToString());
                viewAdTextBoxTitle.Text = book.title;
                viewAdTextBoxAuthor.Text = book.author;
                viewAdTextBoxPrice.Text = book.price.ToString();
                viewAdTextBoxIsbn.Text = book.isbn;
                viewAdTextBoxText.Text = book.adText;
                viewAdTextBoxSeller.Text = String.Format("{0} {1}",ctrl.getSeller(book.mail).fName, ctrl.getSeller(book.mail).lName);
            }
        }

        private void userAcButtonLogin_Click(object sender, EventArgs e)
        {
            string username = userAcTextBoxMail.Text;
            string password = userAcTextBoxPassw.Text;
            
            //Spara användaruppgifter
            user = ctrl.getSeller(username);

            Seller tmpSeller = new Seller();
            tmpSeller = ctrl.getSeller(username);


            //Rätt användarnamn men fel lösenord
            if (tmpSeller.mail == username && tmpSeller.password != password)
            {
                userAcLabelMessageBox.Text = "Wrong Password";
            }

            //Rätt användarnamn och lösenord
            else if(tmpSeller.mail == username && tmpSeller.password == password)
            {
                userAcLabelMessageBox.Text = "";

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

            //Textrutor fylls i med tmpSellers uppgifter
            userAcTextBoxFname.Text = tmpSeller.fName;
            userAcTextBoxLname.Text = tmpSeller.lName;
            userAcTextBoxPnbr.Text = tmpSeller.phoneNbr;
            userAcTextBoxCity.Text = tmpSeller.city;
            }
            //Användarnamn finns inte
            else
            {
                userAcLabelMessageBox.Text = "User does not exist";
            }

        }

        private void userAcButtonCreateUsr_Click(object sender, EventArgs e)
        {
            DialogRegister dialogRegister = new DialogRegister();
            dialogRegister.ShowDialog();
        }

        private void userAcButtonCreateAd_Click(object sender, EventArgs e)
        {
            DialogNewAd dialogNewAd = new DialogNewAd();
            dialogNewAd.user = this.user;
            dialogNewAd.ShowDialog();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            /*
            if (listBox1.SelectedItem != null)
            {
                viewAdTextBoxTitle.Text = listBox1.Items[0].ToString();
                viewAdTextBoxAuthor.Text = listBox1.Items[1].ToString();
                viewAdTextBoxIsbn.Text = listBox1.Items[2].ToString();
            }

            foreach (var item in listBox1.SelectedItems)
            {
                MessageBox.Show(item.ToString());
                viewAdTextBoxTitle.Text = item.ToString();
            }*/

        }

        private void viewAdTextBoxTitle_TextChanged(object sender, EventArgs e)
        {        
        }
    }
}
