using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public Client()
        {
        }

        public Client(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }
    }
}