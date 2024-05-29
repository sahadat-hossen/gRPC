using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greet;
using Grpc.Net.Client;

namespace gRPC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:7270");
            
            Console.WriteLine("Greeting: " + channel.ToString());
        }
    }
}
