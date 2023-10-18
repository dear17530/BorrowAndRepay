using System;
using System.Windows.Forms;

namespace BorrowAndRepay
{
    public partial class Form1 : Form
    {
        Person I, Friend;
        public Form1()
        {
            InitializeComponent();
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            I.Borrow(Friend, I.BorrowAmount);
            updateMoney();
        }

        private void repayBtn_Click(object sender, EventArgs e)
        {
            I.Repay(Friend, I.RepayAmount);
            updateMoney();
        }

        private void updateMoney()
        {
            myMoneyLabel.Text = I.Money.ToString();
            myLiabilityLabel.Text = I.Liability.ToString();
            friendMoneyLabel.Text = Friend.Money.ToString();
            friendLiabilityLabel.Text = Friend.Liability.ToString();
        }

        private void friendBorrowBtn_Click(object sender, EventArgs e)
        {
            Friend.Borrow(I, Friend.BorrowAmount);
            updateMoney();
        }

        private void friendRepayBtn_Click(object sender, EventArgs e)
        {
            Friend.Repay(I, Friend.RepayAmount);
            updateMoney();
        }

        private void borrowAmount_ValueChanged(object sender, EventArgs e)
        {
            I.BorrowAmount = (int)borrowAmount.Value;
        }

        private void repayAmount_ValueChanged(object sender, EventArgs e)
        {
            I.RepayAmount = (int)repayAmount.Value;
        }

        private void friendBorrowAmount_ValueChanged(object sender, EventArgs e)
        {
            Friend.BorrowAmount = (int)friendBorrowAmount.Value;
        }

        private void friendRepayAmount_ValueChanged(object sender, EventArgs e)
        {
            Friend.RepayAmount = (int)friendRepayAmount.Value;
        }

        private void checkName_Click(object sender, EventArgs e)
        {
            I = new Person(myNameInput.Text, 1000);
            Friend = new Person(friendNameInput.Text, 20000);

            myNameInput.Enabled = false;
            friendNameInput.Enabled = false;
            checkName.Enabled = false;

            borrowBtn.Enabled = true;
            repayBtn.Enabled = true;
            friendBorrowBtn.Enabled = true;
            friendRepayBtn.Enabled = true;

            borrowAmount.Enabled = true;
            repayAmount.Enabled = true;
            friendBorrowAmount.Enabled = true;
            friendRepayAmount.Enabled = true;

            myNameLabel.Text = I.Name;
            friendNameLabel.Text = Friend.Name;

            borrowBtn.Text = "跟" + Friend.Name + "借    " + "$";
            repayBtn.Text = "還給" + Friend.Name + "        " + "$";
            friendBorrowBtn.Text = "跟" + I.Name + "借    " + "$";
            friendRepayBtn.Text = "還給" + I.Name + "        " + "$";
        }
    }
}
