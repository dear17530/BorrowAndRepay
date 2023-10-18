using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowAndRepay
{
    internal class Person
    {
        public string Name;
        public int Money;
        public int Liability;
        public int BorrowAmount;
        public int RepayAmount;

        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
        }

        public void Borrow(Person P,int money)
        {
            if(P.Money >= money)
            {
                P.Money -= money;
                this.Money += money;
                if (P.Liability == 0) this.Liability += money;
                if (P.Liability > 0) P.Liability -= money;
            } else
            {
                MessageBox.Show(P.Name + "的錢不夠哦");
            }
        }

        public void Repay(Person P, int money)
        {
            if (this.Money >= money)
            {
                P.Money += money;
                this.Money -= money;
                if (this.Liability > 0) this.Liability -= money;
            }
            else
            {
                MessageBox.Show(this.Name + "的錢不夠哦");
            }

        }
    }
}
