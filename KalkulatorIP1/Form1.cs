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
using System.Text.RegularExpressions;

namespace KalkulatorIP1
{
    public partial class Form1 : Form
    {
        static Regex rgx = new Regex(@"(^|\.)0+(?!\.|$)", RegexOptions.Compiled);
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateIP(object sender, EventArgs e)
        {
            String ipString = IPTextBox1.Text;
            ipString = rgx.Replace(ipString, ".");

            
            IPAddress ipAddress = IPAddress.Parse(ipString);
            IPAddress maskAddress = IPAddress.Parse(MaskTextBox1.Text);
            byte[] ip = ipAddress.GetAddressBytes();
            byte[] mask = maskAddress.GetAddressBytes();
            IPNetwork network = IPNetwork.Parse(ipAddress.ToString(), maskAddress.ToString());
            
            String AdresSieci = network.Network.ToString();
            String AdresRozgłoszeniowy = network.Broadcast.ToString();
            String PierwszyAdres = network.FirstUsable.ToString();
            String OstatniAdres = network.LastUsable.ToString();

            LastIPTextBox1.Text = AdresSieci;
            BroadcastTextBox1.Text = AdresRozgłoszeniowy;
            FirstHostTextBox1.Text = PierwszyAdres;
            LastHostTextBox1.Text = OstatniAdres;
        }
    }
}
