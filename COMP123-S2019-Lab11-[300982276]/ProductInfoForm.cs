﻿using System;
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
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoNextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            
            orderForm.Show();
            this.Hide();
        }

        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            selectForm.Show();
            this.Hide();
        }
    }
}
