using System.ServiceModel;

namespace Core
{
  [ServiceContract(SessionMode = SessionMode.NotAllowed)]
  public interface IDemoService
    {
        [OperationContract]
        string Greetings();
    }
}
