using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class Budget
    {
        public static readonly List<BudgetItem> BudgetItemsList = new List<BudgetItem>();

        public static double total;
    }

    public abstract class Expense
    {
        public Expense()
        { }

        public Expense(string name, double price)
        {
            Name=name;
            Price=price;
        }

        public string Name { get; set; }

        public double Price { get; set; }
    }

    public class BudgetItem:Expense
    {
        public BudgetItem()
        { }

        public BudgetItem(string name, double price, double percent)
            :base(name, price)
        {
            Percent = percent;
        }


        public double Percent { get; set; }
    }
}
