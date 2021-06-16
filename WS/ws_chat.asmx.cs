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
        public List<Participant> Participer(string pseudo)
        {
            if (!DB.Exist(pseudo))
            {
                DB.Add(pseudo);
                return DB.getListParticipants();
            }

            return null;
        }

        [WebMethod]
        public List<Participant> Quiter(string pseudo)
        {
            DB.Delete(pseudo);
            return DB.getListParticipants();
        }

        [WebMethod]
        public void SendMessage(string sender,string texte, string[] recievers)
        {
            DB.addMessage(sender, texte, recievers.ToList());
        }

        [WebMethod]
        public List<Message> GetMessages(string pseudo)
        {
            return DB.getMessages(pseudo);
        }

        [WebMethod]
        public void QuiterParticipants(string [] pseudos)
        {
            DB.Delete(pseudos.ToList());
        }

        [WebMethod]
        public void ClearAll()
        {
            DB.Clear();
        }

    }
}
