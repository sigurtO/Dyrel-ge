using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WinFormsApp1.Objects;

namespace WinFormsApp1.Tests
{
    [TestClass]
    public class InvoiceTests
    {
        [TestMethod]
        public void InvoiceClass_Properties_SetCorrectly()
        {
            var invoice = new InvoiceClass(4, 1, 3, 2, 6, 5, DateTime.Now, 10.05m, 100.50m, 90.45m);
  

            Assert.AreEqual(1, invoice.OwnerID);
            Assert.AreEqual(2, invoice.PetID);
            Assert.AreEqual(3, invoice.ConsultationID);
            Assert.AreEqual(4, invoice.TreatmentID);
            Assert.AreEqual(5, invoice.CageID);
            Assert.AreEqual(6, invoice.ItemID);
            Assert.AreEqual(100.50m, invoice.TotalAmount);
            Assert.AreEqual(90.45m, invoice.NetAmount);
            Assert.AreEqual(10.05m, invoice.Discount);
        }

        [TestMethod]
        public void CalculateNetAmount_WithZeroDiscount_ReturnsSameAsTotal()
        {
            decimal totalAmount = 150.00m;
            decimal discountPercentage = 0m;

            decimal netAmount = CalculateNetAmount(totalAmount, discountPercentage);

            Assert.AreEqual(150.00m, netAmount);
        }

        [TestMethod]
        public void CalculateNetAmount_With50PercentDiscount_ReturnsHalf()
        {
            decimal totalAmount = 200.00m;
            decimal discountPercentage = 50m;

            decimal netAmount = CalculateNetAmount(totalAmount, discountPercentage);

            Assert.AreEqual(100.00m, netAmount);
        }

        [TestMethod]
        public void CalculateNetAmount_WithInvalidTotal_ReturnsZero()
        {
        
            string invalidTotal = "invalid";
            decimal discountPercentage = 10m;

            
            decimal netAmount = 0m;
            bool success = decimal.TryParse(invalidTotal, out decimal parsedTotal);
            if (success)
            {
                netAmount = CalculateNetAmount(parsedTotal, discountPercentage);
            }


            Assert.AreEqual(0m, netAmount);
        }

        private decimal CalculateNetAmount(decimal totalAmount, decimal discountPercentage)
        {
            return totalAmount * (1 - discountPercentage / 100m);
        }
    }
}