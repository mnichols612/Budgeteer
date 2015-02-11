using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;

namespace Logic
{
    public static class Database
    {
        public static void SetupSQLite()
        {
            SQLite.CreateDatabase();
            SQLite.CreateTables();
        }

        public static List<string> RetrieveBudgets()
        {
            List<string> budgets = new List<string>();
            SQLite.RetrieveBudgets(budgets);
            return budgets;
        }

        public static void SaveBudget(string name, double total, string items, string amounts)
        {
            SQLite.AddBudget(name, total, items, amounts);
        }

        public static void LoadBudget(string name)
        {
            Budget.BudgetItemsList.Clear();
            SQLite.GetBudget(name);
        }

        public static void DeleteBudget(string name)
        {
            SQLite.DeleteBudget(name);
        }
    }
}
