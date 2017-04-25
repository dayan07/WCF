using System.ServiceModel;

namespace DiskInfo
{
     [ServiceContract]
    public interface IGetDisk
    {
        [OperationContract]
        string[] GetDiskInfo(string path);
       

    }
}
