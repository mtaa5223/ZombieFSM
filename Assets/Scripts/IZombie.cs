public interface IZombieState
{
    ZombieState ZombieState { get; set; }
    void EnterState();
    void UpdateState();
    void ExitState();
}
public enum ZombieState
{
    Idle,
    Walking,
    Attacking,
    Dying,
    Dead
}