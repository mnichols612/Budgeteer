namespace Budgeteer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblExpense = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tpBudget = new System.Windows.Forms.TabPage();
            this.btnRemoveExpense = new System.Windows.Forms.Button();
            this.grpExpense = new System.Windows.Forms.GroupBox();
            this.btnEditExpense = new System.Windows.Forms.Button();
            this.lblP = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.lblPercentOfTotal = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.grpTotal = new System.Windows.Forms.GroupBox();
            this.btnEditTotal = new System.Windows.Forms.Button();
            this.lvwBudget = new System.Windows.Forms.ListView();
            this.chExpense = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRemaining = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpBudgetHistory = new System.Windows.Forms.TabPage();
            this.tpItemHistory = new System.Windows.Forms.TabPage();
            this.tcTabs.SuspendLayout();
            this.tpBudget.SuspendLayout();
            this.grpExpense.SuspendLayout();
            this.grpTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(13, 43);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.Location = new System.Drawing.Point(59, 34);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(48, 13);
            this.lblExpense.TabIndex = 0;
            this.lblExpense.Text = "Expense";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(50, 40);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // txtExpense
            // 
            this.txtExpense.Location = new System.Drawing.Point(113, 31);
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.Size = new System.Drawing.Size(100, 20);
            this.txtExpense.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(59, 70);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(113, 67);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // tcTabs
            // 
            this.tcTabs.Controls.Add(this.tpBudget);
            this.tcTabs.Controls.Add(this.tpBudgetHistory);
            this.tcTabs.Controls.Add(this.tpItemHistory);
            this.tcTabs.Location = new System.Drawing.Point(-1, -1);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(804, 598);
            this.tcTabs.TabIndex = 0;
            // 
            // tpBudget
            // 
            this.tpBudget.Controls.Add(this.btnRemoveExpense);
            this.tpBudget.Controls.Add(this.grpExpense);
            this.tpBudget.Controls.Add(this.grpTotal);
            this.tpBudget.Controls.Add(this.lvwBudget);
            this.tpBudget.Location = new System.Drawing.Point(4, 22);
            this.tpBudget.Name = "tpBudget";
            this.tpBudget.Padding = new System.Windows.Forms.Padding(3);
            this.tpBudget.Size = new System.Drawing.Size(796, 572);
            this.tpBudget.TabIndex = 0;
            this.tpBudget.Text = "Budget";
            this.tpBudget.UseVisualStyleBackColor = true;
            // 
            // btnRemoveExpense
            // 
            this.btnRemoveExpense.Location = new System.Drawing.Point(524, 539);
            this.btnRemoveExpense.Name = "btnRemoveExpense";
            this.btnRemoveExpense.Size = new System.Drawing.Size(116, 23);
            this.btnRemoveExpense.TabIndex = 3;
            this.btnRemoveExpense.Text = "Remove Expense";
            this.btnRemoveExpense.UseVisualStyleBackColor = true;
            this.btnRemoveExpense.Click += new System.EventHandler(this.btnRemoveExpense_Click);
            // 
            // grpExpense
            // 
            this.grpExpense.Controls.Add(this.btnEditExpense);
            this.grpExpense.Controls.Add(this.lblP);
            this.grpExpense.Controls.Add(this.txtPercent);
            this.grpExpense.Controls.Add(this.lblPercentOfTotal);
            this.grpExpense.Controls.Add(this.lblOr);
            this.grpExpense.Controls.Add(this.btnAddExpense);
            this.grpExpense.Controls.Add(this.txtExpense);
            this.grpExpense.Controls.Add(this.lblExpense);
            this.grpExpense.Controls.Add(this.lblAmount);
            this.grpExpense.Controls.Add(this.txtAmount);
            this.grpExpense.Location = new System.Drawing.Point(9, 162);
            this.grpExpense.Name = "grpExpense";
            this.grpExpense.Size = new System.Drawing.Size(289, 220);
            this.grpExpense.TabIndex = 1;
            this.grpExpense.TabStop = false;
            this.grpExpense.Text = "Expense";
            // 
            // btnEditExpense
            // 
            this.btnEditExpense.Location = new System.Drawing.Point(145, 173);
            this.btnEditExpense.Name = "btnEditExpense";
            this.btnEditExpense.Size = new System.Drawing.Size(106, 23);
            this.btnEditExpense.TabIndex = 9;
            this.btnEditExpense.Text = "Edit Expense";
            this.btnEditExpense.UseVisualStyleBackColor = true;
            this.btnEditExpense.Click += new System.EventHandler(this.btnEditExpense_Click);
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(160, 134);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(15, 13);
            this.lblP.TabIndex = 7;
            this.lblP.Text = "%";
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(112, 131);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(45, 20);
            this.txtPercent.TabIndex = 6;
            // 
            // lblPercentOfTotal
            // 
            this.lblPercentOfTotal.AutoSize = true;
            this.lblPercentOfTotal.Location = new System.Drawing.Point(62, 134);
            this.lblPercentOfTotal.Name = "lblPercentOfTotal";
            this.lblPercentOfTotal.Size = new System.Drawing.Size(44, 13);
            this.lblPercentOfTotal.TabIndex = 5;
            this.lblPercentOfTotal.Text = "Percent";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(133, 101);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(16, 13);
            this.lblOr.TabIndex = 4;
            this.lblOr.Text = "or";
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(16, 173);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(100, 23);
            this.btnAddExpense.TabIndex = 8;
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // grpTotal
            // 
            this.grpTotal.Controls.Add(this.btnEditTotal);
            this.grpTotal.Controls.Add(this.txtTotal);
            this.grpTotal.Controls.Add(this.lblTotal);
            this.grpTotal.Location = new System.Drawing.Point(9, 30);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Size = new System.Drawing.Size(200, 112);
            this.grpTotal.TabIndex = 0;
            this.grpTotal.TabStop = false;
            this.grpTotal.Text = "Total";
            // 
            // btnEditTotal
            // 
            this.btnEditTotal.Location = new System.Drawing.Point(50, 76);
            this.btnEditTotal.Name = "btnEditTotal";
            this.btnEditTotal.Size = new System.Drawing.Size(100, 23);
            this.btnEditTotal.TabIndex = 2;
            this.btnEditTotal.Text = "Edit Total";
            this.btnEditTotal.UseVisualStyleBackColor = true;
            this.btnEditTotal.Click += new System.EventHandler(this.btnEditTotal_Click);
            // 
            // lvwBudget
            // 
            this.lvwBudget.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chExpense,
            this.chAmount,
            this.chRemaining});
            this.lvwBudget.FullRowSelect = true;
            this.lvwBudget.GridLines = true;
            this.lvwBudget.Location = new System.Drawing.Point(389, 30);
            this.lvwBudget.MultiSelect = false;
            this.lvwBudget.Name = "lvwBudget";
            this.lvwBudget.Size = new System.Drawing.Size(390, 503);
            this.lvwBudget.TabIndex = 2;
            this.lvwBudget.UseCompatibleStateImageBehavior = false;
            this.lvwBudget.View = System.Windows.Forms.View.Details;
            this.lvwBudget.SelectedIndexChanged += new System.EventHandler(this.lvwBudget_SelectedIndexChanged);
            // 
            // chExpense
            // 
            this.chExpense.Text = "Expense";
            this.chExpense.Width = 130;
            // 
            // chAmount
            // 
            this.chAmount.Text = "Amount";
            this.chAmount.Width = 126;
            // 
            // chRemaining
            // 
            this.chRemaining.Text = "Remaining";
            this.chRemaining.Width = 130;
            // 
            // tpBudgetHistory
            // 
            this.tpBudgetHistory.Location = new System.Drawing.Point(4, 22);
            this.tpBudgetHistory.Name = "tpBudgetHistory";
            this.tpBudgetHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tpBudgetHistory.Size = new System.Drawing.Size(796, 572);
            this.tpBudgetHistory.TabIndex = 1;
            this.tpBudgetHistory.Text = "Budget History";
            this.tpBudgetHistory.UseVisualStyleBackColor = true;
            // 
            // tpItemHistory
            // 
            this.tpItemHistory.Location = new System.Drawing.Point(4, 22);
            this.tpItemHistory.Name = "tpItemHistory";
            this.tpItemHistory.Size = new System.Drawing.Size(796, 572);
            this.tpItemHistory.TabIndex = 3;
            this.tpItemHistory.Text = "Item History";
            this.tpItemHistory.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 598);
            this.Controls.Add(this.tcTabs);
            this.Name = "frmMain";
            this.Text = "Budgeteer";
            this.tcTabs.ResumeLayout(false);
            this.tpBudget.ResumeLayout(false);
            this.grpExpense.ResumeLayout(false);
            this.grpExpense.PerformLayout();
            this.grpTotal.ResumeLayout(false);
            this.grpTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.TabPage tpBudget;
        private System.Windows.Forms.TabPage tpBudgetHistory;
        private System.Windows.Forms.GroupBox grpExpense;
        private System.Windows.Forms.Label lblPercentOfTotal;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.GroupBox grpTotal;
        private System.Windows.Forms.Button btnEditTotal;
        private System.Windows.Forms.ListView lvwBudget;
        private System.Windows.Forms.ColumnHeader chExpense;
        private System.Windows.Forms.ColumnHeader chAmount;
        private System.Windows.Forms.ColumnHeader chRemaining;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.TabPage tpItemHistory;
        private System.Windows.Forms.Button btnRemoveExpense;
        private System.Windows.Forms.Button btnEditExpense;
    }
}

