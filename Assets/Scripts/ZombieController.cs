using UnityEngine;

public class ZombieController : MonoBehaviour
{
    public ZombieState zombieState = ZombieState.Idle;

    public ZombieScriptableObject zombieData;
    public ZombieVisualizer zombieVisualizer;

    public IZombieState currentState;

    void Start()
    {
        ChangeState(new ZombieWalkState(this));
    }
    void Update()
    {
        currentState?.UpdateState();
        // 테스트: 스페이스 누르면 공격 상태 전환
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeState(new ZombieAttackState(this));
        }
    }
    public void ChangeState(IZombieState newState)
    {
        currentState?.ExitState();
        currentState = newState;
        currentState.EnterState();
    }
}
