using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectMoney
{
    public class Gain
    {
        public int money { get; set; }
        public DateTime time { get; set; } // 12.12.2004
        public string from { get; set; }
        public Gain(DateTime time, int money,  string from)
        {
            this.money = money;
            this.time = time;
            this.from = from;
        }
        public override string ToString()
        {
            return time.ToShortDateString() + "   " + money + " rub   " + from;
        }
    }
}
