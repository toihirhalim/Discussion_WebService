using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS
{
    public class DB
    {
        static List<Participant> participants = new List<Participant>();
        static List<Message> messages = new List<Message>();

        public static void Add(string pseudo)
        {
            participants.Add(new Participant(pseudo));
        }

        public static List<Participant> getListParticipants()
        {
            return participants;
        }

        public static bool Exist(string pseudo)
        {
            Participant participant = participants.Where(p => p.Pseudo.Equals(pseudo)).FirstOrDefault();

            return participant != null;
        }

        public static void Delete(string pseudo)
        {
            participants = participants.Where(p => !p.Pseudo.Equals(pseudo)).ToList();
            messages.RemoveAll(m => m.Sender.Pseudo.Equals(pseudo));
            messages.Select(m => m.Recievers.RemoveAll(r => r.Pseudo.Equals(pseudo)));
        }

        public static void addMessage(string sender, string texte, List<string> recievers)
        {
            Participant senderParticipant = participants.Where(p => p.Pseudo.Equals(sender)).FirstOrDefault();

        }

        public static List<Message> getMessages(string pseudo)
        {
            return messages.Where(m => m.Sender.Pseudo.Equals(pseudo) || m.Recievers.Where(r => r.Pseudo.Equals(pseudo)).FirstOrDefault() != null).ToList();

        }

        public static void Clear()
        {
            participants.Clear();
            messages.Clear();
        }

        internal static void Delete(List<string> pseudos)
        {
            participants.RemoveAll(p => pseudos.Contains(p.Pseudo));
            messages.RemoveAll(m => pseudos.Contains(m.Sender.Pseudo));
            messages.Select(m => m.Recievers.RemoveAll(r => pseudos.Contains(r.Pseudo)));
        }
    }
}