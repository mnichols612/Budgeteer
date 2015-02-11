using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Budgeteer
{
    static class Prompts
    {
        public static string ShowSaveDialog()
        {
            string budgetName = "";

            Form prompt = new Form();
            prompt.Height = 200;
            prompt.Width = 500;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = "Save Budget";
            prompt.StartPosition = FormStartPosition.CenterParent;

            Label lblprompt = new Label()
            {
                Left = 50,
                Top = 40,
                Width = 200,
                Text = "Please name your budget"
            };

            TextBox txtName = new TextBox()
            {
                Left = 50,
                Top = 70,
                Width = 400
            };

            Button btnAccept = new Button()
            {
                Left = 200,
                Top = 100,
                Width = 100,
                Text = "Save"
            };

            //looked up how to do this. Don't understand why this works but
            //btnAccept_Click(object sender, EventArgs e) {...} (like a normal button click event handler)
            //does not
            btnAccept.Click += (sender, e) =>
                {
                    budgetName = txtName.Text;
                    prompt.Close();
                };

            prompt.Controls.Add(lblprompt);
            prompt.Controls.Add(txtName);
            prompt.Controls.Add(btnAccept);
            prompt.AcceptButton = btnAccept;
            prompt.ShowDialog();

            return budgetName;
        }

        public static bool ShowOverwriteDialog()
        {
            bool overwrite = false;

            Form prompt = new Form();
            prompt.Height = 200;
            prompt.Width = 500;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = "Overwrite Budget?";
            prompt.StartPosition = FormStartPosition.CenterParent;

            Label lblprompt = new Label()
            {
                Left = 50,
                Top = 40,
                Width = 200,
                Text = "Do you want to overwrite this budget?"
            };

            Button btnAccept = new Button()
            {
                Left = 200,
                Top = 100,
                Width = 100,
                Text = "Overwrite"
            };

            Button btnCancel = new Button()
            {
                Left = 200,
                Top = 100,
                Width = 100,
                Text = "Cancel"
            };

            btnAccept.Click += (sender, e) =>
            {
                overwrite = true;
                prompt.Close();
            };

            btnCancel.Click += (sender, e) =>
            {
                overwrite = false;
                prompt.Close();
            };

            prompt.Controls.Add(lblprompt);
            prompt.Controls.Add(btnAccept);
            prompt.Controls.Add(btnCancel);
            prompt.AcceptButton = btnAccept;
            prompt.ShowDialog();

            return overwrite;
        }

        public static string ShowDeleteDialog()
        {
            string budgetName = "";

            Form prompt = new Form();
            prompt.Height = 200;
            prompt.Width = 500;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = "Delete Budget";
            prompt.StartPosition = FormStartPosition.CenterParent;

            Label lblprompt = new Label()
            {
                Left = 50,
                Top = 40,
                Width = 200,
                Text = "Please select a budget"
            };

            ComboBox cboDelete = new ComboBox()
            {
                Left = 50,
                Top = 70,
                Width = 400
            };

            Button btnAccept = new Button()
            {
                Left = 200,
                Top = 100,
                Width = 100,
                Text = "Delete"
            };

            Button btnCancel = new Button()
            {
                Left = 200,
                Top = 100,
                Width = 100,
                Text = "Cancel"
            };

            btnAccept.Click += (sender, e) =>
            {
                budgetName = cboDelete.SelectedItem.ToString();
                prompt.Close();
            };

            prompt.Controls.Add(lblprompt);
            prompt.Controls.Add(cboDelete);

            foreach (string budget in Database.RetrieveBudgets())
            {
                cboDelete.Items.Add(budget);
            }

            prompt.Controls.Add(btnAccept);
            prompt.Controls.Add(btnCancel);
            prompt.AcceptButton = btnAccept;
            prompt.ShowDialog();

            return budgetName;
        }
    }
}