using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACE.BIT.ADEV;
using Yang.Jiajia.RRCAGApp;
using Yang.Jiajia.Business;


namespace Yang.Jiajia.RRCAGApp
{
    public partial class CarWashInvoiceForm : ACE.BIT.ADEV.Forms.CarWashInvoiceForm
    {

        private CarWashInvoice carWashInvoice;

        private BindingSource invoiceSource;

        private CarWashForm carWashForm;

        public CarWashInvoiceForm(CarWashInvoice carWashInvoice,CarWashForm carWashForm)
        {
            InitializeComponent();

            this.carWashInvoice = carWashInvoice;

            this.invoiceSource = new BindingSource();

            BindControls();

            //this.lblPackagePrice.Text = carWashInvoice.PackageCost.ToString("C");
            //this.lblFragrancePrice.Text = carWashInvoice.FragranceCost.ToString("N2");
            //this.lblSubtotal.Text = carWashInvoice.SubTotal.ToString("C");
            //this.lblProvincialSalesTax.Text = carWashInvoice.ProvincialSalesTaxCharged.ToString("N2");
            //this.lblGoodsAndServicesTax.Text = carWashInvoice.GoodsAndServicesTaxCharged.ToString("N2");
            //this.lblTotal.Text = carWashInvoice.Total.ToString("C");

            this.carWashForm = carWashForm;
            this.FormClosed += CarWashInvoiceForm_FormClosed; 
        }

        private void CarWashInvoiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.carWashForm.Reset();
        }

        private void BindControls()
        {
            this.invoiceSource.DataSource = this.carWashInvoice;

            this.lblPackagePrice.DataBindings.Add("Text", this.invoiceSource, "PackageCost", true, DataSourceUpdateMode.OnValidation, string.Empty, "C");
            this.lblFragrancePrice.DataBindings.Add("Text", this.invoiceSource, "FragranceCost", true, DataSourceUpdateMode.OnValidation, string.Empty, "N2");
            this.lblSubtotal.DataBindings.Add("Text", this.invoiceSource, "SubTotal", true, DataSourceUpdateMode.OnValidation, string.Empty, "C");
            this.lblProvincialSalesTax.DataBindings.Add("Text", this.invoiceSource, "ProvincialSalesTaxCharged", true, DataSourceUpdateMode.OnValidation, string.Empty, "N2");
            this.lblGoodsAndServicesTax.DataBindings.Add("Text", this.invoiceSource, "GoodsAndServicesTaxCharged", true, DataSourceUpdateMode.OnValidation, string.Empty, "N2");
            this.lblTotal.DataBindings.Add("Text", this.invoiceSource, "Total", true, DataSourceUpdateMode.OnValidation, string.Empty, "C");

        }
        
        

    }

        

        

    
}
