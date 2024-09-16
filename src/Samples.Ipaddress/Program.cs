using System;
using System.Net;
using System.Net.Sockets;

namespace Samples.Ipaddress
{
    class Program
    {
        public static void Main(string[] args)
        {
            string hostName = Dns.GetHostName();
            Utilities.ShowMenu("Getting IP Address ");
            Console.WriteLine();
            try
            {
                Utilities.PrintLabel("Hostname", hostName);
                IPHostEntry ipinfo = Dns.GetHostByName(hostName);
                int i = 0;
                if (ipinfo.AddressList.Length > -1)
                {
                    foreach (IPAddress ip in ipinfo.AddressList)
                    {
                        byte[] b = ip.GetAddressBytes();
                        string s = string.Format("{0}.{1}.{2}.{3}", b[0], b[1], b[2], b[3]);
                        Utilities.PrintLabel("No. "+ i + " IP ", s);
                        i++;
                    }
                    Utilities.PrintLabel("LoopBack",IPAddress.Loopback.ToString());
                    Utilities.PrintLabel("Broadcast", IPAddress.Broadcast.ToString());
                }
                else
                    Utilities.PrintMessage("Sin IP");
            }
            catch (SocketException se)
            {
                Utilities.PrintMessage(se.Message);
            }
            catch (ArgumentException sa)
            {
                Utilities.PrintMessage(sa.Message);
            }
            catch (Exception e)
            {
                Utilities.PrintMessage(e.Message);
            }
            Utilities.Pause();
        }
    }
}