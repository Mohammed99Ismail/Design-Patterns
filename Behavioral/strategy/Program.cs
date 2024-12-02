
public class Strategy
{
    public class User
    {
        public User(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }

    public interface INotification
    {
        void SendNotification(User user, string message);
    }

    public class SMS : INotification
    {
        public void SendNotification(User user, string message)
        {
            Console.WriteLine($"Sending SMS Notification for {user.Name}: {message}");
        }
    }

    public class Email : INotification
    {
        public void SendNotification(User user, string message)
        {
            Console.WriteLine($"Sending Email Notification for {user.Name}: {message}");
        }
    }

    public class Massenger : INotification
    {
        public void SendNotification(User user, string message)
        {
            Console.WriteLine($"Sending Massenger Notification for {user.Name}: {message}");
        }
    }

    public class Slack : INotification
    {
        public void SendNotification(User user, string message)
        {
            Console.WriteLine($"Sending Slack Notification for {user.Name}: {message}");
        }
    }

    public class Program
    {
        public static void Main()
        {
            User ahmed = new User("ahmed");

            var sms = new SMS();
            sms.SendNotification(ahmed, "new product added");

            var email = new Email();
            email.SendNotification(ahmed, "new product added");

            var massenger = new Massenger();
            massenger.SendNotification(ahmed, "new product added");

            var slack = new Slack();
            slack.SendNotification(ahmed, "new product added");
        }
    }
}
