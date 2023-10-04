using ACE.BIT.ADEV.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yang.Jiajia.Business;

/*
 * Name: Jiajia Yang
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 5
 * Created: 2023-03-19
 * Updated: 2023-03-19
 */


namespace Yang.Jiajia.RRCAGApp
{
    public partial class MainForm : Form
    {
        public  MainForm()
        {
            InitializeComponent();

            this.IsMdiContainer = true;

            //File

            //File->Open->Sales Quote
            this.mnuSalesQuote.Click += MnuSalesQuote_Click;

            //File->Open->Car Wash
            this.mnuCarWash.Click += MnuCarWash_Click;

            
            //File->Exit
            this.mnuExit.Click += MnuExit_Click;

            //Data->Vehicles
            this.mnuVehicles.Click += MnuVehicles_Click;

            //Help->About...
            this.mnuAbout.Click += MnuAbout_Click;

        }
        



        /// <summary>
        /// Handles the event when the users click the menu Sales Quote.
        /// </summary>
        private void MnuSalesQuote_Click(object sender, EventArgs e)
        {
            SalesQuoteForm form = new SalesQuoteForm();
            form.MdiParent = this;
            form.Show();
        }

        /// <summary>
        /// Handles the event when the users click the menu car wash.
        /// </summary>
        private void MnuCarWash_Click(object sender, EventArgs e)
        {
            CarWashForm form = new CarWashForm();
            form.MdiParent = this;

            // if not throw exception, then show the message box
            try
            {
                form.Show();// show() method is used to display the form, also can operate the parent form, ShowDialog() only can operate the child form

            }
            catch
            {
                //nothing
            }

            
        }


        /// <summary>
        /// Handles the event when the user clicks the About menu Exit.
        /// </summary>
        private void MnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the event when users click the menu Vehicles.
        /// </summary>
        private void MnuVehicles_Click(object sender, EventArgs e)
        {
            VehicleDataForm form = new VehicleDataForm();
            form.MdiParent = this;
            form.Show();
        }


        /// <summary>
        /// Event handler for the About menu item
        /// </summary>
        private void MnuAbout_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();

            form.ShowDialog();
        }

       
       
    }
}
