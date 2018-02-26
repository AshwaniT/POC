using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumable
{
   public class ServiceManger
    {
       private readonly IService _service;
       public ServiceManger(IService service)
       {
           _service = service;
       }

       public string GetAnswer(string question)
       {
           if (string.IsNullOrWhiteSpace(question))
           {
               throw new ArgumentNullException();
           }
           return _service.GetResponse(question);
       }
    }
}
