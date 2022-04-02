using UnityEngine;

[CreateAssetMenu(fileName = "Tutorial Text", menuName = "Tutorial/Texts", order = 0)]
public class TutorialText : ScriptableObject
{
    [SerializeField] private string text;
    [SerializeField] private string showKey;
    [SerializeField] private bool activateCooldown;
    [SerializeField] private bool activateHealth;
    [SerializeField] private bool activateGoal;

    public string GetText() { return text; }
    public string GetKey() { return showKey; }

    public bool GetCooldownState() { return activateCooldown; }
    public bool GetHealthState()   { return activateHealth;   }
    public bool GetGoalState() { return activateGoal; }
}
