using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDB
{
    public partial class MainForm : Form
    {
        CounterAgentForm counterAgent;
        ReleaseForm release;
        SupplyForm supply;
        PriceRegisterForm priceRegister;
        StockForm stock;
        ReleaseSpecificationForm releaseSpecification;
        SupplySpecificationForm supplySpecification;
        ProductForm product;

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            counterAgent = new CounterAgentForm();
            release = new ReleaseForm();  
            supply = new SupplyForm();  
            priceRegister = new PriceRegisterForm();    
            stock = new StockForm();
            releaseSpecification = new ReleaseSpecificationForm();
            supplySpecification = new SupplySpecificationForm();
            product = new ProductForm();
        }

        private void CounterAgentBtn_Click(object sender, EventArgs e)
        {
            counterAgent.ShowDialog();
        }

        private void ReleaseBtn_Click(object sender, EventArgs e)
        {
            release.ShowDialog();
        }

        private void SupplyBtn_Click(object sender, EventArgs e)
        {
            supply.ShowDialog();
        }

        private void PriceRegisterBtn_Click(object sender, EventArgs e)
        {
            priceRegister.ShowDialog();
        }

        private void StockBtn_Click(object sender, EventArgs e)
        {
            stock.ShowDialog();
        }

        private void ReleaseSpecificationBtn_Click(object sender, EventArgs e)
        {
            releaseSpecification.ShowDialog();
        }

        private void SupplySpecificationBtn_Click(object sender, EventArgs e)
        {
            supplySpecification.ShowDialog();
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            product.ShowDialog();
        }
    }
}
