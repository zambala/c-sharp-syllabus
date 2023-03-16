namespace DragRace.Interfaces
{
    public interface ICar
    {
        void SpeedUp();
        void SlowDown();
        string ShowCurrentSpeed();
        void StartEngine();
    }
}
