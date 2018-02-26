using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MvcApplication1.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var product = new CustomizedProduct();
            var repository = new Mock<ICustomizableRepository>();
            repository.Setup(x => x.IsCustomizable(It.IsAny<string>())).Returns(true);
            repository.Setup(x => x.Save(It.IsAny<CustomizedProduct>())).Returns(product);
            var res = new CustomizableService(repository.Object).Save(product);
            Assert.IsNotNull(res);

        }
    }
}
