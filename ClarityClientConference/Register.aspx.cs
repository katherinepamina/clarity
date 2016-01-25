using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClarityClientConference.Models;

namespace ClarityClientConference
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void InsertAttendee(string name, string email, string client)
        {
            AttendeeManager aMgr = new AttendeeManager();
            aMgr.Add(name, email, client);
        }

        protected void registerBtn_click(object sender, EventArgs e)
        {
            // validate data first
            InsertAttendee(name.Text, email.Text, client.Text);
        }
    }
}