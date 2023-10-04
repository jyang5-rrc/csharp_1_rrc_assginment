using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yang.Jiajia.Business;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button.CheckBox;
using CheckBox = System.Windows.Forms.CheckBox;

/*
 * Name: Jiajia Yang
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 5
 * Created: 2023-03-19
 * Updated: 2023-03-19
 */

namespace Yang.Jiajia.RRCAGApp
{
    public partial class SalesQuoteForm : Form
    {

        private bool isCalulated = false;

        public SalesQuoteForm()
        {
            InitializeComponent();

           
            this.Load += SalesQuoteForm_Load;
            this.btnCalculateQuote.Click += BtnCalculateQuote_Click;

            this.txtVehicleSalePrice.TextChanged += TxtPriceValue_TextChanged;
            this.txtTradeInValue.TextChanged += TxtPriceValue_TextChanged;

            this.cbAccessoriesStereoSystem.CheckedChanged += CheckedChanged;
            this.cbAccessoriesComputerNavigation.CheckedChanged += CheckedChanged;
            this.cbAccessoriesLeatherInterior.CheckedChanged += CheckedChanged;

            this.rbExteriorFinishStandard.CheckedChanged += CheckedChanged;
            this.rbExteriorFinishPearlized.CheckedChanged += CheckedChanged;
            this.rbExteriorFinishCustomizedDetailing.CheckedChanged += CheckedChanged;

            this.nudFinaceNoofYears.ValueChanged += CheckedChanged;
            this.nudFinanceAnnualInterestRate.ValueChanged += CheckedChanged;

            this.btnReset.Click += BtnReset_Click;
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (this.isCalulated)//this judge has to be set here, otherwise this event will not be triggered.
            {
                CalculateSummaryAndMonthlyPayment();
            }
            
        }

        /// <summary>
        /// Handles the event when the user change vehicle sale price and trade in value.
        /// </summary>
        private void TxtPriceValue_TextChanged(object sender, EventArgs e)
        {
            if (this.isCalulated)
            {
                SetSummaryEmpty();

                DefaultSetting();

                this.errorProvider1.Clear();//Clear() is a method of ErrorProvider class in the system.windows.forms namespace.
                this.errorProvider2.Clear();

                this.isCalulated = false;
            }
            
        }

       

        /// <summary>
        /// Sets the Summary group box empty.
        /// </summary>
        private void SetSummaryEmpty()
        {
            this.txtSummaryVehicleSalePrice.Text = string.Empty;
            this.txtSummaryOptions.Text = string.Empty;
            this.txtSummarySubtotal.Text = string.Empty;
            this.txtSummarySalesTax.Text = string.Empty;
            this.txtSummaryTotal.Text = string.Empty;
            this.txtSummaryTradeIn.Text = string.Empty;
            this.lblSummaryAmountDueSum.Text = string.Empty;
            
            this.lblFinanceMonthlyPaymentSum.Text = string.Empty;
        }


        /// <summary>
        /// Handles the event when the user clicks the Calculate Quote button.
        /// </summary>
        private void BtnCalculateQuote_Click(object sender, EventArgs e)
        {

            CalculateSummaryAndMonthlyPayment();

            this.isCalulated = true;
            
        }
            

        /// <summary>
        /// Verifies the validation of sale price.
        /// </summary>
        private decimal VehicleSalePrice_Validation()
        {
            string errorV = string.Empty;
            decimal vehicleSalePrice = 0;
            decimal newValue;

            string[] errorMessage = { "Vehicle price is a required field.",
                "Vehicle price cannot contain letters or special characters.",
                "Vehicle price cannot be less than or equal to 0."};

            
            
            //convert the input to the correct data type.
            try
            {
                //Validate the input.
                //If the input is invalid, display an error message.
                //Vehicle Sale Price's validation
                if (txtVehicleSalePrice.Text == "")
                {
                    errorV = errorMessage[0];
                    throw new Exception(errorV);
                }
                if (!decimal.TryParse(txtVehicleSalePrice.Text, out newValue))//Any(c => char.IsDigit(c)) is a method that determine the char is digit or not.
                {
                    errorV = errorMessage[1];
                    throw new Exception(errorV);
                }
                if (decimal.Parse(txtVehicleSalePrice.Text) <= 0)
                {
                    errorV = errorMessage[2];
                    throw new Exception(errorV);
                }


                //Get the input from the user.
                vehicleSalePrice = decimal.Parse(txtVehicleSalePrice.Text);

                

            }
            catch (Exception)
            {
                this.errorProvider1.SetError(txtVehicleSalePrice, errorV);


            }

            return vehicleSalePrice;

        }

