using AttackSystem;
using UnityEngine;

namespace Core
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private KeyCode _attackKeyCode;
        private AttackPerformer _attackPerformer;

        public void Construct(AttackPerformer attackPerformer)
        {
            _attackPerformer = attackPerformer;
        }

        private void Update()
        {
            CheckAttack();
        }

        private void CheckAttack()
        {
            if (Input.GetKeyDown(_attackKeyCode))
            {
                if (_attackPerformer != null)
                    _attackPerformer.PerformAttack();
            }
        }
    }
}