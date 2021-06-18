using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS
{
    public class DB
    {
        static DCDataContext DC = new DCDataContext();

        public static void Add(string pseudo)
        {
            DC.Participant.InsertOnSubmit(new Participant() { Pseudo = pseudo });
            DC.SubmitChanges();
        }

        public static List<Participant> getListParticipants()
        {
            return DC.Participant.ToList();
        }

        public static bool Exist(string pseudo)
        {
            return DC.Participant.FirstOrDefault(t => t.Pseudo.Equals(pseudo)) != null;
        }

        public static void Delete(string pseudo)
        {
            Participant test = DC.Participant.FirstOrDefault(t => t.Pseudo.Equals(pseudo));

            if(pseudo != null)
            {
                DC.Participant.DeleteOnSubmit(test);
                DC.SubmitChanges();
            }
            // delete every message this participant involved
        }

        public static void addMessage(string sender, string texte, List<string> recievers)
        {
            //Participant senderParticipant = participants.Where(p => p.Pseudo.Equals(sender)).FirstOrDefault();

        }

        /*public static List<Message> getMessages(string pseudo)
        {
            return messages.Where(m => m.Sender.Pseudo.Equals(pseudo) || m.Recievers.Where(r => r.Pseudo.Equals(pseudo)).FirstOrDefault() != null).ToList();

        }*/

        public static void Clear()
        {
            DC.Participant.DeleteAllOnSubmit(DC.Participant);
            DC.SubmitChanges();
        }

        internal static void Delete(List<string> pseudos)
        {
            DC.Participant.DeleteAllOnSubmit(DC.Participant.Where(p => pseudos.Contains(p.Pseudo)));
            DC.SubmitChanges();
        }
    }
}