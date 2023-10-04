namespace Yang.Jiajia.RRCAGApp
{
    partial class SalesQuoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblVehicleSalePrice = new System.Windows.Forms.Label();
            this.txtVehicleSalePrice = new System.Windows.Forms.TextBox();
            this.lblTradeInValue = new System.Windows.Forms.Label();
            this.txtTradeInValue = new System.Windows.Forms.TextBox();
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.cbAccessoriesComputerNavigation = new System.Windows.Forms.CheckBox();
            this.cbAccessoriesLeatherInterior = new System.Windows.Forms.CheckBox();
            this.cbAccessoriesStereoSystem = new System.Windows.Forms.CheckBox();
            this.grpExteriorFinish = new System.Windows.Forms.GroupBox();
            this.rbExteriorFinishCustomizedDetailing = new System.Windows.Forms.RadioButton();
            this.rbExteriorFinishPearlized = new System.Windows.Forms.RadioButton();
            this.rbExteriorFinishStandard = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.lblSummaryAmountDueSum = new System.Windows.Forms.Label();
            this.lblSummaryAmountDue = new System.Windows.Forms.Label();
            this.txtSummaryTradeIn = new System.Windows.Forms.TextBox();
            this.lblSummaryTradeIn = new System.Windows.Forms.Label();
            this.txtSummaryTotal = new System.Windows.Forms.TextBox();
            this.lblSummaryTotal = new System.Windows.Forms.Label();
            this.txtSummarySalesTax = new System.Windows.Forms.TextBox();
            this.lblSummarySalesTax = new System.Windows.Forms.Label();
            this.txtSummarySubtotal = new System.Windows.Forms.TextBox();
            this.lblSummarySubtotal = new System.Windows.Forms.Label();
            this.txtSummaryOptions = new System.Windows.Forms.TextBox();
            this.lblSummaryOptions = new System.Windows.Forms.Label();
            this.txtSummaryVehicleSalePrice = new System.Windows.Forms.TextBox();
            this.lblSummaryVehicleSalePrice = new System.Windows.Forms.Label();
            this.gbFinance = new System.Windows.Forms.GroupBox();
            this.lblFinanceMonthlyPaymentSum = new System.Windows.Forms.Label();
            this.lblFinanceMonthlyPayment = new System.Windows.Forms.Label();
            this.nudFinanceAnnualInterestRate = new System.Windows.Forms.NumericUpDown();
            this.nudFinaceNoofYears = new System.Windows.Forms.NumericUpDown();
            this.lblFinanceAnnualInterestRate = new System.Windows.Forms.Label();
            this.lblFinanceNoofYears = new System.Windows.Forms.Label();
            this.btnCalculateQuote = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAccessories.SuspendLayout();
            this.grpExteriorFinish.SuspendLayout();
            this.gbSummary.SuspendLayout();
            this.gbFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinanceAnnualInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinaceNoofYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVehicleSalePrice
            // 
            this.lblVehicleSalePrice.AutoSize = true;
            this.lblVehicleSalePrice.Location = new System.Drawing.Point(60, 54);
            this.lblVehicleSalePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicleSalePrice.Name = "lblVehicleSalePrice";
            this.lblVehicleSalePrice.Size = new System.Drawing.Size(208, 25);
            this.lblVehicleSalePrice.TabIndex = 0;
            this.lblVehicleSalePrice.Text = "Vehicle\'s Sale Price:";
            // 
            // txtVehicleSalePrice
            // 
            this.txtVehicleSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleSalePrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVehicleSalePrice.Location = new System.Drawing.Point(270, 46);
            this.txtVehicleSalePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtVehicleSalePrice.Name = "txtVehicleSalePrice";
            this.txtVehicleSalePrice.Size = new System.Drawing.Size(226, 31);
            this.txtVehicleSalePrice.TabIndex = 1;
            this.txtVehicleSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTradeInValue
            // 
            this.lblTradeInValue.AutoSize = true;
            this.lblTradeInValue.Location = new System.Drawing.Point(110, 125);
            this.lblTradeInValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTradeInValue.Name = "lblTradeInValue";
            this.lblTradeInValue.Size = new System.Drawing.Size(159, 25);
            this.lblTradeInValue.TabIndex = 2;
            this.lblTradeInValue.Text = "Trade-in Value:";
            // 
            // txtTradeInValue
            // 
            this.txtTradeInValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTradeInValue.Location = new System.Drawing.Point(270, 117);
            this.txtTradeInValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtTradeInValue.Name = "txtTradeInValue";
            this.txtTradeInValue.Size = new System.Drawing.Size(226, 31);
            this.txtTradeInValue.TabIndex = 2;
            this.txtTradeInValue.Text = "0";
            this.txtTradeInValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpAccessories
            // 
            this.grpAccessories.Controls.Add(this.cbAccessoriesComputerNavigation);
            this.grpAccessories.Controls.Add(this.cbAccessoriesLeatherInterior);
            this.grpAccessories.Controls.Add(this.cbAccessoriesStereoSystem);
            this.grpAccessories.Location = new System.Drawing.Point(60, 206);
            this.grpAccessories.Margin = new System.Windows.Forms.Padding(4);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Padding = new System.Windows.Forms.Padding(4);
            this.grpAccessories.Size = new System.Drawing.Size(436, 269);
            this.grpAccessories.TabIndex = 3;
            this.grpAccessories.TabStop = false;
            this.grpAccessories.Text = "Accessories";
            // 
            // cbAccessoriesComputerNavigation
            // 
            this.cbAccessoriesComputerNavigation.AutoSize = true;
            this.cbAccessoriesComputerNavigation.Location = new System.Drawing.Point(36, 188);
            this.cbAccessoriesComputerNavigation.Margin = new System.Windows.Forms.Padding(4);
            this.cbAccessoriesComputerNavigation.Name = "cbAccessoriesComputerNavigation";
            this.cbAccessoriesComputerNavigation.Size = new System.Drawing.Size(245, 29);
            this.cbAccessoriesComputerNavigation.TabIndex = 5;
            this.cbAccessoriesComputerNavigation.Tag = "ComputerNavigation";
            this.cbAccessoriesComputerNavigation.Text = "Computer Navigation";
            this.cbAccessoriesComputerNavigation.UseVisualStyleBackColor = true;
            // 
            // cbAccessoriesLeatherInterior
            // 
            this.cbAccessoriesLeatherInterior.AutoSize = true;
            this.cbAccessoriesLeatherInterior.Location = new System.Drawing.Point(36, 121);
            this.cbAccessoriesLeatherInterior.Margin = new System.Windows.Forms.Padding(4);
            this.cbAccessoriesLeatherInterior.Name = "cbAccessoriesLeatherInterior";
            this.cbAccessoriesLeatherInterior.Size = new System.Drawing.Size(189, 29);
            this.cbAccessoriesLeatherInterior.TabIndex = 4;
            this.cbAccessoriesLeatherInterior.Tag = "LeatherInterior";
            this.cbAccessoriesLeatherInterior.Text = "Leather Interior";
            this.cbAccessoriesLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // cbAccessoriesStereoSystem
            // 
            this.cbAccessoriesStereoSystem.AllowDrop = true;
            this.cbAccessoriesStereoSystem.AutoSize = true;
            this.cbAccessoriesStereoSystem.Location = new System.Drawing.Point(36, 54);
            this.cbAccessoriesStereoSystem.Margin = new System.Windows.Forms.Padding(4);
            this.cbAccessoriesStereoSystem.Name = "cbAccessoriesStereoSystem";
            this.cbAccessoriesStereoSystem.Size = new System.Drawing.Size(184, 29);
            this.cbAccessoriesStereoSystem.TabIndex = 3;
            this.cbAccessoriesStereoSystem.Tag = "StereoSystem";
            this.cbAccessoriesStereoSystem.Text = "Stereo System";
            this.cbAccessoriesStereoSystem.UseVisualStyleBackColor = true;
            // 
            // grpExteriorFinish
            // 
            this.grpExteriorFinish.Controls.Add(this.rbExteriorFinishCustomizedDetailing);
            this.grpExteriorFinish.Controls.Add(this.rbExteriorFinishPearlized);
            this.grpExteriorFinish.Controls.Add(this.rbExteriorFinishStandard);
            this.grpExteriorFinish.Location = new System.Drawing.Point(60, 525);
            this.grpExteriorFinish.Margin = new System.Windows.Forms.Padding(4);
            this.grpExteriorFinish.Name = "grpExteriorFinish";
            this.grpExteriorFinish.Padding = new System.Windows.Forms.Padding(4);
            this.grpExteriorFinish.Size = new System.Drawing.Size(436, 281);
            this.grpExteriorFinish.TabIndex = 4;
            this.grpExteriorFinish.TabStop = false;
            this.grpExteriorFinish.Text = "Exterior Finish";
            // 
            // rbExteriorFinishCustomizedDetailing
            // 
            this.rbExteriorFinishCustomizedDetailing.AutoSize = true;
            this.rbExteriorFinishCustomizedDetailing.Location = new System.Drawing.Point(38, 200);
            this.rbExteriorFinishCustomizedDetailing.Margin = new System.Windows.Forms.Padding(4);
            this.rbExteriorFinishCustomizedDetailing.Name = "rbExteriorFinishCustomizedDetailing";
            this.rbExteriorFinishCustomizedDetailing.Size = new System.Drawing.Size(246, 29);
            this.rbExteriorFinishCustomizedDetailing.TabIndex = 6;
            this.rbExteriorFinishCustomizedDetailing.Tag = "Custom";
            this.rbExteriorFinishCustomizedDetailing.Text = "Customized Detailing";
            this.rbExteriorFinishCustomizedDetailing.UseVisualStyleBackColor = true;
            // 
            // rbExteriorFinishPearlized
            // 
            this.rbExteriorFinishPearlized.AutoSize = true;
            this.rbExteriorFinishPearlized.Location = new System.Drawing.Point(38, 129);
            this.rbExteriorFinishPearlized.Margin = new System.Windows.Forms.Padding(4);
            this.rbExteriorFinishPearlized.Name = "rbExteriorFinishPearlized";
            this.rbExteriorFinishPearlized.Size = new System.Drawing.Size(133, 29);
            this.rbExteriorFinishPearlized.TabIndex = 6;
            this.rbExteriorFinishPearlized.Tag = "Pearlized";
            this.rbExteriorFinishPearlized.Text = "Pearlized";
            this.rbExteriorFinishPearlized.UseVisualStyleBackColor = true;
            // 
            // rbExteriorFinishStandard
            // 
            this.rbExteriorFinishStandard.AutoSize = true;
            this.rbExteriorFinishStandard.Checked = true;
            this.rbExteriorFinishStandard.Location = new System.Drawing.Point(38, 63);
            this.rbExteriorFinishStandard.Margin = new System.Windows.Forms.Padding(4);
            this.rbExteriorFinishStandard.Name = "rbExteriorFinishStandard";
            this.rbExteriorFinishStandard.Size = new System.Drawing.Size(130, 29);
            this.rbExteriorFinishStandard.TabIndex = 6;
            this.rbExteriorFinishStandard.TabStop = true;
            this.rbExteriorFinishStandard.Tag = "Standard";
            this.rbExteriorFinishStandard.Text = "Standard";
            this.rbExteriorFinishStandard.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReset.Location = new System.Drawing.Point(60, 835);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(174, 56);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.lblSummaryAmountDueSum);
            this.gbSummary.Controls.Add(this.lblSummaryAmountDue);
            this.gbSummary.Controls.Add(this.txtSummaryTradeIn);
            this.gbSummary.Controls.Add(this.lblSummaryTradeIn);
            this.gbSummary.Controls.Add(this.txtSummaryTotal);
            this.gbSummary.Controls.Add(this.lblSummaryTotal);
            this.gbSummary.Controls.Add(this.txtSummarySalesTax);
            this.gbSummary.Controls.Add(this.lblSummarySalesTax);
            this.gbSummary.Controls.Add(this.txtSummarySubtotal);
            this.gbSummary.Controls.Add(this.lblSummarySubtotal);
            this.gbSummary.Controls.Add(this.txtSummaryOptions);
            this.gbSummary.Controls.Add(this.lblSummaryOptions);
            this.gbSummary.Controls.Add(this.txtSummaryVehicleSalePrice);
            this.gbSummary.Controls.Add(this.lblSummaryVehicleSalePrice);
            this.gbSummary.Location = new System.Drawing.Point(564, 35);
            this.gbSummary.Margin = new System.Windows.Forms.Padding(6);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Padding = new System.Windows.Forms.Padding(6);
            this.gbSummary.Size = new System.Drawing.Size(626, 538);
            this.gbSummary.TabIndex = 6;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Summary";
            // 
            // lblSummaryAmountDueSum
            // 
            this.lblSummaryAmountDueSum.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSummaryAmountDueSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryAmountDueSum.Enabled = false;
            this.lblSummaryAmountDueSum.Location = new System.Drawing.Point(274, 448);
            this.lblSummaryAmountDueSum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSummaryAmountDueSum.Name = "lblSummaryAmountDueSum";
            this.lblSummaryAmountDueSum.Size = new System.Drawing.Size(274, 37);
            this.lblSummaryAmountDueSum.TabIndex = 0;
            this.lblSummaryAmountDueSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryAmountDue
            // 
            this.lblSummaryAmountDue.AutoSize = true;
            this.lblSummaryAmountDue.Location = new System.Drawing.Point(122, 456);
            this.lblSummaryAmountDue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSummaryAmountDue.Name = "lblSummaryAmountDue";
            this.lblSummaryAmountDue.Size = new System.Drawing.Size(136, 25);
            this.lblSummaryAmountDue.TabIndex = 12;
            this.lblSummaryAmountDue.Text = "Amount Due:";
            // 
            // txtSummaryTradeIn
            // 
            this.txtSummaryTradeIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummaryTradeIn.Location = new System.Drawing.Point(274, 383);
            this.txtSummaryTradeIn.Margin = new System.Windows.Forms.Padding(6);
            this.txtSummaryTradeIn.Name = "txtSummaryTradeIn";
            this.txtSummaryTradeIn.Size = new System.Drawing.Size(272, 31);
            this.txtSummaryTradeIn.TabIndex = 6;
            this.txtSummaryTradeIn.TabStop = false;
            this.txtSummaryTradeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryTradeIn
            // 
            this.lblSummaryTradeIn.AutoSize = true;
            this.lblSummaryTradeIn.Location = new System.Drawing.Point(160, 388);
            this.lblSummaryTradeIn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSummaryTradeIn.Name = "lblSummaryTradeIn";
            this.lblSummaryTradeIn.Size = new System.Drawing.Size(98, 25);
            this.lblSummaryTradeIn.TabIndex = 10;
            this.lblSummaryTradeIn.Text = "Trade-in:";
            // 
            // txtSummaryTotal
            // 
            this.txtSummaryTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummaryTotal.Location = new System.Drawing.Point(274, 317);
            this.txtSummaryTotal.Margin = new System.Windows.Forms.Padding(6);
            this.txtSummaryTotal.Name = "txtSummaryTotal";
            this.txtSummaryTotal.Size = new System.Drawing.Size(272, 31);
            this.txtSummaryTotal.TabIndex = 6;
            this.txtSummaryTotal.TabStop = false;
            this.txtSummaryTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryTotal
            // 
            this.lblSummaryTotal.AutoSize = true;
            this.lblSummaryTotal.Location = new System.Drawing.Point(190, 321);
            this.lblSummaryTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSummaryTotal.Name = "lblSummaryTotal";
            this.lblSummaryTotal.Size = new System.Drawing.Size(66, 25);
            this.lblSummaryTotal.TabIndex = 8;
            this.lblSummaryTotal.Text = "Total:";
            // 
            // txtSummarySalesTax
            // 
            this.txtSummarySalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummarySalesTax.Location = new System.Drawing.Point(274, 252);
            this.txtSummarySalesTax.Margin = new System.Windows.Forms.Padding(6);
            this.txtSummarySalesTax.Name = "txtSummarySalesTax";
            this.txtSummarySalesTax.Size = new System.Drawing.Size(272, 31);
            this.txtSummarySalesTax.TabIndex = 6;
            this.txtSummarySalesTax.TabStop = false;
            this.txtSummarySalesTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummarySalesTax
            // 
            this.lblSummarySalesTax.AutoSize = true;
            this.lblSummarySalesTax.Location = new System.Drawing.Point(88, 258);
            this.lblSummarySalesTax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSummarySalesTax.Name = "lblSummarySalesTax";
            this.lblSummarySalesTax.Size = new System.Drawing.Size(173, 25);
            this.lblSummarySalesTax.TabIndex = 6;
            this.lblSummarySalesTax.Text = "SalesTax（12%）:";
            // 
            // txtSummarySubtotal
            // 
            this.txtSummarySubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummarySubtotal.Location = new System.Drawing.Point(272, 187);
            this.txtSummarySubtotal.Margin = new System.Windows.Forms.Padding(6);
            this.txtSummarySubtotal.Name = "txtSummarySubtotal";
            this.txtSummarySubtotal.Size = new System.Drawing.Size(274, 31);
            this.txtSummarySubtotal.TabIndex = 6;
            this.txtSummarySubtotal.TabStop = false;
            this.txtSummarySubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummarySubtotal
            // 
            this.lblSummarySubtotal.AutoSize = true;
            this.lblSummarySubtotal.Location = new System.Drawing.Point(162, 192);
            this.lblSummarySubtotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSummarySubtotal.Name = "lblSummarySubtotal";
            this.lblSummarySubtotal.Size = new System.Drawing.Size(97, 25);
            this.lblSummarySubtotal.TabIndex = 4;
            this.lblSummarySubtotal.Text = "Subtotal:";
            // 
            // txtSummaryOptions
            // 
            this.txtSummaryOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummaryOptions.Location = new System.Drawing.Point(272, 123);
            this.txtSummaryOptions.Margin = new System.Windows.Forms.Padding(6);
            this.txtSummaryOptions.Name = "txtSummaryOptions";
            this.txtSummaryOptions.Size = new System.Drawing.Size(274, 31);
            this.txtSummaryOptions.TabIndex = 6;
            this.txtSummaryOptions.TabStop = false;
            this.txtSummaryOptions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryOptions
            // 
            this.lblSummaryOptions.AutoSize = true;
            this.lblSummaryOptions.Location = new System.Drawing.Point(166, 131);
            this.lblSummaryOptions.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSummaryOptions.Name = "lblSummaryOptions";
            this.lblSummaryOptions.Size = new System.Drawing.Size(92, 25);
            this.lblSummaryOptions.TabIndex = 2;
            this.lblSummaryOptions.Text = "Options:";
            // 
            // txtSummaryVehicleSalePrice
            // 
            this.txtSummaryVehicleSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummaryVehicleSalePrice.Location = new System.Drawing.Point(272, 63);
            this.txtSummaryVehicleSalePrice.Margin = new System.Windows.Forms.Padding(6);
            this.txtSummaryVehicleSalePrice.Name = "txtSummaryVehicleSalePrice";
            this.txtSummaryVehicleSalePrice.Size = new System.Drawing.Size(274, 31);
            this.txtSummaryVehicleSalePrice.TabIndex = 0;
            this.txtSummaryVehicleSalePrice.TabStop = false;
            this.txtSummaryVehicleSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryVehicleSalePrice
            // 
            this.lblSummaryVehicleSalePrice.AutoSize = true;
            this.lblSummaryVehicleSalePrice.Location = new System.Drawing.Point(64, 65);
            this.lblSummaryVehicleSalePrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSummaryVehicleSalePrice.Name = "lblSummaryVehicleSalePrice";
            this.lblSummaryVehicleSalePrice.Size = new System.Drawing.Size(196, 25);
            this.lblSummaryVehicleSalePrice.TabIndex = 0;
            this.lblSummaryVehicleSalePrice.Text = "Vehicle\'sSalePrice:";
            // 
            // gbFinance
            // 
            this.gbFinance.Controls.Add(this.lblFinanceMonthlyPaymentSum);
            this.gbFinance.Controls.Add(this.lblFinanceMonthlyPayment);
            this.gbFinance.Controls.Add(this.nudFinanceAnnualInterestRate);
            this.gbFinance.Controls.Add(this.nudFinaceNoofYears);
            this.gbFinance.Controls.Add(this.lblFinanceAnnualInterestRate);
            this.gbFinance.Controls.Add(this.lblFinanceNoofYears);
            this.gbFinance.Location = new System.Drawing.Point(564, 587);
            this.gbFinance.Margin = new System.Windows.Forms.Padding(6);
            this.gbFinance.Name = "gbFinance";
            this.gbFinance.Padding = new System.Windows.Forms.Padding(6);
            this.gbFinance.Size = new System.Drawing.Size(626, 219);
            this.gbFinance.TabIndex = 7;
            this.gbFinance.TabStop = false;
            this.gbFinance.Text = "Finance";
            // 
            // lblFinanceMonthlyPaymentSum
            // 
            this.lblFinanceMonthlyPaymentSum.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblFinanceMonthlyPaymentSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinanceMonthlyPaymentSum.Location = new System.Drawing.Point(406, 135);
            this.lblFinanceMonthlyPaymentSum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFinanceMonthlyPaymentSum.Name = "lblFinanceMonthlyPaymentSum";
            this.lblFinanceMonthlyPaymentSum.Size = new System.Drawing.Size(168, 37);
            this.lblFinanceMonthlyPaymentSum.TabIndex = 5;
            this.lblFinanceMonthlyPaymentSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinanceMonthlyPayment
            // 
            this.lblFinanceMonthlyPayment.AutoSize = true;
            this.lblFinanceMonthlyPayment.Location = new System.Drawing.Point(400, 85);
            this.lblFinanceMonthlyPayment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFinanceMonthlyPayment.Name = "lblFinanceMonthlyPayment";
            this.lblFinanceMonthlyPayment.Size = new System.Drawing.Size(178, 25);
            this.lblFinanceMonthlyPayment.TabIndex = 4;
            this.lblFinanceMonthlyPayment.Text = "Monthly Payment";
            // 
            // nudFinanceAnnualInterestRate
            // 
            this.nudFinanceAnnualInterestRate.DecimalPlaces = 2;
            this.nudFinanceAnnualInterestRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudFinanceAnnualInterestRate.Location = new System.Drawing.Point(228, 135);
            this.nudFinanceAnnualInterestRate.Margin = new System.Windows.Forms.Padding(6);
            this.nudFinanceAnnualInterestRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudFinanceAnnualInterestRate.Name = "nudFinanceAnnualInterestRate";
            this.nudFinanceAnnualInterestRate.Size = new System.Drawing.Size(130, 31);
            this.nudFinanceAnnualInterestRate.TabIndex = 8;
            this.nudFinanceAnnualInterestRate.Value = new decimal(new int[] {
            500,
            0,
            0,
            131072});
            // 
            // nudFinaceNoofYears
            // 
            this.nudFinaceNoofYears.Location = new System.Drawing.Point(48, 135);
            this.nudFinaceNoofYears.Margin = new System.Windows.Forms.Padding(6);
            this.nudFinaceNoofYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFinaceNoofYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFinaceNoofYears.Name = "nudFinaceNoofYears";
            this.nudFinaceNoofYears.Size = new System.Drawing.Size(126, 31);
            this.nudFinaceNoofYears.TabIndex = 7;
            this.nudFinaceNoofYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblFinanceAnnualInterestRate
            // 
            this.lblFinanceAnnualInterestRate.AutoSize = true;
            this.lblFinanceAnnualInterestRate.Location = new System.Drawing.Point(222, 60);
            this.lblFinanceAnnualInterestRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFinanceAnnualInterestRate.Name = "lblFinanceAnnualInterestRate";
            this.lblFinanceAnnualInterestRate.Size = new System.Drawing.Size(134, 50);
            this.lblFinanceAnnualInterestRate.TabIndex = 1;
            this.lblFinanceAnnualInterestRate.Text = "Annual \r\nInterest Rate";
            // 
            // lblFinanceNoofYears
            // 
            this.lblFinanceNoofYears.AutoSize = true;
            this.lblFinanceNoofYears.Location = new System.Drawing.Point(42, 85);
            this.lblFinanceNoofYears.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFinanceNoofYears.Name = "lblFinanceNoofYears";
            this.lblFinanceNoofYears.Size = new System.Drawing.Size(132, 25);
            this.lblFinanceNoofYears.TabIndex = 0;
            this.lblFinanceNoofYears.Text = "No. of Years";
            // 
            // btnCalculateQuote
            // 
            this.btnCalculateQuote.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCalculateQuote.Location = new System.Drawing.Point(948, 835);
            this.btnCalculateQuote.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalculateQuote.Name = "btnCalculateQuote";
            this.btnCalculateQuote.Size = new System.Drawing.Size(240, 56);
            this.btnCalculateQuote.TabIndex = 9;
            this.btnCalculateQuote.Text = "Calculate Quote";
            this.btnCalculateQuote.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // SalesQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 992);
            this.Controls.Add(this.btnCalculateQuote);
            this.Controls.Add(this.gbFinance);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpExteriorFinish);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.txtTradeInValue);
            this.Controls.Add(this.lblTradeInValue);
            this.Controls.Add(this.txtVehicleSalePrice);
            this.Controls.Add(this.lblVehicleSalePrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SalesQuoteForm";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.RightToLeftLayout = true;
            this.Text = "Vehicle Sales Quote";
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.grpExteriorFinish.ResumeLayout(false);
            this.grpExteriorFinish.PerformLayout();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.gbFinance.ResumeLayout(false);
            this.gbFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinanceAnnualInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinaceNoofYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehicleSalePrice;
        private System.Windows.Forms.TextBox txtVehicleSalePrice;
        private System.Windows.Forms.Label lblTradeInValue;
        private System.Windows.Forms.TextBox txtTradeInValue;
        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.CheckBox cbAccessoriesComputerNavigation;
        private System.Windows.Forms.CheckBox cbAccessoriesLeatherInterior;
        private System.Windows.Forms.CheckBox cbAccessoriesStereoSystem;
        private System.Windows.Forms.GroupBox grpExteriorFinish;
        private System.Windows.Forms.RadioButton rbExteriorFinishCustomizedDetailing;
        private System.Windows.Forms.RadioButton rbExteriorFinishPearlized;
        private System.Windows.Forms.RadioButton rbExteriorFinishStandard;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label lblSummaryVehicleSalePrice;
        private System.Windows.Forms.Label lblSummaryOptions;
        private System.Windows.Forms.TextBox txtSummaryVehicleSalePrice;
        private System.Windows.Forms.Label lblSummaryTotal;
        private System.Windows.Forms.TextBox txtSummarySalesTax;
        private System.Windows.Forms.Label lblSummarySalesTax;
        private System.Windows.Forms.TextBox txtSummarySubtotal;
        private System.Windows.Forms.Label lblSummarySubtotal;
        private System.Windows.Forms.TextBox txtSummaryOptions;
        private System.Windows.Forms.Label lblSummaryAmountDue;
        private System.Windows.Forms.TextBox txtSummaryTradeIn;
        private System.Windows.Forms.Label lblSummaryTradeIn;
        private System.Windows.Forms.TextBox txtSummaryTotal;
        private System.Windows.Forms.GroupBox gbFinance;
        private System.Windows.Forms.Label lblFinanceAnnualInterestRate;
        private System.Windows.Forms.Label lblFinanceNoofYears;
        private System.Windows.Forms.NumericUpDown nudFinaceNoofYears;
        private System.Windows.Forms.NumericUpDown nudFinanceAnnualInterestRate;
        private System.Windows.Forms.Label lblFinanceMonthlyPaymentSum;
        private System.Windows.Forms.Label lblFinanceMonthlyPayment;
        private System.Windows.Forms.Button btnCalculateQuote;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblSummaryAmountDueSum;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}