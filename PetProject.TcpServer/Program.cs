using System;
using System.Threading.Tasks;

namespace PetProject.TcpServer // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            TcpServer server = new(null);
            await server.RunAsync();
        }
    }
}