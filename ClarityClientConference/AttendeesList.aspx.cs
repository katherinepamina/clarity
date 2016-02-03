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

        public List<Attendee> GetAttendeesByClient()
        {
            var attendeeList = new List<Attendee>();
            var _db = new ClarityClientConference.Models.ClarityContext();
            var clientIdList = GetClientIds();
            foreach (var cid in clientIdList)
            {
                var attendees = _db.Database.SqlQuery<Attendee>("SELECT * FROM Attendees WHERE ClientID = @cid", new SqlParameter("cid", cid)).ToList<Attendee>();
                if (attendees != null)
                {
                    attendeeList.AddRange(attendees);
                }
            }

            return attendeeList;
        }

        public List<String> GetClientsAndAttendees()
        {
            var returnString = new List<String>();
            var clientList = GetAttendingClients();
            foreach (var client in clientList)
            {
                returnString.Add(client.Name);                      // 0
                returnString.Add(client.PhoneNumber);               // 1
                returnString.Add(client.Email);                     // 2
                returnString.Add(client.Street);                    // 3
                returnString.Add(client.City);                      // 4
                returnString.Add(client.State);                     // 5
                returnString.Add(client.ZipCode.ToString());        // 6

                var attendees = GetAttendeesForClient(client.ClientID);
                string attendeeNames = "";
                foreach (var a in attendees)
                {
                    attendeeNames = attendeeNames + " \n " + a.Name;
                }
                returnString.Add(attendeeNames);
            }
            return returnString;
        }

        public List<Attendee> GetAttendeesForClient(int cid)
        {
            var _db = new ClarityClientConference.Models.ClarityContext();
            var attendees = _db.Database.SqlQuery<Attendee>("SELECT * FROM Attendees WHERE ClientID = @cid", new SqlParameter("cid", cid)).ToList<Attendee>();
            return attendees.ToList();
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