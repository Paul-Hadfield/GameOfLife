namespace GameOfLife.Seeders
{
    public class SeederFactory
    {
        public IDefineASeeder Create()
        {
            return new BlinkerSeeder();
        }
    }
}
