using System;
using System.ServiceModel;


namespace DiskInfo
{
    class Program
    {

        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(GetDisk));
            sh.AddServiceEndpoint(typeof(IGetDisk), //контракт
                            new WSHttpBinding(),  //тип привязки
                            "http://localhost/GetDisk/Ep1"); //адрес и имя оконечной точки
            sh.AddServiceEndpoint(typeof(IGetDisk), //контракт
                                new NetTcpBinding(),  //тип привязки
                                "net.tcp://localhost:8081/GetDisk/Ep2"); //адрес и имя оконечной точки'
            sh.Open();
           
            Console.WriteLine("Для завершения нажмите <ENTER>\n");
            Console.ReadLine();
            sh.Close();
          

        }
    }
}
