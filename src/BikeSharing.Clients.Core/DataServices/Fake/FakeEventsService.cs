using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BikeSharing.Clients.Core.DataServices.Interfaces;
using BikeSharing.Clients.Core.Models.Events;
using System.Linq;

namespace BikeSharing.Clients.Core.DataServices.Fake
{
    public class FakeEventsService : IEventsService
    {
        private static List<Event> events = new List<Event>
        {
            new Event
            {
                Name = "NBA Match",
                Venue = new Venue
                {
                    Name = "New York Knicks vs. Brooklyn Nets"
                },
                StartTime = DateTime.Now,
                ImagePath = "https://i.turner.ncaa.com/ncaa/big/2016/03/21/379123/1458530071096-mbk-312-wisconsin-xavier-1920.jpg-379123.960x540.jpg"
			},
            new Event
            {
                Name = "Music Ride",
                Venue = new Venue
                {
                    Name = "Green day"
                },
                StartTime = DateTime.Now,
                ImagePath = "http://s1.ticketm.net/dam/c/7be/4e1e9428-29ec-401f-aa45-f1577614b7be_105421_TABLET_LANDSCAPE_LARGE_16_9.jpg"
			}
        };

        public Task<Event> GetEventById(int eventId)
        {
            var data = events[0];

            return Task.FromResult(data);
        }

        public Task<IEnumerable<Event>> GetEvents()
        {
            var data = Enumerable.Range(0, 4).Select((index) => events[index % events.Count]);

            return Task.FromResult(data);
        }
    }
}
