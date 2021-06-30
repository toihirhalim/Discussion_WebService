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
    public partial class NotificationUC : UserControl
    {
        public NotificationUC()
        {
            InitializeComponent();
        }
        public NotificationUC(string message)
        {
            InitializeComponent();
            msgText.Text = message;
        }
    }
}
