using UnityEngine;

public class ZombieAttackState : IZombieState
{
    private ZombieController controller;

    public ZombieState ZombieState { get; set; } = ZombieState.Attacking;

    public ZombieAttackState(ZombieController controller)
    {
        this.controller = controller;
    }
    public void EnterState()
    {
        controller.zombieState = ZombieState;

    }
    public void UpdateState()
    {
        bool playerInRange = Physics.CheckSphere(
        controller.transform.position,
        controller.zombieData.attackRange,
        controller.playerLayerMask
    );

        if (!playerInRange)
        {
            controller.ChangeState(new ZombieWalkState(controller));
        }
    }
    public void ExitState() { }
}
