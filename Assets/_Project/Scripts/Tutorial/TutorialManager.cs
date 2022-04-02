using System;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class TutorialManager : MonoBehaviour
{
    [Header("Texts")]
    [SerializeField] private TutorialText[] texts;
    [SerializeField] private TMP_Text tutText;
    [SerializeField] private TMP_Text keyboard;

    [SerializeField] private GameObject cooldownBar;
    [SerializeField] private GameObject healthCrystal;
    [SerializeField] private GameObject goal;

    private int index;

    private void Start()
    {
        tutText.text = texts[index].GetText();
        keyboard.text = texts[index].GetKey();
        
        cooldownBar.SetActive(false);
        healthCrystal.SetActive(false);
        goal.SetActive(false);
        Destroy(healthCrystal.GetComponent<BoxCollider2D>());
        Destroy(goal.GetComponent<BoxCollider2D>());
    }

    public void Accept(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            index++;
            tutText.text = texts[index].GetText();
            keyboard.text = texts[index].GetKey();

            if (texts[index].GetCooldownState())
            {
                cooldownBar.SetActive(true);
            }

            if (texts[index].GetHealthState())
            {
                healthCrystal.SetActive(true);
                healthCrystal.AddComponent<BoxCollider2D>();
                healthCrystal.GetComponent<BoxCollider2D>().isTrigger = true;
            }

            if (texts[index].GetGoalState())
            {
                goal.SetActive(true);
                goal.AddComponent<BoxCollider2D>();
                goal.GetComponent<BoxCollider2D>().isTrigger = true;
            }
        }
    }
}
