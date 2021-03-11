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

namespace Client
{
	public partial class frmClient : Form
	{
		public frmClient()
		{
			CheckForIllegalCrossThreadCalls = false;
			InitializeComponent();
		}

		StreamReader reader;
		StreamWriter writer;

		public void Connect()
		{
			TcpClient client = new TcpClient("127.0.0.1", 5000);
			NetworkStream network = client.GetStream();
			reader = new StreamReader(network);
			writer = new StreamWriter(network);

			txtHienThiClient.AppendText(reader.ReadLine());
			txtHienThiClient.AppendText(Environment.NewLine);
			Thread serverThread = new Thread(new ThreadStart(ServerListen));
			serverThread.Start();
		}

		void ServerListen()
		{

			try
			{
				while (true)
				{
					string str = reader.ReadLine();
					txtHienThiClient.AppendText(str);
					txtHienThiClient.AppendText(Environment.NewLine);
				}
			}
			catch
			{

				txtHienThiClient.AppendText("Server da ngat ket noi\n");
			}
		}

		public void SendData(string data)
		{
			writer.WriteLine(data);
			writer.Flush();

		}

		private void btnKetNoiServer_Click(object sender, EventArgs e)
		{
			Connect();
			btnKetNoiServer.Enabled = false;
		}

		private void btnGuiClient_Click(object sender, EventArgs e)
		{
			SendData(txtDataClient.Text);
			txtDataClient.Text = "";
		}
	}
}
