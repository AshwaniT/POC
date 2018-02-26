
using Conf;
using NUnit.Framework;

namespace ConfTest
{
   [TestFixture]
   public class RegexParserTest
    {
       [TestCase("I am valid talk 30min", true)]
       [TestCase("how about lightning", true)]
       [TestCase("invalkid one", false)]
       public void Isvalid(string line, bool result)
       {
           var res = new RegexParser().Valid(line);
           Assert.AreEqual(res,result);
       }

       [Test]
       public void ParseTalk()
       {
           var expected = new Talk {Duration = 40, Name = "new talk for 40min"};
           var res = new RegexParser().ParseTalk("new talk for 40min");
           Assert.AreEqual(expected,res);
       }
    }
}
