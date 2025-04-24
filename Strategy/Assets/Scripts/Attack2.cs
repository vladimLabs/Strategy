using UnityEngine;

public class Attack2 : MonoBehaviour, IAttack
{
    private Animator animator;
    private void Start()
    {
        animator = GameObject.Find("Warrior").GetComponent<Animator>();
    }
    public void Attack()
    {
        Debug.Log("Attack2");
        animator.SetTrigger("Attack2");
    }
}
