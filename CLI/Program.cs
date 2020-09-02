using System;
using System.Threading;
using System.Threading.Tasks;
using Mason.API;
using Mason.API.Fleet;
using Newtonsoft.Json;

namespace Mason.CLI
{
    public class EnumDevices
    {
        private static async Task Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please include an apikey. For more information, go to: https://platform.bymason.com/controller/settings/apikeys.     ");
                return;
            }
            
            var ep = new Endpoint(args[0]);
            var fleet = new Fleet(ep);

            var idx = 0;
            await foreach(var device in fleet.ListDevices(CancellationToken.None))
            {
                idx++;
                var o = JsonConvert.SerializeObject(device);

                Console.WriteLine($"{idx} -- {device.Id} -- {o}");
            }

            Console.ReadLine();
        }
    }
}