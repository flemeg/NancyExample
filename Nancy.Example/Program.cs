namespace NancyExample.Hosting.Self
{
    using System;
    using System.Diagnostics;
    using Nancy.Hosting.Self;

    class Program
    {
        static void Main()
        {
            using (var nancyHost = new NancyHost(new Uri("http://localhost:8888/nancyexample/")))
            {
                nancyHost.Start();

                Console.WriteLine("Server now listening - navigating to http://localhost:8888/nancyexample/. Press enter to stop");
                try
                {
                    Process.Start("http://localhost:8888/nancyexample/");
                }
                catch (Exception)
                {
                }
                Console.ReadKey();
            }

            Console.WriteLine("Stopped");
        }
    }
}
