﻿using System.Net;

namespace AsynchronusDemonstration01
{
    internal class Program
    {
        private static void DownloadAsynchronously()
        {
            WebClient client = new WebClient();
            client.DownloadStringCompleted +=
                new DownloadStringCompletedEventHandler(DownloadComplete);
            client.DownloadStringAsync(new Uri("http://www.aspnet.com"));
        }

        private static void DownloadComplete(object sender, DownloadStringCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                Console.WriteLine("Some error has occured.");
                return;
            }
            //Print result
            Console.WriteLine(e.Result);
            Console.WriteLine(new string('*', 30));
            Console.WriteLine("Download completed.");
        }

        static void Main(string[] args)
        {
            DownloadAsynchronously();
            Console.WriteLine("Main thread : Done");
            Console.WriteLine(new string('*', 30));
            Console.ReadLine();
        }
    }
}
