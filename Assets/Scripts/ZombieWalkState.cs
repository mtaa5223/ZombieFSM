using System;
using UnityEngine;
public class ZombieWalkState : IZombieState
{
    private ZombieController controller;
    public ZombieBase zombieBase;
    public ZombieState ZombieState { get; set; } = ZombieState.Walking;

    public ZombieWalkState(ZombieController controller)
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
        if (zombieBase.zombieData.sightRange > 0)
        {
            Collider[] hitColliders = Physics.OverlapSphere(controller.transform.position, zombieBase.zombieData.sightRange);
            foreach (var hitCollider in hitColliders)
            {
                if (hitCollider.CompareTag("Player"))
                {
                    controller.ChangeState(new ZombieAttackState(controller));
                    return;
                }
            }
        }
        controller.transform.Translate(Vector3.forward * zombieBase.zombieData.moveSpeed * Time.deltaTime);
    }
    public void ExitState() { }
}
