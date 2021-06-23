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
    public partial class MessageSystemUC : UserControl
    {
        public MessageSystemUC()
        {
            InitializeComponent();
        }

        public MessageSystemUC(string message)
        {
            InitializeComponent();
            messageText.Text = message;
        }

        private void MessageSystemUC_Load(object sender, EventArgs e)
        {

        }
    }
}
