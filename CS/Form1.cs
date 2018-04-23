using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T263441 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            var customers = GetCustomers();
            this.gridControl1.DataSource = new BindingList<Customer>(customers);
            gridView1.ExpandAllGroups();

        }

        public IList<Customer> GetCustomers() {
            IList<Customer> customers = new List<Customer>();

            customers.Add(new Customer() { FirstName = "Charlotte", LastName = "Cooper", Country = "UK", Cash = 1200, HasChildren = true  });
            customers.Add(new Customer() { FirstName = "Shelley", LastName = "Burke", Country = "Germany", Cash = 1233, HasChildren = true });
            customers.Add(new Customer() { FirstName = "Regina", LastName = "Murphy", Country = "Italy", Cash = 632, HasChildren = true });
            customers.Add(new Customer() { FirstName = "Yoshi", LastName = "Nagase", Country = "Italy", Cash = 1242, HasChildren = false });
            customers.Add(new Customer() { FirstName = "Mayumi", LastName = "Ohno", Country = "Sweden", Cash = 234, HasChildren = true });
            customers.Add(new Customer() { FirstName = "Nancy", LastName = "Davolio", Country = "USA", Cash = 5432, HasChildren = true });
            customers.Add(new Customer() { FirstName = "Andrew", LastName = "Fuller", Country = "USA", Cash = 2342, HasChildren = false });
            customers.Add(new Customer() { FirstName = "Janet", LastName = "Leverling", Country = "USA", Cash = 1412, HasChildren = true });
            customers.Add(new Customer() { FirstName = "Steven", LastName = "Buchanan", Country = "", Cash = 1645, HasChildren = true });
            customers.Add(new Customer() { FirstName = "Michael", LastName = "Suyama", Country = "Germany", Cash = 1465, HasChildren = true });
            customers.Add(new Customer() { FirstName = "Robert", LastName = "King", Country = "Sweden", Cash = 1941, HasChildren = true });
            customers.Add(new Customer() { FirstName = "Laura", LastName = "Callahan", Country = "Sweden", Cash = 1489, HasChildren = false });
            customers.Add(new Customer() { FirstName = "Anne", LastName = "Dodsworth", Country = "UK", Cash = 1945, HasChildren = true });
            return customers;
        }
    }
}
