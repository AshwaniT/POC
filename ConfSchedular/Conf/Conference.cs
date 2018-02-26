using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conf
{
   public class Conference
    {
       private  List<Track> Tracks { get; set; }
       public Conference()
       {
           Tracks=new List<Track>();
       }

       public void AddTrack(Track track)
       {
           Tracks.Add(track);
       }

       public bool HasTrack()
       {
           return Tracks.Any();
       }
       public override string ToString()
       {
           var sb = new StringBuilder();
           foreach (var track in Tracks)
           {
               sb.Append(track);
           }
           return sb.ToString();
       }
 
    }
}
