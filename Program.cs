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
            string[] directories = new string[] { @"C:\Users\IJHol\Desktop\TestingPrime\testing1", @"C:\Users\IJHol\Desktop\TestingPrime\testing2", @"C:\Users\IJHol\Desktop\TestingPrime\testing3" };
            foreach (string currentMain in directories)
            {
                string[] list = Directory.GetFiles(currentMain, "*.*", SearchOption.AllDirectories);
                foreach (string current in list)
                {
                    FileInfo file = new FileInfo(current);
                    DateTime dt = file.CreationTime;
                    if (dt < DateTime.Now.AddDays(-2))
                    {
                        File.Delete(current);
                    }
                }
            }
        }
    }
}//C:\Users\IJHol\Desktop\TestingPrime\testing1