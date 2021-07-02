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
    public partial class MessageUC : UserControl
    {
        public MessageUC()
        {
            InitializeComponent();
        }

        public MessageUC(string sender, string message)
        {
            InitializeComponent();
            flPnl.Controls.Add(new MessageRecuUC(sender, message));
        }

        public MessageUC(string message)
        {
            InitializeComponent();
            flPnl.Controls.Add(new MessageEnvoyeUC(message));
            flPnl.FlowDirection = FlowDirection.RightToLeft;
        }

        private void MessageUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
