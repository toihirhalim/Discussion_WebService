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
        DB db = new DB();
        [WebMethod]
        public List<Participant> Participer(string pseudo)
        {
            if (!db.Exist(pseudo))
            {
                db.Add(pseudo);
                return db.getListParticipants();
            }

            return null;
        }

        [WebMethod]
        public List<Participant> Quiter(string pseudo)
        {
            db.Delete(pseudo);
            return db.getListParticipants();
        }

        [WebMethod]
        public void SendMessage(string sender,string texte, string[] recievers)
        {
            db.addMessage(sender, texte, recievers.ToList());
        }

        [WebMethod]
        public List<Message> GetMessages(string pseudo)
        {
            return db.getMessages(pseudo);
        }

        [WebMethod]
        public List<Message> GetLatestMessages(string pseudo, string lastDate)
        {
            try
            {
                DateTime dt = DateTime.Parse(lastDate);
                return db.getLatestMessages(pseudo, dt);
            }
            catch (Exception)
            {
                return db.getMessages(pseudo);
            }

        }

        [WebMethod]
        public void QuiterParticipants(string [] pseudos)
        {
            db.Delete(pseudos.ToList());
        }

        [WebMethod]
        public void ClearAll()
        {
            db.Clear();
        }

    }
}
