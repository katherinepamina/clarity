using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ClarityClientConference.Models
{
    public class ClarityDatabaseInitializer : DropCreateDatabaseIfModelChanges<ClarityContext>
    {
        protected override void Seed(ClarityContext context)
        {
            GetAttendees().ForEach(a => context.Attendees.Add(a));
            GetClients().ForEach(c => context.Clients.Add(c));
        }

        private static List<Attendee> GetAttendees()
        {
            var attendees = new List<Attendee> {
                new Attendee
                {
                    AttendeeID = 1,
                    ClientID = 1,
                    Name = "Bill Smith",
                    Email = "Bill@client1.com"
                },
                new Attendee
                {
                    AttendeeID = 2,
                    ClientID = 1,
                    Name = "Jim Smith",
                    Email = "jim@client1.com"
                },
            };
            return attendees;
        }

        private static List<Client> GetClients()
        {
            var clients = new List<Client>
            {
                new Client
                {
                    ClientID = 1,
                    Name = "Client 1",
                    PhoneNumber = "727-123-4567",
                    Email = "info@client1.com",
                    Street = "1234 Landmark Way",
                    City = "Pal Harbor",
                    State = "FL",
                    ZipCode = 34684
                },
                new Client
                {
                    ClientID = 2,
                    Name = "Client 2",
                    PhoneNumber = "281-123-4567",
                    Email = "info@client2.com",
                    Street = "4321 Quial Field Dr",
                    City = "Houston",
                    State = "TX",
                    ZipCode = 77095
                },
                new Client
                {
                    ClientID = 3,
                    Name = "Client 3",
                    PhoneNumber = "312-636-9898",
                    Email = "info@client3.com",
                    Street = "120 W Wacker Dr",
                    City = "Chicago",
                    State = "IL",
                    ZipCode = 60606
                },
            };
            return clients;
        }
    }
}