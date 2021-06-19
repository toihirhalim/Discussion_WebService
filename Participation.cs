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
        public Boolean messageSent { get; set; }
        public List<string> recieverPseudos = new List<string>();
        List<srv.Participant> Participants { get; set; }
        List<srv.Message> messages { get; set; }

        srv.ws_chatSoapClient srv = new srv.ws_chatSoapClient();

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

            if (texte.Equals("") || listParticipants.CheckedItems.Count == 0)
            {
                messageSent = false;
                return;
            }

            recieverPseudos.Clear();

            foreach (object itemChecked in listParticipants.CheckedItems)
                recieverPseudos.Add(itemChecked.ToString());

            srv.ArrayOfString recievers = new srv.ArrayOfString();
            recievers.AddRange(recieverPseudos);

            srv.SendMessage(Pseudo, texte, recievers);
            showSentMessage(texte);
            messageSent = true;
            msgBox.Text = "";
            this.ActiveControl = msgBox;
        }

        public void getRecievedMesages()
        {
            if(messages == null || messages.Count == 0)
            {
                messages = srv.GetMessages(Pseudo).ToList();
                showNewMessages(messages);
            }
            else
            {
                DateTime latestDate = (DateTime) messages[messages.Count - 1].Date;

                string dateString = latestDate.ToString("yyyy-MM-ddTHH:mm:sss.fff");

                List<srv.Message> newMessages = srv.GetLatestMessages(Pseudo, dateString).ToList();

                if(newMessages.Count > 0)
                {
                    showNewMessages(newMessages);
                }

                messages = messages.Concat(newMessages).ToList();
            }

        }

        private void showNewMessages(List<srv.Message> newMessages)
        {
            MessageUC msgUC = null;
            foreach (srv.Message msg in newMessages)
            {
                string sender = Participants.FirstOrDefault(p => p.Id == msg.ParticipantID).Pseudo;
                msgUC = new MessageUC(sender, msg.Msg);
                flPnl.Controls.Add(msgUC);
            }

            if(msgUC != null)
                flPnl.ScrollControlIntoView(msgUC);
        }

        public Button getSendBtn()
        {
            return sendBtn;
        }
        private void selectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (selectAll.Checked)
            {
                for (int i = 0; i < listParticipants.Items.Count; i++)
                    listParticipants.SetItemChecked(i, true);

                selectAll.Text = "Unselect All";
            }
            else
            {
                for(int i = 0; i < listParticipants.Items.Count; i++)
                    listParticipants.SetItemChecked(i, false);

                selectAll.Text = "Select All";
            }
        }
        
        private void showSentMessage(string message) {
            MessageUC msgUC = new MessageUC(message);
            flPnl.Controls.Add(msgUC);
            flPnl.ScrollControlIntoView(msgUC);
        }
    }
}
