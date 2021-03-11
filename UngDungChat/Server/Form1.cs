using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Server
{
	public partial class frmServer : Form
	{
		StreamReader reader;
		StreamWriter writer;
		public frmServer()
		{
			CheckForIllegalCrossThreadCalls = false;
			InitializeComponent();
		}

		TcpListener server;

		public void Start()
		{
			Thread mainThread = new Thread(new ThreadStart(StartConnection));
			mainThread.Start();
		}

		void StartConnection()
		{
			server = new TcpListener(IPAddress.Any, 5000);
			server.Start();

			while (true)
			{
				Thread thread = new Thread(new ThreadStart(ClientConnected));
				thread.Start();
			}
		}

		void ClientConnected()
		{
			TcpClient client = server.AcceptTcpClient();
			NetworkStream network = client.GetStream();
			 reader = new StreamReader(network);
			 writer = new StreamWriter(network);

			string str = "Xin chao";
			writer.WriteLine(str);
			writer.Flush();

			try
			{
				while (true)
				{
					str = reader.ReadLine();
					txtHienThiServer.AppendText(str);
					txtHienThiServer.AppendText(Environment.NewLine);
				}
			}
			catch
			{

				txtHienThiServer.AppendText("Client da ngat ket noi\n");
			}
		}

		public void SendData(string data)
		{
			writer.WriteLine(data);
			writer.Flush();

		}

		private void btnKhoiDongServer_Click(object sender, EventArgs e)
		{
			Start();
			btnKhoiDongServer.Enabled = false;
		}

		private void btnGuiServer_Click(object sender, EventArgs e)
		{
			SendData(txtDataServer.Text);
			txtDataServer.Text = "";
		}
	}
}
