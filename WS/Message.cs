using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS
{
    public class Message
    {
        static int serial = 1;
        public int Id { get; set; }
        public string Texte { get; set; }
        public Participant sender { get; set; }
        public List<Participant> recievers { get; set; }

        public Message()
        {

        }
        public Message(string texte)
        {
            Id = serial++;
            Texte = texte;
        }
    }
}