        /// <summary>
        /// Verifies the validation of trade in amount.
        /// </summary>
        private decimal TradeInValue_Validation()
        {
            string errorT = string.Empty;
            decimal tradeInValue = -1m;
            decimal newValue;
            decimal vehicleSalePrice = VehicleSalePrice_Validation();

            //Get the input from the user.
            string[] errorMessage = { 
                "Trade-in value is a required field.",
                "Trade-in value cannot contain letters or special characters.",
                "Trade-in value cannot be less than 0.",
                "Trade-in value cannot be greater than vehicle price." };


            try
            {


                //Trade-in Value's validation
                if (txtTradeInValue.Text == "")
                {
                    errorT = errorMessage[0];
                    throw new Exception(errorT);
                }
                if (!decimal.TryParse(txtTradeInValue.Text, out newValue))
                {
                    errorT = errorMessage[1];
                    throw new Exception(errorT);
                }

                if (decimal.Parse(txtTradeInValue.Text) < 0)
                {
                    errorT = errorMessage[2];
                    throw new Exception(errorT);
                }
                //Trade-in value cannot exceed the vehicle sale price.
                //This error check should only happen when the vehicle sale price is free of errors.
                if (decimal.Parse(txtTradeInValue.Text) > vehicleSalePrice)
                {
                    errorT = errorMessage[1];
                    throw new Exception(errorT);
                }

                //Get the input from the user.
                tradeInValue = decimal.Parse(txtTradeInValue.Text);

               
            }
            catch
            {
                this.errorProvider2.SetError(txtTradeInValue, errorT);
                
            }

            return tradeInValue;

        }

        /// <summary>
        /// Gets the chosen of CheckBox.
        /// </summary>
        private Accessories AccessioresChosen_CheckBox()
        {
            Accessories a = Accessories.None;

            if (this.errorProvider1.GetError(this.txtVehicleSalePrice) == string.Empty &&
                    this.errorProvider2.GetError(this.txtTradeInValue).Equals(string.Empty))
            {
                //check the state of checkbox, if checked, add the tag to AccessoiresChosen.
                
                if (this.cbAccessoriesStereoSystem.Checked)
                {
                    a = Accessories.StereoSystem;//(Accessories)this.cbAccessoriesStereoSystem.Tag;

                    if (this.cbAccessoriesLeatherInterior.Checked)
                    {
                        a = Accessories.StereoAndLeather;

                        if (this.cbAccessoriesComputerNavigation.Checked)
                        {
                            a = Accessories.All;
                        }
                    }
                    else if (this.cbAccessoriesComputerNavigation.Checked)
                    {
                        a = Accessories.StereoAndNavigation;
                    }

                }
                else if (this.cbAccessoriesLeatherInterior.Checked)
                {
                    a = Accessories.LeatherInterior;//(Accessories)this.cbAccessoriesLeatherInterior.Tag;

                    if (this.cbAccessoriesComputerNavigation.Checked)
                    {
                        a = Accessories.LeatherAndNavigation;
                    }
                }
                else if (this.cbAccessoriesComputerNavigation.Checked)
                {
                    a = Accessories.ComputerNavigation;//(Accessories)this.cbAccessoriesComputerNavigation.Tag;
                }
            }

            return a;

        }

