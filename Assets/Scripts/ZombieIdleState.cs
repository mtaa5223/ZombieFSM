using System;
using UnityEngine;
public class ZombieIdleState : IZombieState
{
    private ZombieController controller;
    public ZombieBase zombieBase;
    public ZombieState ZombieState { get; set; } = ZombieState.Idle;

    public ZombieIdleState(ZombieController controller)
    {
        this.controller = controller;
    }
    public void EnterState()
    {
        controller.zombieState = ZombieState;
        controller.zombieVisualizer.PlayAnim(ZombieState);
    }
    public void UpdateState()
    {

    }

    public void ExitState() { }
}
