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
    public partial class MessageRecuUC : UserControl
    {
        public MessageRecuUC()
        {
            InitializeComponent();
        }
        public MessageRecuUC(string pseudo, string message)
        {
            InitializeComponent();

            sender.Text = pseudo;
            msgText.Text = message;
        }

        private void MessageRecuUC_Load(object sender, EventArgs e)
        {

        }
    }
}
