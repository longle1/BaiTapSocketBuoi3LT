using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaiTapTuan3Socket
{
    public partial class Client : Form
    {
        UdpClient clientUpd;
        IPEndPoint ipEndPoint;
        string userName;
        int portServer, portClient;
        bool shutdown = false;
        public Client()
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
        private bool checkUsername(string name)
        {
            return name.Trim() == "" ? false : true;
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), portServer);
            string sendData = userName + ": " + txtSendMessage.Text;
            byte[] data = Encoding.UTF8.GetBytes(sendData);
            clientUpd.Send(data, data.Length, ipEndPoint);
            txtSendMessage.Clear();
            WriteData("--->" + sendData);
        }

        private void WriteData(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate { txtReceiveMessgae.AppendText( msg + Environment.NewLine); });
            this.BeginInvoke(invoker);
        }
        private void Client_Load(object sender, EventArgs e)
        {
            btnSendMessage.Enabled = false;
            txtSendMessage.ReadOnly = true;
            txtReceiveMessgae.ReadOnly = true;
        }

        public void rcvData()
        {
            try
            {
                while (true)
                {
                    ipEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    byte[] receive_buffer = clientUpd.Receive(ref ipEndPoint);
                    string receiveMsg = Encoding.UTF8.GetString(receive_buffer);
                    WriteData("Server: " + receiveMsg);
                    string[] acceptShutdown = receiveMsg.Split(':');
                    if (acceptShutdown[1].Trim() == "Yêu cầu ngừng chat!!!")
                    {
                        break;
                    }
                }
                WriteData("--->" + userName + ": Ngừng chat thành công!!!");
                clientUpd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã ngừng chat");
                return;
            }
        }
        private void btnCheckConnect_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!checkPort(txtPortClient.Text))
                {
                    MessageBox.Show("Vui lòng nhập Port cho client trước khi kết nối");
                    return;
                }
                if (!checkPort(txtPortServer.Text))
                {
                    MessageBox.Show("Vui lòng nhập Port cho server trước khi kết nối");
                    return;
                }
                if (!checkUsername(txtUserName.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập username trước khi kết nối");
                    return;
                }

                userName = txtUserName.Text.Trim();
                portClient = int.Parse(txtPortClient.Text);
                portServer = int.Parse(txtPortServer.Text);
                if (portServer == portClient)
                {
                    MessageBox.Show("Vui lòng nhập port server khác vơi port client");
                    return;
                }
                clientUpd = new UdpClient(portClient);

                // Tiến trình gửi dữ liệu đi
                string sendMesg = $"{userName}: xin chào Server!";
                byte[] send_buffer = Encoding.UTF8.GetBytes(sendMesg);
                ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), portServer);
                clientUpd.Send(send_buffer, send_buffer.Length, ipEndPoint);
                WriteData("--->" + sendMesg);

                // Tiến trình nhận dữ liệu về
                ipEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] receive_buffer = clientUpd.Receive(ref ipEndPoint);
                string receiveMsg = Encoding.UTF8.GetString(receive_buffer);
                WriteData(receiveMsg);
                Thread newThr1 = new Thread(new ThreadStart(rcvData));
                newThr1.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng kết nối trước khi kiểm tra kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnCheckConnect.Enabled = false;
            btnSendMessage.Enabled = true;
            txtPortClient.ReadOnly = true;
            txtPortServer.ReadOnly = true;
            txtUserName.ReadOnly = true;
            txtSendMessage.ReadOnly = false;

            return;
        }
    }
}
