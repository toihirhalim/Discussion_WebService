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
    public partial class Auth : Form
    {
        srv.ws_chatSoapClient srv = new srv.ws_chatSoapClient();
        List<Participation> participations = new List<Participation>();
        public Auth()
        {
            InitializeComponent();
        }

        private void btnParticiper_Click(object sender, EventArgs e)
        {
            srv.Participant[] participants = srv.Participer(pseudotxtBox.Text);

            if(participants == null)
            {
                Text = "votre pseudo est deja utilise !";
            }else
            {
                Text = "votre partiipation est accepté";
                Participation participationfrm = new Participation(pseudotxtBox.Text, participants);
                //participationfrm.ShowDialog();
                participationfrm.Show();
                participationfrm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.deleteParticipant);

                participations.Add(participationfrm);

                setParticipants(participants);
            }

        }

        public void setParticipants(srv.Participant[] participants)
        {
            foreach (Participation part in participations)
            {
                part.setParticipants(participants);
            }
        }

        public void deleteParticipant(object sender, EventArgs e)
        {
            Participation p = (Participation)sender;
            string pseudo = p.Pseudo;

            participations.RemoveAll(x => x.Pseudo == pseudo);

            srv.Participant[] participants = srv.Quiter(p.Pseudo);
            setParticipants(participants);
        }

        public void deleteAllParticipants(object sender, EventArgs e)
        {
            srv.ArrayOfString pseudos = new srv.ArrayOfString();
            pseudos.AddRange(participations.Select(p => p.Pseudo));
            srv.QuiterParticipants(pseudos);
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.deleteAllParticipants);
        }
    }
}
