namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public string Direction { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
           public virtual void Turn()
        {
            Console.WriteLine("The vehicle carefully turnt " + Direction);
        }
           public virtual void Stop()
        {
            Console.WriteLine("Vrooom!");
        }
    }
}