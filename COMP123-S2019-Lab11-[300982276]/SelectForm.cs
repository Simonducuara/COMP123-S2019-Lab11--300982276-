using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5__300982276_
{
    public partial class SelectForm : Form
    {
        public Form parent { get; set; }

        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectFormNextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfo = new ProductInfoForm();
            //endForm.parent = this;
            productInfo.Show();
            this.Hide();
        }

        private void SelectFormCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            SelectLabel.Text = ProductDataGridViewSelectedItem();
        }

        private void ProductsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
           // SelectLabel.Text = ProductDataGridViewSelectedItem();
        }

        private string  ProductDataGridViewSelectedItem()
        {
            
            var rowIndex = ProductsDataGridView.CurrentCell.RowIndex;
            var currentRow = ProductsDataGridView.Rows[rowIndex];
            var cost = currentRow.Cells[1].Value.ToString();
            var manufacturer = currentRow.Cells[2].Value.ToString();
            var model = currentRow.Cells[3].Value.ToString();

            string outputString = manufacturer + " " + model + " " + " " + cost;

            return outputString;
        }

        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectLabel.Text = ProductDataGridViewSelectedItem();
        }
    }
}
