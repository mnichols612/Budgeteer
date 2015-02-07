﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Entities;

namespace Budgeteer
{
    public partial class frmMain : Form
    {
        double total, remaining;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Database.SetupSQLite();
        }

        #region BudgetTab

        private void btnEditTotal_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtTotal.Text, out total))
            {
                MessageBox.Show("Total must be a number with no more than 2 decimal places.");
            }
            else
            {
                RefreshBudgetListView();
            }
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            double percent = -1, amount = 0;
            bool itemAlreadyExists = false;
            string expense;
            expense = txtExpense.Text;

            foreach (BudgetItem item in BudgetItems.BudgetItemsList)
            {
                if (item.Name == expense)
                {
                    MessageBox.Show("An item with that name already exists.");
                    itemAlreadyExists = true;
                }
            }

            if (itemAlreadyExists == false)
            {
                string validationstring = ValidateBudgetTextBoxes();

                if (validationstring != "")
                {
                    string[] split = validationstring.Split(',');

                    amount = Convert.ToDouble(split[1]);
                    percent = Convert.ToDouble(split[2]);

                    if (percent != -1)
                    {
                        amount = total / 100 * percent;
                    }

                    BudgetItem item = new BudgetItem(expense, amount, percent);

                    BudgetItems.BudgetItemsList.Add(item);
                    RefreshBudgetListView();
                }
            }
        }

        private void btnEditExpense_Click(object sender, EventArgs e)
        {
            string validationString = ValidateBudgetTextBoxes();
            bool itemExists = false;

            if (validationString != "")
            {
                string[] split=validationString.Split(',');
                foreach (BudgetItem item in BudgetItems.BudgetItemsList)
                {
                    if (item.Name == split[0])
                    {
                        itemExists = true;

                        item.Price = Convert.ToDouble(split[1]);
                        item.Percent = Convert.ToDouble(split[2]);
                    }
                }

                if (itemExists == false)
                {
                    MessageBox.Show("Item does not exist.");
                }
                RefreshBudgetListView();
            }
        }

        private void btnRemoveExpense_Click(object sender, EventArgs e)
        {
            string name = "";
            if (lvwBudget.SelectedItems.Count > 0)
            {
                name = lvwBudget.SelectedItems[0].Text;
                List<int> removables = new List<int>();

                foreach (BudgetItem expense in BudgetItems.BudgetItemsList)
                {
                    if (expense.Name == name)
                    {
                        removables.Add(BudgetItems.BudgetItemsList.IndexOf(expense));
                    }
                }

                foreach (int i in removables)
                {
                    BudgetItems.BudgetItemsList.RemoveAt(i);
                }

                RefreshBudgetListView();
            }
        }

        private void btnSaveBudget_Click(object sender, EventArgs e)
        {
            string items="", amounts="";
            string budgetName = SaveBudgetPrompt.ShowDialog();

            foreach (BudgetItem item in BudgetItems.BudgetItemsList)
            {
                if (items == "")
                {
                    items += item.Name;
                }
                else
                {
                    items += "," + item.Name;
                }

                if (item.Percent == -1)
                {
                    if (amounts == "")
                    {
                        amounts += item.Price;
                    }
                    else
                    {
                        amounts += "," + item.Price;
                    }
                }
                else
                {
                    if (amounts == "")
                    {
                        amounts += "p" + item.Percent;
                    }
                    else
                    {
                        amounts += ",p" + item.Percent;
                    }
                }
            }

            Database.SaveBudget(budgetName, total,"items","amounts");
            Database.RetrieveBudgets();
        }

        private void btnResetBudget_Click(object sender, EventArgs e)
        {
            total = 0;
            BudgetItems.BudgetItemsList.Clear();
            RefreshBudgetListView();
        }

        private void btnLoadBudget_Click(object sender, EventArgs e)
        {
            foreach (string budget in Database.RetrieveBudgets())
            {
                cboBudgets.Items.Add(budget);
            }
        }

        private void lvwBudget_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearBudgetTextBoxes();

            foreach (BudgetItem expense in BudgetItems.BudgetItemsList)
            {
                if (expense.Name == lvwBudget.SelectedItems[0].Text)
                {
                    txtExpense.Text = expense.Name;
                    txtAmount.Text = expense.Price.ToString();
                    if (expense.Percent != -1)
                    {
                        txtPercent.Text = expense.Percent.ToString();
                    }
                }
            }
        }

        private void ClearBudgetTextBoxes()
        {
            txtExpense.Clear();
            txtAmount.Clear();
            txtPercent.Clear();
        }

        private string ValidateBudgetTextBoxes()
        {
            double amount=0, percent=-1;

            if (txtExpense.Text == "")
            {
                MessageBox.Show("Please enter a name for the expense.");
                return "";
            }
            else if (txtAmount.Text == "" && txtPercent.Text == "")
            {
                MessageBox.Show("Please enter a valid amount or percent");
                return "";
            }
            else if (txtAmount.Text != "" && !double.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Amount must be a number.");
                return "";
            }
            else if (txtPercent.Text != "" && !double.TryParse(txtPercent.Text, out percent))
            {
                MessageBox.Show("Percent must be a number.");
                return "";
            }
            else
            {
                return txtExpense.Text+","+amount.ToString()+","+percent.ToString();
            }
        }

        private void RefreshBudgetListView()
        {
            lvwBudget.Items.Clear();
            remaining = total;
            foreach (BudgetItem expense in BudgetItems.BudgetItemsList)
            {
                if (expense.Percent != -1)
                {
                    expense.Price = total / 100 * expense.Percent;
                }

                ListViewItem lvi = lvwBudget.Items.Add(expense.Name);
                lvi.SubItems.Add(expense.Price.ToString("c"));

                remaining -= expense.Price;

                lvi.SubItems.Add(remaining.ToString("c"));

                if (remaining < 0)
                {
                    lvi.ForeColor = Color.Red;
                }
            }
        }


    }
        #endregion

    #region BudgetHistoryTab

    #endregion

    #region ItemHistoryTab

    #endregion
}