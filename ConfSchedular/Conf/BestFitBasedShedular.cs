using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Conf
{
   public class BestFitBasedShedular: ISchedular
   {
       private readonly IParser _parser;

       public BestFitBasedShedular(IParser parser)
       {
           _parser = parser;
       }
        public string Schedule(string data)
        {
            try
            {
                var Conference = new Conference();
                for (int i = 0; i < Constants.NumberOfTrack; i++)
                {
                    var talks = _parser.Parse(data);
                    if (talks == null)
                        return Constants.Message.NoTrackAvailable;
                    if (i%2 == 0)
                    {
                        var track = LongerTalkFirst(talks, string.Format(Constants.TrackNameFormat,i+1));
                        if (track != null)
                            Conference.AddTrack(track);
                        else
                        {
                            return Constants.Message.NoTrackAvailable;
                        }
                    }
                    else
                    {
                        var track = CreateTrack(talks, string.Format(Constants.TrackNameFormat, i + 1));
                        if (track != null)
                            Conference.AddTrack(track);
                        else
                        {
                            return Constants.Message.NoTrackAvailable;
                        }
                        
                    }
                }
                        
                return Conference.ToString();
            }
            catch (InvalidDataException)
            {
                return Constants.Message.InvalidEntry;
            }
        }

        private Track LongerTalkFirst(IEnumerable<Talk> talks, string name)
        {
          return CreateTrack(talks.OrderByDescending(x => x.Duration), name);
        }

        private Track CreateTrack(IEnumerable<Talk> talks, string name)
        {
            var track = new Track(name);
            var morningSession = new Session(Constants.MorningSessionStartTime, Constants.MorningDurationMins);
            var lunch = new Session(Constants.LunchStartTime, Constants.LunchDurationMins);
            var eveningsession = new Session(Constants.EveningStartTime, Constants.EveningDurationMins);

            foreach (var talk in talks)
            {
                if (morningSession.CanAdd(talk))
                {
                    morningSession.AddTalk(talk);
                }
                else if (eveningsession.CanAdd(talk))
                {
                    eveningsession.AddTalk(talk);
                }

            }
            if (!morningSession.HasTalk && !eveningsession.HasTalk)
                return null;      
            eveningsession.AddTalkInSpecificTime(Constants.NetworkMinStartTime, Constants.NetworkMaxStartTime, new Talk { Name = Constants.NWExpression, Duration = 1 });
            lunch.AddTalk(new Talk { Duration = Constants.LunchDurationMins, StarTime = Constants.LunchStartTime, Name = Constants.LunchExpression });
            track.AddSession(morningSession);
            track.AddSession(lunch);
            track.AddSession(eveningsession);
            return track;
        }
        
    }
}
