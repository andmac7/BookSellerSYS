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
    public partial class DialogNewAd : Form
    {
        public DialogNewAd()
        {
            InitializeComponent();
        }

        private void createAdButtonCreateAd_Click(object sender, EventArgs e)
        {

            //Stänger fönster
            this.Close();
        }

        private void createAdButtonCancel_Click(object sender, EventArgs e)
        {
            //Stänger fönster
            this.Close();
        }
    }
}
