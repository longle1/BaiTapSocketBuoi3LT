using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTuan3Socket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnOpenServer_Click(object sender, EventArgs e)
        {
            Server openServer = new Server();
            openServer.Show();
        }

        private void btnOpenClient_Click(object sender, EventArgs e)
        {
            Client openClient = new Client();
            openClient.Show();
        }
    }
}
