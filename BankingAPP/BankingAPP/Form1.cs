using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingAPP
{
    public partial class BankAppUI : Form
    {
        public BankAppUI()
        {
            InitializeComponent();
        }

        Account anAccount=new Account();
        private double amount;


        
        private void createButton_Click(object sender, EventArgs e)
        {

            anAccount.name = nameTextBox.Text;
            anAccount.number = numberTextBox.Text;

            //anAccount.Deposit(amount);
            MessageBox.Show(@"Your account has been created:");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTexBox.Text);
            anAccount.Deposit(amount);
            amountTexBox.Text = String.Empty;
            MessageBox.Show(@"Your account has been deposite:");
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTexBox.Text);
            anAccount.Withdraw(amount);
            amountTexBox.Text = String.Empty;
            MessageBox.Show(@"Your account has been withdraw:");
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name"+anAccount.name+" \nYour account number is:" + anAccount.number +"\nYour Current balance is:"+ anAccount.balance);

        }
    }
}