        /// <summary>
        /// Gets the chosen of RaadioBox
        /// </summary>
        private ExteriorFinish ExteriorFinishChosen_RadioBox()
        {
            ExteriorFinish eT = ExteriorFinish.Standard;

            if (this.errorProvider1.GetError(this.txtVehicleSalePrice) == string.Empty &&
                    this.errorProvider2.GetError(this.txtTradeInValue).Equals(string.Empty))
            {
                //check the state of radio button
                if (this.rbExteriorFinishStandard.Checked)
                {
                }
                else if (this.rbExteriorFinishPearlized.Checked)
                {
                    eT = ExteriorFinish.Pearlized; //(ExteriorFinish)this.rbExteriorFinishPearlized.Tag;
                }
                else if (this.rbExteriorFinishCustomizedDetailing.Checked)
                {
                    eT = ExteriorFinish.Custom;// (ExteriorFinish)this.rbExteriorFinishCustomizedDetailing.Tag;
                }

            }

            return eT;

        }

        /// <summary>
        /// Calculates the summary and monthly payment.
        /// </summary>
        private void CalculateSummaryAndMonthlyPayment()
        {
            decimal vehicleSalePrice = VehicleSalePrice_Validation();
            decimal tradeInValue = TradeInValue_Validation();
            decimal monthlyPayment;
            Accessories a = AccessioresChosen_CheckBox();
            ExteriorFinish eT = ExteriorFinishChosen_RadioBox();

            //create an instance
            if (vehicleSalePrice != 0 && tradeInValue >=0) 
            {
                SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, 0.12m, a, eT);

                //Summary values and format
                this.txtSummaryVehicleSalePrice.Text = "$" + salesQuote.VehicleSalePrice.ToString("N2");
                this.txtSummaryOptions.Text = salesQuote.TotalOptions.ToString("N2");
                this.txtSummarySubtotal.Text = "$" + salesQuote.SubTotal.ToString("N2");
                this.txtSummarySalesTax.Text = salesQuote.SalesTax.ToString("N2");
                this.txtSummaryTotal.Text = "$" + salesQuote.Total.ToString("N2");
                this.txtSummaryTradeIn.Text = "-" + salesQuote.TradeInAmount.ToString("N2");
                this.lblSummaryAmountDueSum.Text = "$" + salesQuote.AmountDue.ToString("N2");

                //Monthly payment
                monthlyPayment = salesQuote.AmountDue * (this.nudFinanceAnnualInterestRate.Value * 0.01m) / (this.nudFinaceNoofYears.Value * 12);
                this.lblFinanceMonthlyPaymentSum.Text = monthlyPayment.ToString("N2");
            }
            

            
        }

        /// <summary>
        /// Handles the event when the form is loaded.
        /// </summary>
        private void SalesQuoteForm_Load(object sender, EventArgs e)//load event only need to set the default value, no need to consider the empty elements before input.
        {
            
            DefaultSetting();

   
        }

        /// <summary>
        /// Set the default values for the form.
        /// </summary>
        private void DefaultSetting()
        {
            this.txtVehicleSalePrice.Text = string.Empty;
            this.txtTradeInValue.Text = "0";
            this.txtVehicleSalePrice.Focus();
            this.btnCalculateQuote.Select();//means the button is the default button for the form.
            this.cbAccessoriesStereoSystem.Checked = false;
            this.cbAccessoriesLeatherInterior.Checked = false;
            this.cbAccessoriesComputerNavigation.Checked = false;
            this.rbExteriorFinishStandard.Checked = true;
            this.nudFinanceAnnualInterestRate.Value = 5;
            this.nudFinaceNoofYears.Value = 1;
        }

        /// <summary>
        /// Handles the event when the user clicks the Reset button.
        /// </summary>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            DialogResult result 
                = MessageBox.Show("Do you want to reset the form?",
                "Reset Form", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning, 
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                DefaultSetting();
                SetSummaryEmpty();
                this.errorProvider1.Clear();
                this.errorProvider2.Clear();
                this.isCalulated = false;

            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

     
    }
}
