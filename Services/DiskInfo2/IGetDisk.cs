
using System.ServiceModel;

namespace DiskInfo2
{
     [ServiceContract]
    public interface IGetDisk
    {
        [OperationContract]
        string[] GetDiskInfo(string path);
       

    }
}
