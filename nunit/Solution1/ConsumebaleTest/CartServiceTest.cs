using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using Moq;
using Consumable;

namespace ConsumebaleTest
{
    [TestFixture]
   public class CartTest
    {
        [Test]
        public void Can_Add_Product_New_Cart()
        {
           // var mockIProductService = new Mock<IProductService>();
            var testInstannce = new Cart(new ProductServiceImpl(),new PriceCalCulator(null));
           // mockIProductService.Setup(x => x.GetProductUnitPrice(It.IsAny<string>())).Returns(30);
            testInstannce.AddProducts(new List<Product>(){new Product() { Name = "Dove Soap", Quantity = 5 }});
            
            Assert.AreEqual(testInstannce.Products.Where(X => X.Name.Equals("Dove Soap")).Sum(z=>z.Quantity) , 5);
            Assert.AreEqual(testInstannce.CartTotal, 150);
        }

        [Test]
        public void Dove_Soap_offer_Test()
        {
            var testInstannce = new Cart(new ProductServiceImpl(), new PriceCalCulator(new List<Offer>() {  new  Offer(){ Get=1, Buy=2, ProductName="Dove Soap"}}));
            // mockIProductService.Setup(x => x.GetProductUnitPrice(It.IsAny<string>())).Returns(30);
            testInstannce.AddProducts(new List<Product>() { new Product() { Name = "Dove Soap", Quantity = 3 } });
            Assert.AreEqual(testInstannce.CartTotal, 60);
        }

        [Test]
        public void Dove_Soap_offer_Test_5()
        {
            var testInstannce = new Cart(new ProductServiceImpl(), new PriceCalCulator(new List<Offer>() { new Offer() { Get = 1, Buy = 2, ProductName = "Dove Soap" } }));
            // mockIProductService.Setup(x => x.GetProductUnitPrice(It.IsAny<string>())).Returns(30);
            testInstannce.AddProducts(new List<Product>() { new Product() { Name = "Dove Soap", Quantity = 5 } });
            Assert.AreEqual(testInstannce.CartTotal, 120);
        }

        [Test]
        public void Dove_Soap_offer_Test_With_Axe()
        {
            var testInstannce = new Cart(new ProductServiceImpl(), new PriceCalCulator(new List<Offer>() { new Offer() { Get = 1, Buy = 2, ProductName = "Dove Soap" } }));
            // mockIProductService.Setup(x => x.GetProductUnitPrice(It.IsAny<string>())).Returns(30);
            testInstannce.AddProducts(new List<Product>() { new Product() { Name = "Dove Soap", Quantity = 3 }, new Product() { Name = "Axe Deos", Quantity = 2 } });
            Assert.AreEqual(testInstannce.CartTotal, 260);
        }
    }
}
