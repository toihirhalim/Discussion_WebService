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
    public partial class Participation : Form
    {
        public string Pseudo { get; set; }
        List<srv.Participant> Participants { get; set; }

        public Participation()
        {
            InitializeComponent();
        }

        public Participation(string pseudo, srv.Participant [] participants)
        {
            InitializeComponent();
            Pseudo = pseudo;
            Participants = participants.ToList();
        }

        public void  setParticipants(srv.Participant[] participants)
        {
            Participants = participants.ToList();
            showParticipants();
        }

        public void showParticipants()
        {
            listParticipants.Items.Clear();

            foreach (srv.Participant participant in Participants)
                if (!participant.Pseudo.Equals(Pseudo))
                    listParticipants.Items.Add(participant.Pseudo);

        }

        private void Participation_Load(object sender, EventArgs e)
        {
            Text = "Mon pseudo est " + Pseudo;
            showParticipants();
            listParticipants.CheckOnClick = true;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string texte = msgBox.Text;

            if (Text.Equals("")) return;

            List<string> pseudos = new List<string>();
            string p = "";

            foreach (object itemChecked in listParticipants.CheckedItems)
            {
                pseudos.Add(itemChecked.ToString());
                p += itemChecked.ToString() + ", ";
            }

            Console.WriteLine(Pseudo + " sending '" + texte + "' to : " + p);

            msgBox.Text = "";
        }
    }
}
