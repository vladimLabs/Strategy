using UnityEngine;

public class Attack3 : MonoBehaviour, IAttack
{
    private Animator animator;
    private void Start()
    {
        animator = GameObject.Find("Warrior").GetComponent<Animator>();
    }
    public void Attack()
    {
        Debug.Log("Attack3");
        animator.SetTrigger("Attack3");
    }
}
