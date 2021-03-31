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
            LastIPTextBox1.Text = network.Network.ToString();
            BroadcastTextBox1.Text = network.Broadcast.ToString();
            FirstHostTextBox1.Text = network.FirstUsable.ToString();
            LastHostTextBox1.Text = network.LastUsable.ToString();
            // byte[] reversedMask = maskAddress.GetAddressBytes();
            // byte[] network = new byte[4];
            // byte[] broadcast = new byte[4];
            // for (int i = 0; i < 4; i++)
            // {
            //     network[i] = (byte)(ip[i] & mask[i]);
            //     reversedMask[i] = (byte)~mask[i];
            //     broadcast[i] = (byte)(network[i] | reversedMask[i]);
            // }
            // //Array.Copy(network, broadcast, 4);
            // string networkAddressString = "";
            // string broadcastAddressString = "";
            // for (int i = 0; i < 4; i++)
            // {
            //     //network
            //     String ipFragment = network[i].ToString();
            //     ipFragment = ipFragment.PadLeft(3, '0');
            //     networkAddressString += ipFragment;
            //     //broadcast
            //     ipFragment = broadcast[i].ToString();
            //     ipFragment = ipFragment.PadLeft(3, '0');
            //     broadcastAddressString += ipFragment;
            // }
            // LastIPTextBox1.Text = networkAddressString;
            // BroadcastTextBox1.Text = broadcastAddressString;
        }
    }
}
