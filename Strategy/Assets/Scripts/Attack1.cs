using UnityEngine;

public class Attack1 : MonoBehaviour, IAttack
{
    private Animator animator;
    private void Start()
    {
        animator = GameObject.Find("Warrior").GetComponent<Animator>();
    }
    public void Attack()
    {
        Debug.Log("Attack1");
        animator.SetTrigger("Attack1");
    }
}
