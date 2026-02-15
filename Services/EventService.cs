using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        public List<Event> Events { get; set; }

        public EventService()
        {
            Events = Enumerable.Range(1, 1000).Select(i =>
                new Event
                {
                    Id = i,
                    EventName = $"Event {i}",
                    Date = DateTime.Now.AddDays(i),
                    Location = "Various Locations"
                }).ToList();
        }
    }
}
