using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace projectMoney
{


    public partial class MainForm : Form
    {
        string tableName;
        static List<Gain> gains = new List<Gain>();
        static List<Expenses> expenseses = new List<Expenses>();
        SQLiteDB db = new SQLiteDB();

        public MainForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void addGain(Gain gain)
        {
            ListViewItem newitem = new ListViewItem(gain.time.Date.ToShortDateString().ToString());
            newitem.SubItems.Add(gain.money.ToString());
            newitem.SubItems.Add(gain.from.ToString());
            ListView_Data.Items.Add(newitem);  
        }
        public void addExp(Expenses expenses)
        {
            ListViewItem newitem = new ListViewItem(expenses.time.Date.ToShortDateString().ToString());
            newitem.SubItems.Add(expenses.money.ToString());
            newitem.SubItems.Add(expenses.purchase.ToString());
            ListView_Data.Items.Add(newitem);
        }

        public void filtToDateG(List<Gain> list)
        {
            var sortedList = list.OrderBy(g => g.time);
            foreach (var gain in sortedList)
            {
                addGain(gain);
            }
        }
        public void filtToSumG(List<Gain> list)
        {
            var sortedList = list.OrderBy(g => g.money);
            foreach (var gain in sortedList)
            {
                addGain(gain);
            }
        }
        public List<Gain> filtToSumGforTests(List<Gain> list)
        {
            var len = list.Count;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (list[j].money > list[j + 1].money)
                    {
                        var g = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = g;
                    }
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                addGain(list[i]);

            }
            return list;
        }
        private void filtToDateExp(List<Expenses> list)
        {
            var sortedList = list.OrderBy(e => e.time);
            foreach (var expense in sortedList)
            {
                addExp(expense);
            }
        }
        private void filtToSumExp(List<Expenses> list)
        {
            var sortedList = list.OrderBy(e => e.money);
            foreach (var expense in sortedList)
            {
                addExp(expense);
            }
        }

        public void SearchAndFillListViewG(string date, string sum, string description, List<Gain> gains, ListView listView)
        {
            var query = gains.AsEnumerable();

            if (!string.IsNullOrEmpty(date) && string.IsNullOrEmpty(sum) && string.IsNullOrEmpty(description))
            {
                query = query.Where(g => g.time == DateTime.Parse(date));
            }

            if (string.IsNullOrEmpty(date) && !string.IsNullOrEmpty(sum) && string.IsNullOrEmpty(description))
            {
                decimal sumValue = decimal.Parse(sum);
                query = query.Where(g => g.money == sumValue);
            }

            if (string.IsNullOrEmpty(date) && string.IsNullOrEmpty(sum) && !string.IsNullOrEmpty(description))
            {
                query = query.Where(g => g.from.Contains(description));
            }

            listView.Items.Clear();
            foreach (var gain in query)
            {
                listView.Items.Add(new ListViewItem(new[] { gain.time.ToString(), gain.money.ToString(), gain.from }));
            }
        }
        public void SearchAndFillListViewExp(string date, string sum, string description, List<Expenses> exp, ListView listView)
        {
            var query = exp.AsEnumerable();

            if (!string.IsNullOrEmpty(date) && string.IsNullOrEmpty(sum) && string.IsNullOrEmpty(description))
            {
                query = query.Where(e => e.time == DateTime.Parse(date));
            }

            if (string.IsNullOrEmpty(date) && !string.IsNullOrEmpty(sum) && string.IsNullOrEmpty(description))
            {
                decimal sumValue = decimal.Parse(sum);
                query = query.Where(e => e.money == sumValue);
            }

            if (string.IsNullOrEmpty(date) && string.IsNullOrEmpty(sum) && !string.IsNullOrEmpty(description))
            {
                query = query.Where(e => e.purchase.Contains(description));
            }

            listView.Items.Clear();
            foreach (var expenses in query)
            {
                listView.Items.Add(new ListViewItem(new[] { expenses.time.ToString(), expenses.money.ToString(), expenses.purchase }));
            }
        }

        private void BT_stat_Click(object sender, EventArgs e)
        {
            StatForm form = new StatForm();
            form.Show();
            
        }

        private void buttonLoadData_OnClick(object sender, EventArgs e)
        {
            if (CB_ListOfTables.Text == "Доходы")
            {
                ListView_Data.Clear();
                ListView_Data.Columns.Clear();
                gains = db.GetGains();
                ListView_Data.Columns.Add("Дата", 80);
                ListView_Data.Columns.Add("Сумма", 110);
                ListView_Data.Columns.Add("Откуда", 210);
                for (int i = 0; i < gains.Count; i++) { addGain(gains[i]); }
                tableName = "gains";

            }
            else if (CB_ListOfTables.Text == "Расходы")
            {
                ListView_Data.Clear();
                ListView_Data.Columns.Clear();
                expenseses = db.GetExpenses();
                ListView_Data.Columns.Add("Дата", 80);
                ListView_Data.Columns.Add("Сумма", 110);
                ListView_Data.Columns.Add("На что", 210);
                for (int i = 0; i < expenseses.Count; i++) { addExp(expenseses[i]); }
                tableName = "expenses";
            }

        }

        private void buttonNewRecord_Click(object sender, EventArgs e)
        {
            if (tableName == "gains")
            {
                Gain gain = new Gain(DateTime.ParseExact(TB_Date.Text, "dd.MM.yyyy", null), int.Parse(TB_sum.Text), TB_about.Text);
                gains.Add(gain);
                db.CommitGain(gain);
                addGain(gain);
                TB_Date.Text = "";
                TB_sum.Text = "";
                TB_about.Text = "";
            }
            else if (tableName == "expenses")
            {
                Expenses expenses = new Expenses(DateTime.ParseExact(TB_Date.Text, "dd.MM.yyyy", null), int.Parse(TB_sum.Text), TB_about.Text);
                expenseses.Add(expenses);
                db.CommitExp(expenses);
                addExp(expenses);
                TB_Date.Text = "";
                TB_sum.Text = "";
                TB_about.Text = "";
            }
        }
        public List<Gain> GetGains()
        {
            return gains;
        }
        public List<Expenses> GetExpenses()
        {
            return expenseses;
        }

        private void BT_filt_Click(object sender, EventArgs e)
        {
            if (tableName == "gains")
            {
                gains = db.GetGains();
                if (CB_ListFilters.Text.Equals("По дате"))
                {
                    ListView_Data.Items.Clear();
                    filtToDateG(gains);

                }
                else if (CB_ListFilters.Text.Equals("По сумме"))
                {
                    ListView_Data.Items.Clear();
                    filtToSumG(gains);
                }
            }
            if (tableName == "expenses")
            {
                expenseses = db.GetExpenses();
                if (CB_ListFilters.Text.Equals("По дате"))
                {
                    ListView_Data.Items.Clear();
                    filtToDateExp(expenseses);
                }
                else if (CB_ListFilters.Text.Equals("По сумме"))
                {
                    ListView_Data.Items.Clear();
                    filtToSumExp(expenseses);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string date = TB_Date.Text;
            string sum = TB_sum.Text;
            string description = TB_about.Text;
            if (tableName == "gains")
            {
                var gains = db.GetGains();
                SearchAndFillListViewG(date, sum, description, gains, ListView_Data);
            }
            else if (tableName == "expenses")
            {
                var expenses = db.GetExpenses();
                SearchAndFillListViewExp(date, sum, description, expenses, ListView_Data);
            }
        }
    }
}
