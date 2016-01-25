using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClarityClientConference.Models;

namespace ClarityClientConference
{
    public partial class AttendeesList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Attendee> GetAttendees()
        {
            var _db = new ClarityClientConference.Models.ClarityContext();
            IQueryable<Attendee> query = _db.Attendees;
            return query;
        }
    }
}