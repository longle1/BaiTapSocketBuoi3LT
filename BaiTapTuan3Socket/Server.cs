using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BaiTapTuan3Socket
{
    public partial class Server : Form
    {
        UdpClient serverUdp;
        IPEndPoint ipEndPoint;
        int portServer, portClient;
        bool shutdown = true;
        public Server()
        {
            InitializeComponent();
        }
        private bool checkPort(string port)
        {
            bool check = true;
            try
            {
                if (Int32.Parse(port) <= 0) { check = false; }
            }
            catch (Exception ex)
            {
                check = false;
            }
            return check;
        }
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), portClient);
            string sendData = "Server: " + txtSendMessage.Text;
            byte[] data = Encoding.UTF8.GetBytes(sendData);
            serverUdp.Send(data, data.Length, ipEndPoint);
            txtSendMessage.Clear();
            WriteData("--->" + sendData);

        }

        private void Server_Load(object sender, EventArgs e)
        {

            btnSendMessage.Enabled = false;
            btnShutdown.Enabled = false;
            txtSendMessage.ReadOnly = true;
            txtReceiveMessgae.ReadOnly = true;

        }
        private void WriteData(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate { txtReceiveMessgae.AppendText(msg + Environment.NewLine); });
            this.BeginInvoke(invoker);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!checkPort(txtPortClient.Text))
            {
                MessageBox.Show("Vui lòng nhập Port cho Client trước khi kiểm tra");
                return;
            }
            if (!checkPort(txtPortServer.Text))
            {
                MessageBox.Show("Vui lòng nhập Port cho Server trước khi kiểm tra");
                return;
            }

            portClient = int.Parse(txtPortClient.Text);
            portServer = int.Parse(txtPortServer.Text);
            if (portServer == portClient)
            {
                MessageBox.Show("Vui lòng nhập port server khác vơi port client");
                return;
            }
            serverUdp = new UdpClient(portServer);
            string str = "Bắt đầu kết nối";
            WriteData(str);
            ipEndPoint = new IPEndPoint(IPAddress.Any, 0);
            Thread thr = new Thread(new ThreadStart(ConnectServer));
            thr.Start();


            btnSendMessage.Enabled = true;
            btnConnect.Enabled = false;
            txtPortClient.ReadOnly = true;
            txtPortServer.ReadOnly = true;
            txtSendMessage.ReadOnly = false;
            btnShutdown.Enabled = true;
        }
        public void rcvData()
        {
            try
            {
                while(shutdown)
                {
                    ipEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    byte[] receive_buffer = serverUdp.Receive(ref ipEndPoint);
                    string receiveMsg = Encoding.UTF8.GetString(receive_buffer);
                    WriteData(receiveMsg);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Đã ngừng chat");
                return;
            }
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            shutdown = false;
            ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), portClient);
            string sendData = "Server: " + "Yêu cầu ngừng chat!!!";
            byte[] data = Encoding.UTF8.GetBytes(sendData);
            serverUdp.Send(data, data.Length, ipEndPoint);
            txtSendMessage.Clear();
            WriteData("--->" + sendData);
            serverUdp.Close();
        }

        private void ConnectServer()
        {

            //tiến trình nhận dữ liệu về
            byte[] receive_buffer = serverUdp.Receive(ref ipEndPoint);
            string msg = Encoding.UTF8.GetString(receive_buffer);
            WriteData(msg);

            string[] getUsername = msg.Split(':');

            //tiến trình gửi dữ liệu đi
            ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), portClient);
            string dataSend = $"Server: Xin chào {getUsername[0]}!";
            byte[] send_buffer = Encoding.UTF8.GetBytes(dataSend);
            serverUdp.Send(send_buffer, send_buffer.Length, ipEndPoint);
            WriteData("--->" + dataSend);


            Thread newThr = new Thread(new ThreadStart(rcvData));
            newThr.Start();
        }
    }
}
