using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP_Test.Views;
using MVP_Test.Presenters;

namespace MVP_Test
{
    public partial class Form1 : Form, IProduct
    {
        public Form1()
        {
            InitializeComponent();
        }

        public decimal Count { get => numCount.Value; set => numCount.Value = value; }
        public string PriceText { get => txtPrice.Text; set => txtPrice.Text = value; }
        public string CoastText { get => labCoast.Text; set => labCoast.Text = value; }

        private void btnCoast_Click(object sender, EventArgs e)
        {
            ProductPresenter productPresenter = new ProductPresenter(this);
            productPresenter.Coast();
        }
    }
}
