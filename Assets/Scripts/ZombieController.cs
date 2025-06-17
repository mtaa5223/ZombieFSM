using UnityEngine;

public class ZombieController : MonoBehaviour
{
    public ZombieState zombieState = ZombieState.Idle;
    public ZombieScriptableObject zombieData;
    public ZombieVisualizer zombieVisualizer;
    public ZombieWalkState zombieWalkState;
    public ZombieIdleState zombieIdleState;


    public IZombieState currentState;

    void Start()
    {
        ChangeState(new ZombieIdleState(this));
    }
    void Update()
    {
        currentState?.UpdateState();
    }
    public void ChangeState(IZombieState newState)
    {
        currentState?.ExitState();
        currentState = newState;
        currentState.EnterState();
    }
}
