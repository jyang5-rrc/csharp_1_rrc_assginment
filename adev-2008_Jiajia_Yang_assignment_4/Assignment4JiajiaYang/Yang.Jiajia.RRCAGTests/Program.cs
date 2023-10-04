using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yang.Jiajia.Business;

namespace Yang.Jiajia.RRCAGTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SalesQuote-event-VehiclePriceChanged
            SalesQuote salesQuote = new SalesQuote(5000,1000,.12m, Accessories.StereoSystem, ExteriorFinish.Standard);

            salesQuote.VehiclePriceChanged += SalesQuote_VehiclePriceChanged;

            salesQuote.VehicleSalePrice = 5000;// This will not trigger the event
            salesQuote.VehicleSalePrice = 1000;
            
            //SalesQuote-event-TradeInAmountChanged
            salesQuote.TradeInAmountChanged += SalesQuote_TradeInAmountChanged;

            salesQuote.TradeInAmount = 1000;// This will not trigger the event
            salesQuote.TradeInAmount = 500;

            //SalesQuote-event- AccessoriesChosenChanged
            salesQuote.AccessoriesChosenChanged += SalesQuote_AccessoriesChosenChanged;

            salesQuote.AccessoriesChosen = Accessories.StereoSystem;// This will not trigger the event
            salesQuote.AccessoriesChosen = Accessories.LeatherInterior;

            //SalesQuote-event-ExteriorFinishChosenChanged
            salesQuote.ExteriorFinishChosenChanged += SalesQuote_ExteriorFinishChosenChanged;

            salesQuote.ExteriorFinishChosen = ExteriorFinish.Standard;// This will not trigger the event
            salesQuote.ExteriorFinishChosen = ExteriorFinish.Pearlized;

            //Invoice-event-ProvincialSalesTaxRateChanged
            CarWashInvoice invoice = new CarWashInvoice(.1m, .12m, 50, 60);

            invoice.ProvincialSalesTaxRateChanged += Invoice_ProvincialSalesTaxRateChanged;

            invoice.ProvincialSalesTaxRate = .1m;// This will not trigger the event
            invoice.ProvincialSalesTaxRate = 0.2m;

            //Invoice-event-GoodsAndServicesTaxRateChanged
            invoice.GoodsAndServicesTaxRateChanged += Invoice_GoodsAndServicesTaxRateChanged;

            invoice.GoodsAndServicesTaxRate = .12m;// This will not trigger the event
            invoice.GoodsAndServicesTaxRate = 0.6m;

            //CarWashInvoice-event-PackageCostChanged
            invoice.PackageCostChanged += Invoice_PackageCostChanged;

            invoice.PackageCost = 50;// This will not trigger the event
            invoice.PackageCost = 100;

            //CarWashInvoice-event-FragranceCostChanged
            invoice.FragranceCostChanged += Invoice_FragranceCostChanged;

            invoice.FragranceCost = 60;// This will not trigger the event
            invoice.FragranceCost = 200;

            // ****
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            
        }

        private static void SalesQuote_VehiclePriceChanged(object sender, EventArgs e)
        {
            Console.WriteLine("The vehicle price is changed.");
           
        }

        private static void SalesQuote_TradeInAmountChanged(object sender, EventArgs e)
        {
            Console.WriteLine("The trade in amount is changed.");
        }

        private static void SalesQuote_AccessoriesChosenChanged(object sender, EventArgs e)
        {
            Console.WriteLine("The accessories chosen is changed.");
        }

        private static void SalesQuote_ExteriorFinishChosenChanged(object sender, EventArgs e)
        {
            Console.WriteLine("The exterior finish chosen is changed.");
        }

        private static void Invoice_ProvincialSalesTaxRateChanged(object sender, EventArgs e)
        {
            Console.WriteLine("The provincial sales tax rate is changed.");
        }

        private static void Invoice_GoodsAndServicesTaxRateChanged(object sender, EventArgs e)
        {
            Console.WriteLine("The goods and services tax rate is changed.");
        }

        private static void Invoice_PackageCostChanged(object sender, EventArgs e)
        {
            Console.WriteLine("The package cost is changed.");
        }

        private static void Invoice_FragranceCostChanged(object sender, EventArgs e)
        {
            Console.WriteLine("The fragrance cost is changed.");
        }


    }
}
