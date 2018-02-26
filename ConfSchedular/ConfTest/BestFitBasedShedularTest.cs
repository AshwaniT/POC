using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conf;
using NUnit.Framework;

namespace ConfTest
{
    [TestFixture]
   public class BestFitBasedShedularTest
    {

        [Test]
        public void Create_Conf_For_Given_Example()
        {
          
            var input =string.Format("Writing Fast Tests Against Enterprise Rails 60min{0}Overdoing it in Python 45min{0}Lua for the Masses 30min{0}Ruby Errors from Mismatched Gem Versions 45min{0}Common Ruby Errors 45min{0}Rails for Python Developers lightning{0}Communicating Over Distance 60min{0}Accounting-Driven Development 45min{0}Woah 30min{0}Sit Down and Write 30min{0}Pair Programming vs Noise 45min{0}Rails Magic 60min{0}Ruby on Rails: Why We Should Move On 60min{0}Clojure Ate Scala (on my project) 45min{0}Programming in the Boondocks of Seattle 30min{0}Ruby vs. Clojure for Back-End Development 30min{0}Ruby on Rails Legacy App Maintenance 60min{0}A World Without HackerNews 30min{0}User Interface CSS in Rails Apps 30min",Environment.NewLine);
            var result = new BestFitBasedShedular(new RegexParser()).Schedule(input);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(result));
            Assert.IsTrue(!result.Equals(Constants.Message.NoTrackAvailable));
            Assert.IsTrue(result.Contains(Constants.LunchExpression));
            Assert.IsTrue(result.Contains(Constants.NWExpression));
        }

        [Test]
        public void Add_Large_Talk_To_Fit()
        {
            var result = new BestFitBasedShedular(new RegexParser()).Schedule("To large to fit 400");
            Assert.IsTrue(result.Equals(Constants.Message.NoTrackAvailable));
        }

    }
}
