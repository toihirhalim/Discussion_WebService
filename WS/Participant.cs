using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS
{
    public class Participant
    {
        static int Serial = 1;
        public int Id { get; set; }
        public string Pseudo { get; set; }

        public Participant() { }

        public Participant(string pseudo)
        {
            Id = Serial++;
            Pseudo = pseudo;
        }
    }
}