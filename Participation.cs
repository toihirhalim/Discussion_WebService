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

        public void addParticipants(srv.Participant[] newParticipants)
        {
            Participants.AddRange(newParticipants.ToList());

            NotificationUC notif = null;
            foreach(srv.Participant p in newParticipants)
            {
                listParticipants.Items.Add(p.Pseudo);
                notif = new NotificationUC(p.Pseudo + " enters the room");
                flPnl.Controls.Add(notif);
            }

            if(notif != null)
            {
                flPnl.ScrollControlIntoView(notif);
                if(selectAll.Checked)
                    selectAllParticipants();
            }

        }

        public void removeParticipants(string pseudo)
        {
            Participants.Remove(Participants.FirstOrDefault(p => p.Pseudo.Equals(pseudo)));
            listParticipants.Items.RemoveAt(listParticipants.Items.IndexOf(pseudo));

            NotificationUC notif = new NotificationUC(pseudo + " just left the room");
            flPnl.Controls.Add(notif);
            flPnl.ScrollControlIntoView(notif);
        }

        public void showParticipants()
        {
            listParticipants.Items.Clear();

            foreach (srv.Participant participant in Participants)
                if (!participant.Pseudo.Equals(Pseudo))
                    listParticipants.Items.Add(participant.Pseudo);

            selectAllParticipants();
        }

        private void Participation_Load(object sender, EventArgs e)
        {
            Text = "Mon pseudo est " + Pseudo;
            showParticipants();

            NotificationUC notif = new NotificationUC("Welcome " + Pseudo);
            flPnl.Controls.Add(notif);
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            messageSent = false;
            if (!isMessageValid())
                return;

            recieverPseudos.Clear();

            foreach (object itemChecked in listParticipants.CheckedItems)
                recieverPseudos.Add(itemChecked.ToString());

            srv.ArrayOfString recievers = new srv.ArrayOfString();
            recievers.AddRange(recieverPseudos);

            srv.SendMessage(Pseudo, msgBox.Text, recievers);
            showSentMessage(msgBox.Text);
            messageSent = true;
            msgBox.Text = "";
            error.Text = "";
            this.ActiveControl = msgBox;
        }

        private Boolean isMessageValid() 
        {
            if (msgBox.Text.Equals(""))
            {
                error.Text = "please enter text bellow";
                return false;
            }

            if (Participants.Count() == 1)
            {
                error.Text = "you're the only one in the room";
                return false;
            }

            if (listParticipants.CheckedItems.Count == 0)
            {
                error.Text = "please select at least one to recieve message";
                return false;
            }

            return true;
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

        private void selectAllParticipants()
        {
            for (int i = 0; i < listParticipants.Items.Count; i++)
                listParticipants.SetItemChecked(i, true);
        }

        public Button getSendBtn()
        {
            return sendBtn;
        }
        private void selectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (selectAll.Checked)
            {
                selectAllParticipants();
            }
        }
        
        private void showSentMessage(string message) {
            MessageUC msgUC = new MessageUC(message);
            flPnl.Controls.Add(msgUC);
            flPnl.ScrollControlIntoView(msgUC);
        }

        private void listParticipants_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Checked && selectAll.Checked)
            {
                selectAll.Checked = false;
            }
        }

        private void unselectAll_MouseHover(object sender, EventArgs e)
        {
            unselectAll.ForeColor = Color.FromName("DarkRed");
        }

        private void unselectAll_MouseLeave(object sender, EventArgs e)
        {
            unselectAll.ForeColor = Color.FromName("GrayText");
        }

        private void unselectAll_Click(object sender, EventArgs e)
        {
            selectAll.Checked = false;

            for (int i = 0; i < listParticipants.Items.Count; i++)
                listParticipants.SetItemChecked(i, false);
        }
    }
}
