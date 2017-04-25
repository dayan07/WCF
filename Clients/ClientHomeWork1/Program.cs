using System;
using System.Linq;
using System.ServiceModel;


namespace ClientHomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IGetDisk> factory =
            new ChannelFactory<IGetDisk>(new
            WSHttpBinding(), 
            new EndpointAddress("http://localhost/GetDisk/Ep1"));
            IGetDisk channel = factory.CreateChannel();
            ChannelFactory<IGetDisk> factory2 =
           new ChannelFactory<IGetDisk>(new
           NetTcpBinding(),
           new EndpointAddress("net.tcp://localhost:8081/GetDisk/Ep2"));
            IGetDisk channel2 = factory2.CreateChannel();
            var path = @"D:\";
            var result = channel.GetDiskInfo(path);
            var result2 = channel2.GetDiskInfo(path);
            Console.WriteLine("Content for path on http: {0}\n", path);
            try
            {
                foreach (var item in result)
                {
                    if (item.Contains('.'))
                    {
                        Console.WriteLine("{0}   File\n", item);
                    }
                    else
                    {
                        Console.WriteLine("{0}   Directory\n", item);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            Console.WriteLine("***********************************************");
            Console.WriteLine();
            Console.WriteLine("Content for path on tcp: {0}\n", path);
            try
            {
                foreach (var item in result2)
                {
                    if (item.Contains('.'))
                    {
                        Console.WriteLine("{0}   File\n", item);
                    }
                    else
                    {
                        Console.WriteLine("{0}   Directory\n", item);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Для завершения нажмите <ENTER>\n");
            Console.ReadLine();
            factory.Close();
            factory2.Close();
        }
    }
}
