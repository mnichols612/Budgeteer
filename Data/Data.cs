using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Entities;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class SQLite
    {
        private static SQLiteConnection connection;
        private static SQLiteDataReader reader;

        #region setup
        public static void CreateDatabase()
        {
            if (!File.Exists("Budgeteer.db"))
            {
                SQLiteConnection.CreateFile("Budgeteer.db");
            }
            SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder();
            connection = new SQLiteConnection("Data Source=Budgeteer.db;version=3;");
        }

        public static void CreateTables()
        {
            connection.Open();
            string createBudgetsTable = "create table if not exists Budgets(Name text, Total double, Items text, Amounts text)";
            SQLiteCommand create = new SQLiteCommand(createBudgetsTable, connection);
            create.ExecuteNonQuery();

            string createExpensesTable = "create table if not exists Expenses(Name text, Price double)";
            create = new SQLiteCommand(createExpensesTable, connection);
            create.ExecuteNonQuery();
            connection.Close();
        }
        #endregion

        #region data manipulation

        public static void AddBudget(string name, double total, string items, string amounts)
        {
            string insert = "insert into Budgets(Name, Total, Items, Amounts) values (\"" + name + "\", " + total + ", \"" + items + "\", \"" + amounts + "\")";

            connection.Open();
            SQLiteCommand insertRow = new SQLiteCommand(insert, connection);

            //claims Budget table does not exist
            insertRow.ExecuteNonQuery(CommandBehavior.CloseConnection);
        }

        public static void DeleteBudget(string name)
        {
            string deleteStatement = "delete from Budgets where Name = \"" + name + "\"";

            SQLiteCommand delete = new SQLiteCommand(deleteStatement, connection);

            connection.Open();
            delete.ExecuteNonQuery();
            connection.Close();
        }
        #endregion

        #region queries

        public static void RetrieveBudgets(List<string> budgets)
        {
            string selectStatement = "select Name from Budgets";

            connection.Open();

            SQLiteCommand retrieve = new SQLiteCommand(selectStatement, connection);
            reader = retrieve.ExecuteReader();

            while (reader.Read())
            {
                budgets.Add(reader["Name"].ToString());
            }
            connection.Close();
        }

        public static void GetBudget(string name)
        {
            BudgetItem item;
            List<string> items = new List<string>(), amounts = new List<string>();
            string selectStatement = "select * from Budgets where Name = \"" + name + "\"";

            connection.Open();

            SQLiteCommand getBudget = new SQLiteCommand(selectStatement, connection);
            reader = getBudget.ExecuteReader();

            while (reader.Read())
            {
                Budget.name = reader["Name"].ToString();
                Budget.total = Convert.ToDouble(reader["Total"]);
                foreach (string i in reader["Items"].ToString().Split(','))
                {
                    items.Add(i);
                }

                foreach (string i in reader["Amounts"].ToString().Split(','))
                {
                    amounts.Add(i);
                }
            }

            connection.Close();

            foreach (string i in items)
            {
                item = new BudgetItem();
                item.Name = i;

                foreach (string a in amounts)
                {
                    if (amounts.IndexOf(a) == items.IndexOf(i))
                    {
                        if (a.Substring(0, 1) == "p")
                        {
                            item.Percent = Convert.ToDouble(a.Substring(1));
                        }
                        else
                        {
                            item.Percent = -1;
                            item.Price = Convert.ToDouble(a);
                        }
                    }
                }

                Budget.BudgetItemsList.Add(item);
            }
        }
        #endregion
    }
}
