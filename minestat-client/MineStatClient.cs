using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minestat_client
{
    public partial class MineStat : Form
    {
        string ip_address;

        public MineStat()
        {
            InitializeComponent();
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            global::MineStat ms = new global::MineStat(this.ip_address, ushort.Parse(this.port_value.Text));
            if (ms.ServerUp)
            {
                this.status_value.Text = "Online";
                this.status_value.BackColor = Color.Green;
                this.server_value.Text = ms.Address + ":" + ms.Port;
                this.players_value.Text = ms.CurrentPlayers + "/" + ms.MaximumPlayers;
                this.version_value.Text = ms.Version;
                this.message_value.Text = ms.Motd;
            }
            else
            {
                this.status_value.Text = "Offline";
                this.status_value.BackColor = Color.Red;
            }
        }

        private void port_value_TextChanged(object sender, EventArgs e)
        {
            this.status_value.Text = "Status pending";
            this.status_value.BackColor = Color.Yellow;

            ushort x = 0;
            if(!(ushort.TryParse(this.port_value.Text, out x)))
            {
                this.port_value.BackColor = Color.Red;
                this.confirm_button.Enabled = false;
            } else
            {
                this.port_value.BackColor = Color.White;
                this.confirm_button.Enabled = true;
            }
        }

        private void ip_value_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.status_value.Text = "Status pending";
            this.status_value.BackColor = Color.Yellow;

            IPAddress[] addresslist;
            try
            {
                addresslist = Dns.GetHostAddresses(this.ip_value.Text);
            } catch (System.Net.Sockets.SocketException)
            {
                this.ip_value.BackColor = Color.Red;
                this.confirm_button.Enabled = false;
                return;
            }
            

            if (addresslist.Length >= 1)
            {
                IPAddress address = addresslist[0];
                switch (address.AddressFamily)
                {
                    case System.Net.Sockets.AddressFamily.InterNetwork:
                        // we have IPv4
                        this.ip_value.BackColor = Color.White;
                        this.confirm_button.Enabled = true;
                        this.ip_address = address.ToString();
                        break;
                    case System.Net.Sockets.AddressFamily.InterNetworkV6:
                        // we have IPv6
                        this.ip_value.BackColor = Color.White;
                        this.confirm_button.Enabled = true;
                        this.ip_address = address.ToString();
                        break;
                    default:
                        MessageBox.Show("Entered ip adderess doesn't conform t the IPv4 or IPv6 standard!", "IP Version Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.ip_value.BackColor = Color.Red;
                        this.confirm_button.Enabled = false;
                        break;
                }
            } else
            {
                this.ip_value.BackColor = Color.Red;
                this.confirm_button.Enabled = false;
            }
        }
    }
}
