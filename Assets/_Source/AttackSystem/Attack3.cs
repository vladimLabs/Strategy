using UnityEngine;

namespace _Source.AttackSystem
{
    public class Attack3 : IAttackStrategy
    {
        public void Attack(Animator animator)
        {
            animator.SetTrigger("Attack3");
        }
    }
}
