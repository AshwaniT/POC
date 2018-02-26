using System.ServiceModel;

namespace Core
{
   public interface IWshttpServiceClient: IService
    {
        WSHttpBinding Binding { get; }
        EndpointAddress Endpoint { get; }
    }
}
