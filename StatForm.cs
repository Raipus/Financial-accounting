using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectMoney
{
    public partial class StatForm : Form
    {
        public StatForm()
        {
            InitializeComponent();
            this.chart.Series[0].Points.Clear();
            MainForm form = new MainForm();
            List<Gain> gains = form.GetGains();
            List<Expenses> expenses = form.GetExpenses();
            double x = -10;
            double y = -10;
            gains = filtToDateG(gains);
            expenses = filtToDateExp(expenses);
            for (int i = 0; i < gains.Count; i++)
            {
                y = Convert.ToDouble(gains[i].money);
                x = Convert.ToDouble(gains[i].time.DayOfYear);
                this.chart.Series[1].Points.AddXY(x,y);
            }
            for (int i = 0; i < expenses.Count; i++)
            {
                y = Convert.ToDouble(expenses[i].money);
                x = Convert.ToDouble(expenses[i].time.DayOfYear);
                this.chart.Series[0].Points.AddXY(x, y);
            }


        }
        private List<Gain> filtToDateG(List<Gain> list)
        {
            var len = list.Count;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (list[j].time > list[j + 1].time)
                    {
                        var g = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = g;
                    }
                }
            }

            return list;

        }
        private List<Expenses> filtToDateExp(List<Expenses> list)
        {
            var len = list.Count;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (list[j].time > list[j + 1].time)
                    {
                        var g = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = g;
                    }
                }
            }
            return list;
        }
    }
}
