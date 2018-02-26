using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Conf
{
   public class RegexParser: IParser
    {
        public List<Talk> Parse(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
                return null;
            var talks = new List<Talk>();
            foreach (var line in data.Split(Constants.Seprator, StringSplitOptions.None).Where(x=>!string.IsNullOrWhiteSpace(x)).ToList())
            {
                if (!Valid(line))
                    throw new InvalidDataException();
                talks.Add(ParseTalk(line));

            }
            return talks;
        }

        public Talk ParseTalk(string line)
        {
            var talk = new Talk() { Name = line };
            if (line.ToLower().IndexOf(Constants.LightningExpression) != -1)
            {
                talk.Duration = 5;
            }
            else
            {
                var time = Constants.MinExpression.Match(line);
                talk.Duration = int.Parse(time.Value);
            }
            return talk;
        }


        public bool Valid(string line)
        {
            return Constants.MinExpression.IsMatch(line) || line.ToLower().IndexOf(Constants.LightningExpression) != -1;
        }
    }
}
