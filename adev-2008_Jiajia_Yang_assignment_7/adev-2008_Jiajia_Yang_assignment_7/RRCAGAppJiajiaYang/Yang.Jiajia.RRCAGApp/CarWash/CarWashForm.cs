using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using ACE.BIT.ADEV;
using ACE.BIT.ADEV.CarWash;
using Yang.Jiajia.Business;
using Yang.Jiajia.RRCAGApp;
using System.IO;

/*
 * Name: Jiajia Yang
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-04-04
 * Updated: 2023-04-05
 */

namespace Yang.Jiajia.RRCAGApp
{
    public partial class CarWashForm : ACE.BIT.ADEV.Forms.CarWashForm
    {
        private BindingList<Package> packages;
        private BindingSource packagesSource;
        
        private BindingList<Fragrance> fragrances;
        private BindingSource fragrancesSource;

        private CarWashInvoice carWashInvoice;

        private CarWashInvoiceForm carWashInvoiceForm;


        public CarWashForm()
        {
            InitializeComponent();

            //Package
            // Create a new BindingList of packages
            packages = new BindingList<Package> 
            {
                new Package(description: "Standard", price: 7.5m, interiorServices: new List<string> { "Fragrance" }, exteriorServices:new List<string> { "HandWash" }),
                new Package(description:"Deluxe", price: 15m, interiorServices: new List<string> { "Fragrance", "Shampoo Carpets" }, exteriorServices: new List<string> { "HandWash", "Hand Wax" }),
                new Package(description:"Executive", price: 35m, interiorServices: new List<string> { "Fragrance", "Shampoo Carpets", "Shampoo Upholstery" }, exteriorServices: new List<string> { "HandWash", "Hand Wax", "Wheel Polish" }),
                new Package(description:"Luxury", price: 55m, interiorServices: new List<string> { "Fragrance", "Shampoo Carpets", "Shampoo Upholstery", "Interior Protection Coat" }, exteriorServices: new List<string> { "HandWash", "Hand Wax", "Wheel Polish", "Detail Engine Compartment" })
            };

            // Create a new BindingSource and set its DataSource to the BindingList
            this.packagesSource = new BindingSource();
            this.packagesSource.DataSource = this.packages;

            //Fragrance
            //create a new BindingList of fragrances
            this.fragrancesSource = new BindingSource();
            this.fragrances = new BindingList<Fragrance>();
            LoadFile_Fragrances();
            this.fragrancesSource.DataSource = this.fragrances;
            

            // invoke the method for Binding controls for packages and fragrances
            BindControls();

            // invoke the events
            this.Load += CarWashForm_Load;
            this.cboPackage.SelectedIndexChanged += CboPackage_SelectedIndexChanged;
            this.cboFragrance.SelectedIndexChanged += CboFragrance_SelectedIndexChanged;

        


        }

        
        
        private void CboFragrance_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void CboPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();

            

        }

