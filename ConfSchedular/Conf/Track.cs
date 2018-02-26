using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conf
{
    public class Track
    {
        private List<Session> Sessions { get; set; }
        private readonly string _name;

        public Track(string name)
        {
            _name = name;
            Sessions = new List<Session>();
        }

        public void AddSession(Session session)
        {
            Sessions.Add(session);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0} {1}", _name, Environment.NewLine);
            foreach (var s in Sessions.OrderBy(x=>x.startTime))
            {
                sb.Append(s);
            }
            return sb.ToString();
        }
    }
}
