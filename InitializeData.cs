using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace projectMoney
{
    public interface InitializeData
    {
        List<Gain> GetGains();
        List<Expenses> GetExpenses();
    }
    public class SQLiteDB : InitializeData
    {
        public List<Gain> gains;
        public List<Expenses> expenses;
       
        SQLiteConnection con = new SQLiteConnection("Data Source=db.db");
        public SQLiteDB()
        {
            gains = new List<Gain>();
            expenses = new List<Expenses>();
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText = "create table if not exists gains (date_gain date, money int, about varchar(50));";
            cmd.ExecuteScalar();
            cmd.CommandText = "create table if not exists expenses (date_expense date, money int, about varchar(50))";
            cmd.ExecuteScalar();
            cmd.CommandText = "select * from gains";
            
            using (var rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    gains.Add(new Gain(DateTime.ParseExact(rd.GetString(0), "yyyy-MM-dd", null), rd.GetInt32(1), rd.GetString(2)));
                }
            }
            cmd.CommandText = "select * from expenses";
            using (var rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    expenses.Add(new Expenses(DateTime.ParseExact(rd.GetString(0), "yyyy-MM-dd", null), rd.GetInt32(1), rd.GetString(2)));
                }
            }
            con.Close();
            
            
        }
        public List<Gain> GetGains() { return gains; }
        public List<Expenses> GetExpenses() { return expenses; }
        public void CommitGain(Gain gain)
        {
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = $"insert into gains(date_gain, money, about)" +
                $" values('{gain.time.ToString("yyyy-MM-dd")}', {gain.money}, '{gain.from}')";
            cmd.ExecuteScalar();
            con.Close();

        }
        public void CommitExp(Expenses exp)
        {
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText = $"insert into expenses(date_expense, money, about)" +
                $" values('{exp.time.ToString("yyyy-MM-dd")}', {exp.money}, '{exp.purchase}')";
            cmd.ExecuteScalar();
            con.Close();


        }

    }
}
