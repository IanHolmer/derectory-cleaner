namespace EvolveDirectoryCleaner
{
    using System;
    using System.IO;
    using System.Collections;
    internal class Program
    {
        /*
        When launched, this application should loop through an array of directory locations (one at a time), find all files in that directory older than X days or Y time, etc., and delete them.         
        */

        public static void Main(string[] args)
        {
            string[] list = Directory.GetFiles(@"C:\Users\IJHol\Desktop\testing1", "*.*", SearchOption.AllDirectories);
            foreach (string current in list)
            {
                FileInfo file = new FileInfo(current);
                DateTime dt = file.CreationTime;
                if (dt < DateTime.Now.AddDays(-5))
                {
                    File.Delete(current);
                }
            }
        }
    }
}