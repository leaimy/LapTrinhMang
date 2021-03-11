
namespace Server
{
	partial class frmServer
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
			this.txtHienThiServer = new System.Windows.Forms.TextBox();
			this.btnKhoiDongServer = new System.Windows.Forms.Button();
			this.btnGuiServer = new System.Windows.Forms.Button();
			this.txtDataServer = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtDataServer);
			this.panel1.Controls.Add(this.btnGuiServer);
			this.panel1.Controls.Add(this.btnKhoiDongServer);
			this.panel1.Controls.Add(this.txtHienThiServer);
			this.panel1.Location = new System.Drawing.Point(13, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(479, 423);
			this.panel1.TabIndex = 0;
			// 
			// txtHienThiServer
			// 
			this.txtHienThiServer.Location = new System.Drawing.Point(16, 58);
			this.txtHienThiServer.Multiline = true;
			this.txtHienThiServer.Name = "txtHienThiServer";
			this.txtHienThiServer.ReadOnly = true;
			this.txtHienThiServer.Size = new System.Drawing.Size(448, 286);
			this.txtHienThiServer.TabIndex = 0;
			// 
			// btnKhoiDongServer
			// 
			this.btnKhoiDongServer.Location = new System.Drawing.Point(16, 11);
			this.btnKhoiDongServer.Name = "btnKhoiDongServer";
			this.btnKhoiDongServer.Size = new System.Drawing.Size(448, 41);
			this.btnKhoiDongServer.TabIndex = 1;
			this.btnKhoiDongServer.Text = "Khởi động Server";
			this.btnKhoiDongServer.UseVisualStyleBackColor = true;
			this.btnKhoiDongServer.Click += new System.EventHandler(this.btnKhoiDongServer_Click);
			// 
			// btnGuiServer
			// 
			this.btnGuiServer.Location = new System.Drawing.Point(373, 371);
			this.btnGuiServer.Name = "btnGuiServer";
			this.btnGuiServer.Size = new System.Drawing.Size(91, 26);
			this.btnGuiServer.TabIndex = 2;
			this.btnGuiServer.Text = "Gửi";
			this.btnGuiServer.UseVisualStyleBackColor = true;
			this.btnGuiServer.Click += new System.EventHandler(this.btnGuiServer_Click);
			// 
			// txtDataServer
			// 
			this.txtDataServer.Location = new System.Drawing.Point(16, 371);
			this.txtDataServer.Name = "txtDataServer";
			this.txtDataServer.Size = new System.Drawing.Size(335, 26);
			this.txtDataServer.TabIndex = 3;
			// 
			// frmServer
			// 
			this.AcceptButton = this.btnGuiServer;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 448);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmServer";
			this.Text = "Server";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtDataServer;
		private System.Windows.Forms.Button btnGuiServer;
		private System.Windows.Forms.Button btnKhoiDongServer;
		private System.Windows.Forms.TextBox txtHienThiServer;
	}
}

