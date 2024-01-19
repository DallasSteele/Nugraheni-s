using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quizManager : MonoBehaviour
{
    private correctButton[] buttons;
    private void Start()
    {
        buttons = FindObjectsOfType<correctButton>();
    }

    public void OnButtonPressed(correctButton selectedButton)
    {
        foreach (correctButton button in buttons)
        {
            if (button == selectedButton)
            {
                button.isPressed = true;
            }
            else
            {
                button.ResetButton();
            }
        }
    }
}
