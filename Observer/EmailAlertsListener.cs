namespace Observer;

public class EmailAlertsListener(string email, string message) : IEventListener {
    private readonly string email = email;
    private readonly string message = message;

    public void Update(string filename) {
        Console.WriteLine($"Email: {string.Format(message, filename)} to {email}");
    }
}