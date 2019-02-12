namespace ECS.Legacy
{
    public class Application
    {
        public static void Main(string[] args)
        {
            // Because of constructor injection, allocation is done in the constructor. 
            // Ability to chose which derivatives one wants to work with
            var ecs = new ECS(28, new TempSensor(), new Heater());

            ecs.Regulate();

            ecs.SetThreshold(20);

            ecs.Regulate();
        }
    }
}
