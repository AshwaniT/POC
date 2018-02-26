
using System.ServiceModel;

namespace Core
{
    [ServiceContract(SessionMode = SessionMode.NotAllowed, Namespace = "http://www.kashwanitiwari.com")]
    public interface IService
    {
        void Close();
        void Open();
    }
}
