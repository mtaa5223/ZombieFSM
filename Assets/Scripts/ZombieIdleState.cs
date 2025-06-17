using System;
using UnityEngine;
public class ZombieIdleState : IZombieState
{
    private ZombieController controller;
    public ZombieState ZombieState { get; set; } = ZombieState.Idle;

    public ZombieIdleState(ZombieController controller)
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
         controller.zombieData.sightRange,
         controller.playerLayerMask
     );

        if (playerInRange)
        {
            controller.ChangeState(new ZombieWalkState(controller));
        }
    }

    public void ExitState() { }
}