        public void CarWashForm_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void LoadFile_Fragrances()
        {
            //When the fragrance data file does not exist at the intended path, display the following MessageBox

            FileStream stream = null;

            try
            {
                stream = new FileStream("..\\..\\bin\\Debug\\fragrances.txt", FileMode.Open, FileAccess.Read);//Debug
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    string[] fields = line.Split(',');

                    string name = fields[0];
                    decimal price = decimal.Parse(fields[1]);

                    this.fragrances.Add(new Fragrance(name, price));
                }

                this.fragrances.Add(new Fragrance());

                reader.Close();
                stream.Dispose();
            }
            catch
            {
                if (File.Exists("..\\..\\bin\\Debug\\fragrances.txt"))
                {
                    MessageBox.Show("The fragrance data file is not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    MessageBox.Show("An error occurred while reading the data file", "Data File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //CarWashForm.ActiveForm.Close();// all the forms are closed
                this.Close();

            }
            
            
            

        }


        private void BindControls()
        {
            // Bind the controls for packages to the BindingSource
            this.cboPackage.DataSource = this.packagesSource;
            this.cboPackage.DisplayMember = "Description";
            this.cboPackage.ValueMember = "Price";

            // Bind the controls for fragrances to the BindingSource
            this.cboFragrance.DataSource = this.fragrancesSource;
            this.cboFragrance.DisplayMember = "Name";
            this.cboFragrance.ValueMember = "Price";

            

        }

        private void UpdateUI()
        {

            this.lstInterior.Items.Clear();
            this.lstExterior.Items.Clear();
            
            if (this.cboPackage.SelectedIndex != -1 && this.cboFragrance.SelectedIndex != -1)
            {
                //bind the fragrance item with the selected index to the variable fragrance "Fragrance-<selected fragrance>"
                Package packageChosen = this.packages[this.cboPackage.SelectedIndex];
                Fragrance fragranceChosen = this.fragrances[this.cboFragrance.SelectedIndex];

                string[] interiorServices = packageChosen.InteriorServices.ToArray();
                interiorServices[0] += "-" + this.fragrances[this.cboFragrance.SelectedIndex].Name;

                //bind the interior services to the listbox
                //Wrong way: this.lstInterior.Items.AddRange(this.packages[this.cboPackage.SelectedIndex].InteriorServices.ToArray());
                //Because in this way we create another array not the interiorServices array
                this.lstInterior.Items.AddRange(interiorServices);
                

                //bind the exiterior services to the listbox
                this.lstExterior.Items.AddRange(this.packages[this.cboPackage.SelectedIndex].ExteriorServices.ToArray());


                //Initialize an instance of CarWashInvoice
                this.carWashInvoice = new CarWashInvoice(0m, .05m, packageChosen.Price, fragranceChosen.Price);

                //bind the cost to the lbltbox
                this.lblSubtotal.Text = this.carWashInvoice.SubTotal.ToString("c");
                this.lblProvincialSalesTax.Text = this.carWashInvoice.ProvincialSalesTaxCharged.ToString("N2");
                this.lblGoodsAndServicesTax.Text = this.carWashInvoice.GoodsAndServicesTaxCharged.ToString("N2");
                this.lblTotal.Text = this.carWashInvoice.Total.ToString("c");

                //Enable the mnuToolsGenrateInvoice
                //invoke the event for mnuToolsGenrateInvoice click
                this.mnuToolsGenerateInvoice.Enabled = true;
                this.mnuToolsGenerateInvoice.Click += MnuToolsGenerateInvoice_Click;
            }

           

        }

        public void Reset()
        {
            this.mnuToolsGenerateInvoice.Enabled = false;
            this.cboPackage.SelectedIndex = -1;// set the selected index to -1 means no item is selected
            this.cboFragrance.SelectedIndex = this.cboFragrance.FindStringExact("pine");// set the selected index to the item with the text "pine"
            this.lstInterior.Items.Clear();
            this.lstExterior.Items.Clear();
            this.lblSubtotal.Text = "";
            this.lblProvincialSalesTax.Text = "";
            this.lblGoodsAndServicesTax.Text = "";
            this.lblTotal.Text = "";
            this.carWashInvoice = null;// should not forget to set null 

        }

        
        

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarWashForm));
            this.SuspendLayout();

            this.mnuFileClose.Click += MnuFileClose_Click;

            this.mnuToolsGenerateInvoice.Enabled = false;

            // 
            // CarWashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(395, 429);
            this.Name = "CarWashForm";
            this.Text = resources.GetString("$this.Text");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void MnuToolsGenerateInvoice_Click(object sender, EventArgs e)
        {
            //Create an instance of the CarWashInvoiceForm
            carWashInvoiceForm = new CarWashInvoiceForm(this.carWashInvoice,this);

            //Show the CarWashInvoiceForm
            carWashInvoiceForm.ShowDialog();


            
        }

        

        
    }
}
