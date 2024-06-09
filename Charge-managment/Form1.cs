using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net.Sockets;
namespace Charge_managment
{
    public partial class Form1 : Form
    {
        TcpClient tcpClient = new TcpClient();
        NetworkStream networkStream;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbx_highsp.Text = Properties.Settings.Default.hsp;
            tbx_lowsp.Text = Properties.Settings.Default.lsp;
            tbx_rly_ip.Text = Properties.Settings.Default.IP;
            tbx_rly_port.Text = Properties.Settings.Default.Port;
            Update_Batt_status();
            try
            {
                Connect_relay(tbx_rly_ip.Text, tbx_rly_port.Text);
            }
            catch
            { }
        }

        /// <summary>
        /// Update battery status using SystemInformation class.
        /// </summary>
        private void Update_Batt_status()
        {

            PowerStatus status = SystemInformation.PowerStatus;

            // tbx_charger_status.Text = status.BatteryChargeStatus.ToString();
            tbx_charger_Remain.Text = status.BatteryLifePercent.ToString("P0");       
           
         
            // tbx_charger_RemainTime.Text = status.BatteryLifeRemaining.ToString();
            tbx_lineStatus.Text = status.PowerLineStatus.ToString();

        }


        /// <summary>
        /// connect to ethernet Relay . this relay config as tcp server 
        /// </summary>
        private void Connect_relay(string ip , string port)
        {

            try
            {
                tcpClient.Connect(ip, Int32.Parse(port));
                networkStream = tcpClient.GetStream();
            }
            catch (Exception e)
            {
             //   MessageBox.Show("Error While Connecting to Relay Board ");
            }
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Connect_relay(tbx_rly_ip.Text, tbx_rly_port.Text);
        }
        /// <summary>
        /// update UI  and check condition for show message ballon and send data to tcp relay. 
        /// </summary>
        private void SYS_tick_Tick(object sender, EventArgs e)
        {
            Update_Batt_status();
            try
            {

                if (Int32.Parse(tbx_charger_Remain.Text.Remove(tbx_charger_Remain.Text.Length - 1, 1)) >= Int32.Parse(tbx_highsp.Text))
                {

                    if (tbx_lineStatus.Text == "Online")
                    {
                       // Send_TCP_string("rl1=off");
                        SetBalloonTip("Laptop charging", "Disconnect the charger from the laptop");
                        notifyIcon1.Visible = true;
                        notifyIcon1.ShowBalloonTip(30000);
                    }

                }


                if (Int32.Parse(tbx_charger_Remain.Text.Remove(tbx_charger_Remain.Text.Length - 1, 1)) <= Int32.Parse(tbx_lowsp.Text))
                {
                    if (tbx_lineStatus.Text == "Offline")
                    {
                       // Send_TCP_string("rl1=on");
                        SetBalloonTip("Laptop charging", "Connect the charger to the laptop");
                        notifyIcon1.Visible = true;
                        notifyIcon1.ShowBalloonTip(30000);

                    }
                }
            }
            catch
            { 
            
            }

        }
        /// <summary>
        /// Send input string to connect server . add CRLF to all string . 
        /// </summary>
        private void Send_TCP_string(String CMD) 
        {
            try
            {
                string tmp_string = CMD + "\r\n";
                Byte[] sendBytes = Encoding.ASCII.GetBytes(tmp_string);
                networkStream.Write(sendBytes, 0, sendBytes.Length);
            }
            catch
            { 
            
            }

         }

        /// <summary>
        /// save all usefull parameters to setting spacecc . 
        /// </summary>

        private void button2_Click(object sender, EventArgs e)
        {
        
            Properties.Settings.Default.hsp= tbx_highsp.Text;
            Properties.Settings.Default.lsp = tbx_lowsp.Text;
            Properties.Settings.Default.IP= tbx_rly_ip.Text;
            Properties.Settings.Default.Port=tbx_rly_port.Text;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Config ballon parammeter. 
        /// </summary>
        private void SetBalloonTip(string Title, string text)
        {
            notifyIcon1.Icon = SystemIcons.Exclamation;
            notifyIcon1.BalloonTipTitle = Title;
            notifyIcon1.BalloonTipText = text;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;

        }
        /// <summary>
        /// Form resize Event to minimze form to Try . 
        /// </summary>
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;

               // notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }
        /// <summary>
        /// notifyicon double click event to return page Full screen . 
        /// </summary>
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
    }

}
