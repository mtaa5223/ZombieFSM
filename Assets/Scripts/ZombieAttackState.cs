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
        controller.zombieVisualizer.PlayAnim(ZombieState);
    }
    public void UpdateState()
    {
        // 공격 쿨타임, 타겟 검사 등을 여기에
    }

    public void ExitState() { }
}
