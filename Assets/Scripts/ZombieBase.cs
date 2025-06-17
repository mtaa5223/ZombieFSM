using UnityEngine;

public class ZombieBase : MonoBehaviour
{
    public ZombieState ZombieState { get; set; } = ZombieState.Walking;
    public ZombieScriptableObject zombieData;
    public ZombieVisualizer zombieVisualizer;
    public ZombieController zombieController;
}
