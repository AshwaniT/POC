using System;
using System.Text.RegularExpressions;

namespace Conf
{
   public class Constants
   {
       public static Regex MinExpression = new Regex(@"\d+", RegexOptions.IgnoreCase);
       public static string LightningExpression = "lightning";
       public static string LunchExpression = "Lunch";
       public static string NWExpression = "Networking Event";
       public static string TrackNameFormat = "Track {0}";
       public static int NumberOfTrack = 2;
       public static string[] Seprator = {Environment.NewLine};
       public static int RefYear = 2017;
       public static int RefMonth = 1;
       public static int RefDate = 1;
       public static DateTime MorningSessionStartTime = new DateTime(RefYear, RefMonth, RefDate, 9, 0, 0);
       public static int MorningDurationMins = 180;
       public static DateTime EveningStartTime = new DateTime(RefYear, RefMonth, RefDate, 13, 0, 0);
       public static int EveningDurationMins = 240;
       public static DateTime LunchStartTime = new DateTime(RefYear, RefMonth, RefDate, 12, 0, 0);
       public static int LunchDurationMins = 60;
       public static DateTime NetworkMinStartTime = new DateTime(RefYear, RefMonth, RefDate, 16, 0, 0);
       public static DateTime NetworkMaxStartTime = new DateTime(RefYear, RefMonth, RefDate, 17, 0, 0);

       public static class Message
       {
           public static string NoTrackAvailable = "No track available.";
           public static string InvalidEntry = "Some entries are not valid.";
           public static string CanNotAcomodateTalk = "We cant acomodate {0}, suspending track.";
       }
       
   }
}
