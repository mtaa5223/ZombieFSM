using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu(fileName = "Zombie Data", menuName = "Scriptable Object/Zombie Data", order = int.MaxValue)]
public class ZombieScriptableObject : ScriptableObject
{
    public string zombieName;
    public int hp;
    public int damage;
    public float sightRange;
    public float moveSpeed;
    public float attackRange;
}
