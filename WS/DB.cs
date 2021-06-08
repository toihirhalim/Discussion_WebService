using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS
{
    public class DB
    {
        static List<Participant> participants = new List<Participant>();

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
        }

        public static void Clear()
        {
            participants.Clear();
        }

        internal static void Delete(List<string> pseudos)
        {
            participants.RemoveAll(p => pseudos.Contains(p.Pseudo));
        }
    }
}