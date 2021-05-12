using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Threading;

namespace WS
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class ws_chat : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Add(int a, int b)
        {
            return a + b;
        }

        [WebMethod]
        public List<Client> GetClients()
        {
            Thread.Sleep(5000);

            List<Client> clients = new List<Client>();

            clients.Add(new Client(1, "Ali"));
            clients.Add(new Client(2, "Driss"));
            clients.Add(new Client(3, "Rachida"));
            clients.Add(new Client(4, "Mourad"));

            return clients;
        }
    }
}
