using System;

namespace Conf
{
   public  class Talk
    {
       public string Name { get; set; }
       public int Duration { get; set; }
       public  DateTime? StarTime { get; set; }
       public override string ToString()
       {
           return string.Format("{0} {1}", StarTime.HasValue? StarTime.Value.ToShortTimeString():string.Empty, Name);
       }

       public override bool Equals(object obj)
       {
           var other = obj as Talk;
           if (other == null) return false;
           return Name.Equals(other.Name) && Duration == other.Duration;
       }
    }
}
