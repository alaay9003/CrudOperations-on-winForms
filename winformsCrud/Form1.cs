using Data.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace winformsCrud
{
    public partial class Form1 : Form
    {
        Customer customer = new Customer();
        WinformCrudContext _context = new WinformCrudContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            Load_Data();
            this.ActiveControl = TextFn;
        }
        void Clear()
        {
            TextAdress.Text = TextFn.Text = TextLn.Text = TextCity.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            customer.Id = 0;
        }
        void collect_data()
        {
            customer.FirstName = TextFn.Text.Trim();
            customer.LastName = TextLn.Text.Trim();
            customer.City = TextCity.Text.Trim();
            customer.Adress = TextAdress.Text.Trim();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            collect_data();
            if (customer.Id == 0)
            {
                if(validation()==true)
                {
                    _context.Customers.Add(customer);
                    _context.SaveChanges();
                    MessageBox.Show("customer Added");
                    Clear();
                    Load_Data();
                }
                else
                {
                    MessageBox.Show("complete data","vlidation",MessageBoxButtons.OK);
                }

            }
            else
            {
                collect_data();
                _context.Customers.Update(customer);
                _context.SaveChanges();
                MessageBox.Show("customer has updated");
                Clear();
                Load_Data();
            }

        }
        void Load_Data()
        {
            dgCustomer.AutoGenerateColumns = false;
            dgCustomer.DataSource = _context.Customers.ToList();
        }
        bool validation()
        {
            if (TextFn.Text =="" || TextLn.Text =="" || TextCity.Text == "" || TextAdress.Text=="")
            {
                return false;
            }
            else
                return true;
        }
        private void dgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (dgCustomer.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(dgCustomer.CurrentRow.Cells["Id"].Value);
                customer = _context.Customers.Where(c => c.Id == id).FirstOrDefault();
                if (customer != null)
                {
                    Show_Data();
                    btnSave.Text = "update";
                    btnDelete.Enabled = true;
                }

            }
        }
        void Show_Data()
        {
            TextFn.Text = customer.FirstName;
            TextLn.Text = customer.LastName;
            TextCity.Text = customer.City;
            TextAdress.Text = customer.Adress;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure ?","Delet",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
                MessageBox.Show("customer has deleted");
                Clear();
                Load_Data();

            }
        }
    }
}