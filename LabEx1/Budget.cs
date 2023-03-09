using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx1
{
    public class Budget
    {
        public decimal TotalBudget { get; set; }
        public List<Expense> Expenses { get; set; }

        public Budget(decimal totalBudget)
        {
            this.TotalBudget = totalBudget;
            this.Expenses = new List<Expense>();
        }

        public void AddExpense(Expense expense)
        {
            this.Expenses.Add(expense);
        }

        public void RemoveExpense(Expense expense)
        {
            this.Expenses.Remove(expense);
        }

        public decimal CalculateTotalExpenses()
        {
            decimal totalExpenses = 0;
            foreach (Expense expense in this.Expenses)
            {
                totalExpenses += expense.Amount;
            }
            return totalExpenses;
        }
    }
}
