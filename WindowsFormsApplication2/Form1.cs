using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public int x = 100;
        public int y = 100;
        public int globalport = 950;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Thread n = new Thread(read);
           // n.Start();
          
        }

        

        public void send()
        {
            try
            {
                UdpClient c = new UdpClient();
                IPEndPoint ip = new IPEndPoint(IPAddress.Parse("172.16.1.114"), globalport);
                byte[] data = Encoding.Unicode.GetBytes(x.ToString() + "," + y.ToString());
                c.Connect(ip);
                c.Send(data, data.Length);
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            y-=20;
            Thread n2 = new Thread(send);
            n2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            x+=20;
            Thread n2 = new Thread(send);
            n2.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            y+=20;
            Thread n2 = new Thread(send);
            n2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x-=20;
            Thread n2 = new Thread(send);
            n2.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x++;
            Thread n2 = new Thread(send);
            n2.Start();
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
