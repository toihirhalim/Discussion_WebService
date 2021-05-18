using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS
{
    public class Participant
    {
        public int Id { get; set; }
        public string Pseudo { get; set; }

        public Participant() { }

        public Participant(string pseudo)
        {
            Pseudo = pseudo;
        }
    }
}