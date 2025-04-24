using UnityEngine;
using UnityEngine.UI;

public class AttackPerformer : MonoBehaviour
{
    private IAttack currentAttack;

    [SerializeField] private Button meleeButton;
    [SerializeField] private Button kikButton;
    [SerializeField] private Button melee2Button;

    private void Start()
    {
        meleeButton.onClick.AddListener(() => SetAttackStrategy(GetComponent<Attack1>(), meleeButton));
        kikButton.onClick.AddListener(() => SetAttackStrategy(GetComponent<Attack2>(), kikButton));
        melee2Button.onClick.AddListener(() => SetAttackStrategy(GetComponent<Attack3>(), melee2Button));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PerformAttack();
        }
    }


    private void SetAttackStrategy(IAttack strategy, Button activeButton)
    {
        Debug.Log("SetAttackStrategy");
        currentAttack = strategy;
        HighlightButton(activeButton);
    }

    private void HighlightButton(Button activeButton)
    {
        // Сбросить подсветку всех кнопок
        ResetButtonHighlight(meleeButton);
        //ResetButtonHighlight(rangedButton);
        //ResetButtonHighlight(magicButton);

        // Подсветить текущую кнопку
        ColorBlock colors = activeButton.colors;
        colors.normalColor = Color.green;
        activeButton.colors = colors;
    }

    private void ResetButtonHighlight(Button button)
    {
        ColorBlock colors = button.colors;
        colors.normalColor = Color.white;
        button.colors = colors;
    }

    private void PerformAttack()
    {
        Debug.Log("PerformAttack");
        if (currentAttack != null)
        {
            currentAttack.Attack();
        }
        else
        {
            Debug.LogWarning("Текущая стратегия атаки не установлена!");
        }
    }
}
