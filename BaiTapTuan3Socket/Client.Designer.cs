namespace BaiTapTuan3Socket
{
    partial class Client
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
            this.txtReceiveMessgae = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPortClient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnCheckConnect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPortServer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtReceiveMessgae
            // 
            this.txtReceiveMessgae.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtReceiveMessgae.Location = new System.Drawing.Point(39, 217);
            this.txtReceiveMessgae.Multiline = true;
            this.txtReceiveMessgae.Name = "txtReceiveMessgae";
            this.txtReceiveMessgae.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReceiveMessgae.Size = new System.Drawing.Size(449, 207);
            this.txtReceiveMessgae.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Thông tin: ";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.BackColor = System.Drawing.Color.Lime;
            this.btnSendMessage.Location = new System.Drawing.Point(494, 42);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(92, 33);
            this.btnSendMessage.TabIndex = 20;
            this.btnSendMessage.Text = "Gửi";
            this.btnSendMessage.UseVisualStyleBackColor = false;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nhập tin nhắn cần gửi";
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.Location = new System.Drawing.Point(39, 48);
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.Size = new System.Drawing.Size(449, 22);
            this.txtSendMessage.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nhập Port Client";
            // 
            // txtPortClient
            // 
            this.txtPortClient.Location = new System.Drawing.Point(39, 108);
            this.txtPortClient.Name = "txtPortClient";
            this.txtPortClient.Size = new System.Drawing.Size(143, 22);
            this.txtPortClient.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nhập username";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(39, 161);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(143, 22);
            this.txtUserName.TabIndex = 23;
            // 
            // btnCheckConnect
            // 
            this.btnCheckConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCheckConnect.Location = new System.Drawing.Point(592, 39);
            this.btnCheckConnect.Name = "btnCheckConnect";
            this.btnCheckConnect.Size = new System.Drawing.Size(125, 38);
            this.btnCheckConnect.TabIndex = 27;
            this.btnCheckConnect.Text = "kiểm tra kết nối";
            this.btnCheckConnect.UseVisualStyleBackColor = false;
            this.btnCheckConnect.Click += new System.EventHandler(this.btnCheckConnect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nhập Port Server";
            // 
            // txtPortServer
            // 
            this.txtPortServer.Location = new System.Drawing.Point(211, 108);
            this.txtPortServer.Name = "txtPortServer";
            this.txtPortServer.Size = new System.Drawing.Size(143, 22);
            this.txtPortServer.TabIndex = 28;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPortServer);
            this.Controls.Add(this.btnCheckConnect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPortClient);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSendMessage);
            this.Controls.Add(this.txtReceiveMessgae);
            this.Controls.Add(this.label3);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReceiveMessgae;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSendMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPortClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnCheckConnect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPortServer;
    }
}