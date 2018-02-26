using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conf
{
   public class Session
   {
       public readonly DateTime startTime;
       private  int durationInMinute { get; set; }
       private List<Talk> Talks { get; set; }
       public Session(DateTime StartTime, int duration)
       {
           startTime = StartTime;
           durationInMinute = duration;
           Talks=new List<Talk>();
       }

       public bool HasTalk
       {
           get
           {
               return Talks.Any();
           }
       }
       public bool CanAdd(Talk talk)
       {
           return durationInMinute >= talk.Duration;
       }
       public void AddTalk(Talk talk)
       {
           if(!CanAdd(talk))
               throw new  NoSlotAvailableException();
           durationInMinute -= talk.Duration;
           talk.StarTime = GetStarTime();
           Talks.Add(talk);
       }

       public void AddTalkInSpecificTime(DateTime startTimeMin, DateTime startTimeMax,Talk talk)
       {
           if (!Talks.Any())
           {

               talk.StarTime = startTimeMin;
               Talks.Add(talk);
               return;
           }
           var lastTalk = Talks.OrderByDescending(x => x.StarTime).First();
           if (lastTalk.StarTime.Value.AddMinutes(lastTalk.Duration) <= startTimeMin)
           {
               talk.StarTime = startTimeMin;
               Talks.Add(talk);
               return;
           }
           talk.StarTime = lastTalk.StarTime.Value.AddMinutes(lastTalk.Duration) < startTimeMax ? lastTalk.StarTime.Value.AddMinutes(lastTalk.Duration) : startTimeMax;
           Talks.Add(talk);
       }
       private DateTime GetStarTime()
       {
           if (!Talks.Any())
               return startTime;
           var lastTalk = Talks.OrderByDescending(x => x.StarTime).First();
           return lastTalk.StarTime.Value.AddMinutes(lastTalk.Duration);
       }

       public override string ToString()
       {
           var sb = new StringBuilder();
           foreach (var talk in Talks.OrderBy(x=>x.StarTime))
           {
               sb.AppendFormat("{0} {1}",talk,Environment.NewLine);
           }
           return sb.ToString();
       }
   }
}
