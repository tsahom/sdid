using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels.Http;

namespace HostApplication
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                //TcpChannel channel = new TcpChannel(12000);
                HttpChannel channel = new HttpChannel(14000);
                ChannelServices.RegisterChannel(channel, true);
                RemotingConfiguration.RegisterWellKnownServiceType(
                    typeof(HostObject),"HostObject", WellKnownObjectMode.SingleCall);
                Console.WriteLine("Remote object ready at serveur side !");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Error creating/registering the channel !");
            }
        }
    }
}
