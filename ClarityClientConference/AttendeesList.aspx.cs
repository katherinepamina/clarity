using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using ClarityClientConference.Models;

namespace ClarityClientConference
{
    public partial class AttendeesList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ClientDataSource.SelectParameters.Add("clientID", clientIDs);
        }

        //public IQueryable<Attendee> GetAttendees()
        //{
        //    var _db = new ClarityClientConference.Models.ClarityContext();
        //    var attendingClients = _db.Database.SqlQuery<int>("SELECT DISTINCT ClientId FROM dbo.Attendee");
                
        //        //("Select ClientID from Attendees").ToList<int>();
        //    IQueryable<Attendee> query = _db.Attendees;
        //    return query;
        //}

        public List<int> GetClientIds()
        {
            var _db = new ClarityClientConference.Models.ClarityContext();
            var attendingClients = _db.Database.SqlQuery<int>("SELECT DISTINCT ClientID FROM Attendees");

            return attendingClients.ToList<int>();
        }

        public List<List<Attendee>> GetAttendeesByClient()
        {
            var attendeeList = new List<List<Attendee>>();
            var _db = new ClarityClientConference.Models.ClarityContext();
            var clientIdList = GetClientIds();
            foreach (var cid in clientIdList)
            {
                var attendees = _db.Database.SqlQuery<Attendee>("SELECT * FROM Attendees WHERE ClientID = @cid", new SqlParameter("cid", cid)).ToList<Attendee>();
                if (attendees != null)
                {
                    attendeeList.Add(attendees);
                }
            }

            return attendeeList;
        }

        public List<Client> GetAttendingClients()
        {
            var clientList = new List<Client>();
            var _db = new ClarityClientConference.Models.ClarityContext();
            var clientIdList = GetClientIds();
            foreach (var cid in clientIdList)
            {  
                var client = _db.Database.SqlQuery<Client>("SELECT * FROM Clients WHERE ClientID = @cid", new SqlParameter("cid", cid)).FirstOrDefault();
                if (client != null)
                {
                    clientList.Add(client);
                }        
            }

            return clientList;
        }

        //public List<String> GetDisplay()
    }
}