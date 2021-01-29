using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesManager
{
    class Expences
    {
        public DateTime Date { get; private set; }
        public double Price { get; private set; }

        public string Category { get; private set; }

        public Expences(DateTime Date, double Price,string Category)
        {
            this.Date = Date;
            this.Price = Price;
            this.Category = Category;
        }
    }
}
