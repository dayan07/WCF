using System.ServiceModel;


namespace ClientHomeWork1
{
    [ServiceContract]
    public interface IGetDisk
    {
        [OperationContract]
        string[] GetDiskInfo(string path);


    }
}
