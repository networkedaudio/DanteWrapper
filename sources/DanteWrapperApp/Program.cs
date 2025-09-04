using System;
using System.Threading.Tasks;
using DanteWrapperLibrary;

namespace DanteWrapperApp
{
    internal class Program
    {
        private static void Main()
        {

  

            GetDeviceListAsync();

            /*
            using var device = new DanteBrowsing();
            foreach (var name in await DanteBrowsing.GetDeviceNamesAsync())

                DanteWrapperLibrary.RoutingDevice deviceInfo = new DanteWrapperLibrary.RoutingDevice(deviceNames[0]);

            foreach (var info in deviceInfo.GetRxChannels())
            {
                Console.WriteLine($"Id: {info.Id}");
                Console.WriteLine($"IsStale: {info.IsStale}");
                Console.WriteLine($"Name: {info.Name}");
                Console.WriteLine($"Format: {info.Format}");
                Console.WriteLine($"Latency: {info.Latency}");
                Console.WriteLine($"IsMuted: {info.IsMuted}");
                Console.WriteLine($"SignalReferenceLevel: {info.SignalReferenceLevel}");
                Console.WriteLine($"Subscription: {info.Subscription}");
                Console.WriteLine($"Status: {info.Status}");
                Console.WriteLine($"Flow: {info.Flow}");
                Console.WriteLine();
            }

            */
            Console.ReadLine();
        }
        private static async Task GetDeviceListAsync()
        {

            var foundNames = await DanteBrowsing.GetDeviceNamesAsync(new TimeSpan(0, 0, 1));

            foreach (var name in foundNames)
            {
                Console.WriteLine(name);

                RoutingDevice deviceInfo = new RoutingDevice(name);


                var labels = deviceInfo.GetTxLabels();

                foreach (var info in deviceInfo.GetRxChannels())
                {
                    Console.WriteLine($"Id: {info.Id}");
                    Console.WriteLine($"IsStale: {info.IsStale}");
                    Console.WriteLine($"Name: {info.Name}");
                    Console.WriteLine($"Format: {info.Format}");
                    Console.WriteLine($"Latency: {info.Latency}");
                    Console.WriteLine($"IsMuted: {info.IsMuted}");
                    Console.WriteLine($"SignalReferenceLevel: {info.SignalReferenceLevel}");
                    Console.WriteLine($"Subscription: {info.Subscription}");
                    Console.WriteLine($"Status: {info.Status}");
                    Console.WriteLine($"Flow: {info.Flow}");
                    Console.WriteLine();
                }
            }
                
        }
    }
}
