
namespace Client
{
	partial class frmClient
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtDataClient = new System.Windows.Forms.TextBox();
			this.btnGuiClient = new System.Windows.Forms.Button();
			this.btnKetNoiServer = new System.Windows.Forms.Button();
			this.txtHienThiClient = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtDataClient);
			this.panel1.Controls.Add(this.btnGuiClient);
			this.panel1.Controls.Add(this.btnKetNoiServer);
			this.panel1.Controls.Add(this.txtHienThiClient);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(479, 423);
			this.panel1.TabIndex = 1;
			// 
			// txtDataClient
			// 
			this.txtDataClient.Location = new System.Drawing.Point(16, 371);
			this.txtDataClient.Name = "txtDataClient";
			this.txtDataClient.Size = new System.Drawing.Size(335, 26);
			this.txtDataClient.TabIndex = 3;
			// 
			// btnGuiClient
			// 
			this.btnGuiClient.Location = new System.Drawing.Point(373, 371);
			this.btnGuiClient.Name = "btnGuiClient";
			this.btnGuiClient.Size = new System.Drawing.Size(91, 26);
			this.btnGuiClient.TabIndex = 2;
			this.btnGuiClient.Text = "Gửi";
			this.btnGuiClient.UseVisualStyleBackColor = true;
			this.btnGuiClient.Click += new System.EventHandler(this.btnGuiClient_Click);
			// 
			// btnKetNoiServer
			// 
			this.btnKetNoiServer.Location = new System.Drawing.Point(16, 11);
			this.btnKetNoiServer.Name = "btnKetNoiServer";
			this.btnKetNoiServer.Size = new System.Drawing.Size(448, 41);
			this.btnKetNoiServer.TabIndex = 1;
			this.btnKetNoiServer.Text = "Kết nối Server";
			this.btnKetNoiServer.UseVisualStyleBackColor = true;
			this.btnKetNoiServer.Click += new System.EventHandler(this.btnKetNoiServer_Click);
			// 
			// txtHienThiClient
			// 
			this.txtHienThiClient.Location = new System.Drawing.Point(16, 58);
			this.txtHienThiClient.Multiline = true;
			this.txtHienThiClient.Name = "txtHienThiClient";
			this.txtHienThiClient.ReadOnly = true;
			this.txtHienThiClient.Size = new System.Drawing.Size(448, 286);
			this.txtHienThiClient.TabIndex = 0;
			// 
			// frmClient
			// 
			this.AcceptButton = this.btnGuiClient;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 448);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmClient";
			this.Text = "Client";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtDataClient;
		private System.Windows.Forms.Button btnGuiClient;
		private System.Windows.Forms.Button btnKetNoiServer;
		private System.Windows.Forms.TextBox txtHienThiClient;
	}
}

