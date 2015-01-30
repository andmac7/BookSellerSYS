namespace ConsoleApplication2.View
{
    partial class DialogRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookListPictureTree = new System.Windows.Forms.PictureBox();
            this.userAcLabelCity = new System.Windows.Forms.Label();
            this.userAcLabelPnbr = new System.Windows.Forms.Label();
            this.userAcTextBoxCity = new System.Windows.Forms.TextBox();
            this.userAcTextBoxPnbr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListPictureTree)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.userAcLabelCity);
            this.panel1.Controls.Add(this.userAcLabelPnbr);
            this.panel1.Controls.Add(this.userAcTextBoxCity);
            this.panel1.Controls.Add(this.userAcTextBoxPnbr);
            this.panel1.Controls.Add(this.bookListPictureTree);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 537);
            this.panel1.TabIndex = 0;
            // 
            // bookListPictureTree
            // 
            this.bookListPictureTree.Image = global::ConsoleApplication2.Properties.Resources.LogoTree;
            this.bookListPictureTree.Location = new System.Drawing.Point(577, 3);
            this.bookListPictureTree.Name = "bookListPictureTree";
            this.bookListPictureTree.Size = new System.Drawing.Size(100, 75);
            this.bookListPictureTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookListPictureTree.TabIndex = 77;
            this.bookListPictureTree.TabStop = false;
            // 
            // userAcLabelCity
            // 
            this.userAcLabelCity.AutoSize = true;
            this.userAcLabelCity.Location = new System.Drawing.Point(134, 253);
            this.userAcLabelCity.Name = "userAcLabelCity";
            this.userAcLabelCity.Size = new System.Drawing.Size(27, 13);
            this.userAcLabelCity.TabIndex = 81;
            this.userAcLabelCity.Text = "City:";
            this.userAcLabelCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userAcLabelPnbr
            // 
            this.userAcLabelPnbr.AutoSize = true;
            this.userAcLabelPnbr.Location = new System.Drawing.Point(82, 227);
            this.userAcLabelPnbr.Name = "userAcLabelPnbr";
            this.userAcLabelPnbr.Size = new System.Drawing.Size(79, 13);
            this.userAcLabelPnbr.TabIndex = 80;
            this.userAcLabelPnbr.Text = "Phone number:";
            this.userAcLabelPnbr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userAcTextBoxCity
            // 
            this.userAcTextBoxCity.Location = new System.Drawing.Point(167, 250);
            this.userAcTextBoxCity.Name = "userAcTextBoxCity";
            this.userAcTextBoxCity.Size = new System.Drawing.Size(354, 20);
            this.userAcTextBoxCity.TabIndex = 79;
            // 
            // userAcTextBoxPnbr
            // 
            this.userAcTextBoxPnbr.Location = new System.Drawing.Point(167, 224);
            this.userAcTextBoxPnbr.Name = "userAcTextBoxPnbr";
            this.userAcTextBoxPnbr.Size = new System.Drawing.Size(354, 20);
            this.userAcTextBoxPnbr.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Last name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "First name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 20);
            this.textBox1.TabIndex = 83;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(167, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(354, 20);
            this.textBox2.TabIndex = 82;
            // 
            // DialogRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.panel1);
            this.Name = "DialogRegister";
            this.Text = "BookAd - Register New User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListPictureTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox bookListPictureTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label userAcLabelCity;
        private System.Windows.Forms.Label userAcLabelPnbr;
        private System.Windows.Forms.TextBox userAcTextBoxCity;
        private System.Windows.Forms.TextBox userAcTextBoxPnbr;
    }
}