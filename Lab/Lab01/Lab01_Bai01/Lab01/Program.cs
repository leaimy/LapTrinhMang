using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
	class Program
	{
		static void Main(string[] args)
		{
			/*foreach (String arg in args)
			{
				Console.WriteLine("Phan giai ten mien:" + arg);
				GetHostInfo(arg);
			}
			Console.ReadKey();*/
			string domain = "";
			Console.WriteLine("Nhap ten mien: ");
			domain = Console.ReadLine();

			GetHostInfo(domain);
			Console.ReadLine();
		}

		static void GetHostInfo(string host)
		{
			try
			{
				IPHostEntry hostInfo = Dns.GetHostEntry(host);
				//Display host name
				Console.WriteLine("Ten mien: " + hostInfo.HostName);
				//Display list of IP address
				Console.Write("Dia chi IP:");
				foreach(IPAddress ipaddr in hostInfo.AddressList)
				{
					Console.Write(ipaddr.ToString() + " ");
				}
				Console.WriteLine();
			}
			catch(Exception)
			{
				Console.WriteLine("Khong phan giai duoc ten mien: " + host + "\n");
			}
		}
	}
}
