using UnityEngine;

public class ZombieVisualizer : MonoBehaviour
{
    public Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void PlayAnim(ZombieState state)
    {
        switch (state)
        {
            case ZombieState.Walking:
                anim.SetTrigger("Walk");
                break;
            case ZombieState.Attacking:
                anim.SetTrigger("Attack");
                break;
            case ZombieState.Dead:
                anim.SetTrigger("Die");
                break;
            default:
                anim.SetTrigger("Idle");
                break;
        }
    }
}
