namespace TEST
{
    public interface Vahicle
    {

        public void Start();
        public void Stop();
    }
    public class Car : Vahicle
    {
        public void Start()
        {
            Console.WriteLine("implement metthod start by interface veghicle.");
        }
        public void Stop()
        {
            Console.WriteLine("implement metthod stop by interface veghicle.");

        }
    }
}