﻿namespace EvolveDirectoryCleaner
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
            //int deleted = 0;
            string[] list = Directory.GetFiles(@"C:\Users\IJHol\Desktop\testing", "*.*", SearchOption.AllDirectories);
            foreach (string file in list)
            {

                if (file.Contains(".txt"))
                {
                    File.Delete(file);
                    //deleted++;
                }

            }
            //Console.WriteLine(deleted); 





        }
    }
}