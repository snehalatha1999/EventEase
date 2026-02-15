using EventEase.Models;

namespace EventEase.Services
{
    public class UserSessionService
    {
        public string? UserName { get; private set; }
        public List<int> RegisteredEventIds { get; private set; } = new();

        public void StartSession(string name) => UserName = name;

        public void RegisterForEvent(int eventId)
        {
            if (!RegisteredEventIds.Contains(eventId))
                RegisteredEventIds.Add(eventId);
        }

        public bool IsRegistered(int eventId) => RegisteredEventIds.Contains(eventId);

        public void EndSession()
        {
            UserName = null;
            RegisteredEventIds.Clear();
        }
    }
}
