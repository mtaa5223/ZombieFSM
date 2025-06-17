using System;
using UnityEngine;
public class ZombieWalkState : IZombieState
{
    private ZombieController controller;
    public ZombieState ZombieState { get; set; } = ZombieState.Walking;

    public ZombieWalkState(ZombieController controller)
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

        bool playerInSight = Physics.CheckSphere(
      controller.transform.position,
      controller.zombieData.sightRange,
      controller.playerLayerMask
  );
        if (playerInRange)
        {
            controller.ChangeState(new ZombieAttackState(controller));
        }
        if (!playerInSight)
        {
            controller.ChangeState(new ZombieIdleState(controller));
        }

        controller.transform.Translate(Vector3.forward * controller.zombieData.moveSpeed * Time.deltaTime);
    }
    public void ExitState() { }
}
