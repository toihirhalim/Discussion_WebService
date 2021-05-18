using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discussion
{
    public partial class Form1 : Form
    {
        //srv.ws_chatSoapClient srvCli = new srv.ws_chatSoapClient();
        //srv1.ws_chatSoapClient srv1Cli = new srv1.ws_chatSoapClient();
        
        public Form1()
        {
            InitializeComponent();
            //srv1Cli.GetClientsCompleted += Srv1Cli_GetClientsCompleted;
        }

        /*private void Srv1Cli_GetClientsCompleted(object sender, srv1.GetClientsCompletedEventArgs e)
        {
            grd.DataSource = e.Result;
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            //async way
            //srv1Cli.GetClientsAsync();

            //normal way
            //grd.DataSource = srvCli.GetClients();
        }
    }
}
