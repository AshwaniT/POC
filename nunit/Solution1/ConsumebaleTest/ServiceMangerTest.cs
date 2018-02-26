//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Consumable;
//using Moq;

//namespace ConsumebaleTest
//{
//    [TestFixture]    
//   public class ServiceMangerTest
//    {
//        [SetUp]
//        public void INIT()
//        {
//        }
//        [TearDown]
//        public void Des()
//        {
//        }
//        [Test]
//        public void Test_For_MoQ()
//        {
//            var obj = new Moq.Mock<IService>();
//            var test = new ServiceManger(obj.Object);
//            obj.Setup(x => x.GetResponse(It.IsAny<string>())).Returns<string>(x => x);
//           var res= test.GetAnswer("a");
//           Assert.AreEqual(res, "a");
//        }
//        [Test]
//        public void Test_For_exception()
//        {
//            var obj = new Moq.Mock<IService>();
//            var test = new ServiceManger(obj.Object);
//            obj.Setup(x => x.GetResponse(It.IsAny<string>())).Returns<string>(x => x);
//            Assert.Throws<ArgumentNullException>(()=>test.GetAnswer(string.Empty));
//        }

//        [Test]
//        public void Test_For_Verifiable()
//        {
//            const string a = "a";
//            var obj = new Moq.Mock<IService>();
//            var test = new ServiceManger(obj.Object);
//            obj.Setup(x => x.GetResponse(It.IsAny<string>())).Returns<string>(x => x);
//            test.GetAnswer(a);
//            obj.Verify(x => x.GetResponse(a));
//        }

//        [TestCase(1,2,3)]
//        [TestCase(5, 2, 7)]
//        [TestCase(9, 2, 11)]
//        public void Test_For_Verifiable(int a, int b, int c)
//        {
//            Assert.AreEqual(a + b, c);
//        }

//    }
//}
