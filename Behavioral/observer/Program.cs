
public class Observer
{
    public interface ISubscriber
    {
        void Notify(string message);
    }

    public class Reader : ISubscriber
    {
        public string Name { get; set; }
        public Reader(string name) 
        {
            this.Name = name;
        }
        public void Notify(string message)
        {
            Console.WriteLine(message + ":" + Name);
        }
    }

    public class NewsLetter
    {
        public List<ISubscriber> subscribers { get; set; }
        public NewsLetter() 
        {
            subscribers = new List<ISubscriber>();
        }
        public void AddNewSubscriber(Reader reader)
        {
            subscribers.Add(reader);
        }

        public void PublishNewNewLetter()
        {
            var message = "Hi, new NewLetter are published!";
            subscribers.ForEach(val => {
                val.Notify(message);
            });
        }
    }

    public class Program
    {
        public static void Main()
        {
            var reader = new Reader("Mohammed");

            var newsletter = new NewsLetter();
            newsletter.AddNewSubscriber(reader);
            newsletter.PublishNewNewLetter();
        }
    }
}
