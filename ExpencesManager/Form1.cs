using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ExpensesManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File doesn't exist");
                return;
            }
            var data = File.ReadAllLines(path).Skip(1);
            List<Expences> expences = new List<Expences>();
            foreach(var i in data)
            {
                var split = i.Split('|');
                var Date = split[0];
                var Price = split[1];
                var Category = split[2];
                var exp = new Expences(Convert.ToDateTime(Date), Convert.ToDouble(Price),Category);

                expences.Add(exp);
            }

            var numberOfCats = expences.Select(x => x.Category).Distinct().Count();
            var sumOfExpences = expences.Select(x => x.Price).Sum();
            var categorynames = expences.Select(x => x.Category).Distinct().ToList();
             var dates = expences.Select(x => Convert.ToString(x.Date).Split(' ')[0]).Distinct().ToList();
            
            textBox2.Text += $"Number of categories is {numberOfCats} and the total expences equal to {sumOfExpences}\r\n";
            textBox2.Text += $"Category names {string.Join(", ", categorynames)}\r\n";
            textBox2.Text += $"Dates: {string.Join(", ", dates)}\r\n";

            
        }
    }
    class Expences
    {
        public DateTime Date { get; private set; }
        public double Price { get; private set; }
        public string Category { get; private set; }

        public Expences(DateTime Date, double Price, string Category)
        {
            this.Date = Date;
            this.Price = Price;
            this.Category = Category;
        }
    }
}
