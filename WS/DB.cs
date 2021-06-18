using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS
{
    public class DB
    {
        DCDataContext DC = new DCDataContext();

        public void Add(string pseudo)
        {
            DC.Participant.InsertOnSubmit(new Participant() { Pseudo = pseudo });
            DC.SubmitChanges();
        }

        public List<Participant> getListParticipants()
        {
            List<Participant> participants;
            participants =  DC.Participant.ToList();
            foreach (Participant p in participants)
                p.Message = null;

            return participants;
        }

        public bool Exist(string pseudo)
        {
            return DC.Participant.FirstOrDefault(t => t.Pseudo.Equals(pseudo)) != null;
        }

        public void Delete(string pseudo)
        {
            Participant test = DC.Participant.FirstOrDefault(t => t.Pseudo.Equals(pseudo));
            
            if(pseudo != null)
            {
                DC.Message.DeleteAllOnSubmit(DC.Message.Where(m => m.Participant.Pseudo.Equals(pseudo)));
                DC.Participant.DeleteOnSubmit(test);
                DC.SubmitChanges();
            }
        }

        public void addMessage(string sender, string texte, List<string> recievers)
        {
            //Participant senderParticipant = participants.Where(p => p.Pseudo.Equals(sender)).FirstOrDefault();

        }

        public Message addMessage(string sender, string texte)
        {
            Participant participant = DC.Participant.FirstOrDefault(p => p.Pseudo.Equals(sender));
            
            if(participant != null && participant.Id != 0)
            {
                Message msg = new Message() { Msg = texte, Participant= participant };

                DC.Message.InsertOnSubmit(msg);
                DC.SubmitChanges();

                msg.Participant = null;
                return msg;
            }

            return null;
        }

        public List<Message> getMessages(string pseudo)
        {
            List<Message> messages = DC.Message.Where(m => m.Participant.Pseudo.Equals(pseudo)).ToList();
            foreach (Message msg in messages)
                msg.Participant = null;
            return messages;
        }

        public void Clear()
        {
            DC.Message.DeleteAllOnSubmit(DC.Message);
            DC.Participant.DeleteAllOnSubmit(DC.Participant);
            DC.SubmitChanges();
        }

        internal void Delete(List<string> pseudos)
        {
            DC.Message.DeleteAllOnSubmit(DC.Message.Where(m => pseudos.Contains(m.Participant.Pseudo)));
            DC.Participant.DeleteAllOnSubmit(DC.Participant.Where(p => pseudos.Contains(p.Pseudo)));
            DC.SubmitChanges();
        }
    }
}