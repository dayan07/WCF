using System;
using System.ServiceModel;

namespace DiskInfo2
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(GetDisk));
            sh.Open();
            Console.WriteLine("Для завершения нажмите <ENTER>\n");
            Console.ReadLine();
            sh.Close();
        }
    }
}
