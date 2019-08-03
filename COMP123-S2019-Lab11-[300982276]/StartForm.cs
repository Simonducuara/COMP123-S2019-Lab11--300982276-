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
    public partial class StartForm : Form
    {
        public Form parent { get; set; }

        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void StartNewOrderButton_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            selectForm.parent = this;
            selectForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
