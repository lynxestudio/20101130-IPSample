using System;
using System.Net;
using System.Net.Sockets;

namespace Samples {
class Program {
public static void Main(string[] args)  {
 try {
    IPHostEntry ipinfo = Dns.GetHostByName(Dns.GetHostName());
    int i = 0;
    if(ipinfo.AddressList.Length > -1)    {
	foreach(IPAddress ip in  ipinfo.AddressList){
	byte[] b = ip.GetAddressBytes();
	Console.WriteLine("IP[{0}] =\t{1}.{2}.{3}.{4}",i,b[0],b[1],b[2],b[3]);
	i++;
	    }
	Console.WriteLine("LoopBack =\t{0} ",IPAddress.Loopback);
	Console.WriteLine("Broadcast =\t{0} ",IPAddress.Broadcast);
	}	
	else
	Console.WriteLine("Sin IP");
	 }
	catch(SocketException se){
	Console.WriteLine(se.Message);
	 }
	catch(ArgumentException sa){
	Console.WriteLine(sa.Message);
	 }
	catch(Exception e){
	Console.WriteLine(e.Message);
	 }
	 }
    }
}