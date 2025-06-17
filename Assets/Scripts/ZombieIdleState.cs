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
        Collider[] hitColliders = Physics.OverlapSphere(controller.transform.position, controller.zombieData.sightRange);

        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.CompareTag("Player"))
            {
                controller.ChangeState(new ZombieWalkState(controller));
            }
        }

        // If no player is detected, stay idle
        controller.zombieVisualizer.PlayAnim(ZombieState);
    }

    public void ExitState() { }
}
