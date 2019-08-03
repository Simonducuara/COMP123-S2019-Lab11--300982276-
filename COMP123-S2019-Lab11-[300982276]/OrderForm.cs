using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab11__300982276_
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderBackButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfo = new ProductInfoForm();
            productInfo.Show();
            this.Hide();
        }

        private void OrderCancelButton_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            selectForm.Show();
            this.Hide();
        }

        private void OrderFinishButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
