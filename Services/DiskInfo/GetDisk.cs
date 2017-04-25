using System;
using System.IO;
using System.Linq;


namespace DiskInfo
{
    class GetDisk : IGetDisk
    {
        string _path;
        public string[] GetDiskInfo(string path)
        {
             _path = path;
            try
            {

                string[] dirs = Directory.GetFileSystemEntries(_path).Select(x => Path.GetFileName(x)).ToArray();

                //  string[] files = Directory.GetFiles(_path);
                return dirs;
                
            }
            catch (DirectoryNotFoundException e)
            {
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
                return null;
            }
           
        }
     
    }
}
