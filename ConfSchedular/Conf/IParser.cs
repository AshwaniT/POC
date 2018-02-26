
using System.Collections.Generic;

namespace Conf
{
   public interface IParser
   {
       List<Talk> Parse(string data);
       bool Valid(string line);
       Talk ParseTalk(string line);
   }
}
