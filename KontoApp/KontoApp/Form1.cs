using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP;

namespace KontoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_CreateAccount_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            AddAccount addAccount = new AddAccount();
            addAccount.Visible = true;
            addAccount.Show();
            
        }
    }
}
