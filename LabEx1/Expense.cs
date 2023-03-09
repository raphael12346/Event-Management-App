using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx1
{
    public class Expense
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        public Expense(string name, decimal amount, string description)
        {
            this.Name = name;
            this.Amount = amount;
            this.Description = description;
        }
    }
}
