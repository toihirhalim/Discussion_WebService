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
    public partial class MessageEnvoyeUC : UserControl
    {
        public MessageEnvoyeUC()
        {
            InitializeComponent();
        }

        public MessageEnvoyeUC(string message)
        {
            InitializeComponent();

            messageText.Text = message;
        }

    }
}
