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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void InsertAttendee(string name, string email, int client)
        {
            AttendeeManager aMgr = new AttendeeManager();
            aMgr.Add(name, email, client);
        }

        protected void registerBtn_click(object sender, EventArgs e)
        {
            // validate data first
            String attendeeName = name.Text;
            String attendeeEmail = email.Text;
            String attendeeCompany = client.Text;

            // Get clientID from textbox (error if not found)
            var _db = new ClarityClientConference.Models.ClarityContext();
            var cid = _db.Database.SqlQuery<int>("SELECT DISTINCT ClientID FROM Clients WHERE Name = @attendeeCompany", new SqlParameter("attendeeCompany", attendeeCompany)).FirstOrDefault();
            if (cid < 1)
            {
                // Client not found
                successLabel.Text = "Company was not found in Clarity's client database.  Is there a misspelling?";
            }
            else
            {
                InsertAttendee(attendeeName, attendeeEmail, cid);
                successLabel.Text = "Registration successful!";
            }      
        }
    }
}