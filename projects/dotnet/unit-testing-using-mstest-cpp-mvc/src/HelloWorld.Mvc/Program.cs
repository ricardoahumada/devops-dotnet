using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HelloWorld.Mvc {
    public class Program {
        // [DllImport ("my-cpp-libraries.dll")]
        [DllImport (@"./cpp/cpp-calculator.dll")]
        static public extern void UsingCalculator ();

        [DllImport (@"./cpp/cpp-calculator.dll")]
        static public extern int add (int a,int b);

        public static void Main (string[] args) {

            UsingCalculator ();
            Console.WriteLine(add (3,4));
            
            CreateWebHostBuilder (args).Build ().Run ();

        }

        public static IWebHostBuilder CreateWebHostBuilder (string[] args) =>
            WebHost.CreateDefaultBuilder (args)
            .UseStartup<Startup> ();
    }
}