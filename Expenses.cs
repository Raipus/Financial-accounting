using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectMoney
{
    public class Expenses
    {
        public int money { get; set; }
        public DateTime time { get; set; }
        public string purchase { get; set; }

        public Expenses(DateTime time,  int money,  string purchase)
        {
            this.money = money;
            this.time = time;
            this.purchase = purchase;
        }
        public override string ToString()
        {
            return time + "   " + money + "   " + purchase;
        }
    }
}
