
using System;
using Conf;
using NUnit.Framework;


namespace ConfTest
{
    [TestFixture]
  public class SessionTest
    {
        [TestCase(60, 70,  false)]
        [TestCase(0, 0, true)]
        [TestCase(10, 5, true)]
        public void CanAddTalk(int sessiontime, int talkone,  bool result)
        {
            var session = new Session(DateTime.Now, sessiontime);
            var res = session.CanAdd(new Talk() { Duration = talkone });

            Assert.AreEqual(res, result);
        }
        [TestCase(60,20,41,false)]
        [TestCase(20, 4, 3, true)]
        [TestCase(60, 20, 40, true)]
        [TestCase(60, 0, 0, true)]
        [TestCase(60, 70, 0, false)]
        public void CanAddMultiple(int sessiontime, int talkone, int talktwo, bool result)
        {
            var session = new Session(DateTime.Now, sessiontime);
            var res = session.CanAdd(new Talk() {Duration = talkone});
            if (res)
            {
                session.AddTalk(new Talk() { Duration = talkone });
                res = session.CanAdd(new Talk() { Duration = talktwo });
            }
           
             Assert.AreEqual(res,result);
        }
    }
}
