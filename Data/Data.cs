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
            string createBudgetsTable = "create table if not exists Budgets(Name text, Total double, Items text, Amounts text)";
            SQLiteCommand create = new SQLiteCommand(createBudgetsTable, connection);
            create.ExecuteNonQuery();

            string createExpensesTable = "create table if not exists Expenses(Name text, Price double)";
            create = new SQLiteCommand(createExpensesTable, connection);
            create.ExecuteNonQuery();
        }
        #endregion

        #region data manipulation

        public static void AddBudget(string name, double total, string items, string amounts)
        {
            string insert = "insert into Budgets(Name, Total, Items, Amounts) values (" + name + ", " + total + ", " + items + ", " + amounts + ")";
            SQLiteCommand insertRow = new SQLiteCommand(insert, connection);
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

        #endregion
    }
}
