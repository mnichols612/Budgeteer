using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgeteer
{
    class SaveBudgetPrompt
    {
        public static string ShowDialog()
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
                Left=50,
                Top=40,
                Width=200,
                Text="Please name your budget"
            };

            TextBox txtName = new TextBox()
            {
                Left=50,
                Top=70,
                Width=400
            };

            Button btnAccept = new Button()
            {
                Left=200,
                Top=100,
                Width=100,
                Text="Save"
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
    }
}
