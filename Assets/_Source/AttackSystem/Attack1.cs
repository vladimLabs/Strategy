using UnityEngine;

namespace _Source.AttackSystem
{
    public class Attack1 : IAttackStrategy
    {
        public void Attack(Animator animator)
        {
            animator.SetTrigger("Attack1");
        }
    }
}
