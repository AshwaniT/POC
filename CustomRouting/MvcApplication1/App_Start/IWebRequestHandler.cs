using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication1.App_Start
{
    public interface IWebRequestHandler
    {
        void NotifyError(object sender, EventArgs e);
        void NotifyEndRequest(object sender, EventArgs e);
        void NotifyBeginRequest(object sender, EventArgs e);
    }
}
