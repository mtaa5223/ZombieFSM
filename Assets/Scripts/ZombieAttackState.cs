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
        Collider[] hits = Physics.OverlapSphere(controller.transform.position, controller.zombieData.attackRange);

        foreach (var col in hits)
        {
            if (col.CompareTag("Player"))
            {
                controller.zombieVisualizer.PlayAnim(ZombieState);
            }
        }
    }

    public void ExitState() { }
}
