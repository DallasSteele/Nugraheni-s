using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class correctButton : MonoBehaviour
{
    [SerializeField, Multiline]
    public string answerText;
    public quizManager quizManager;
    public GameObject ladder;
    public Vector2 pressedButtonScale = new Vector2(1f, 0.8f); 
    public float pressedButtonOffset = -0.2f;
    private Vector3 originalPosition;
    private Vector3 originalScale;
    public bool isPressed = false;

     private void Start()
    {
        originalScale = transform.localScale;
        originalPosition = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isPressed && other.CompareTag("Player")) 
        {
            isPressed = true;

            if (quizManager != null)
            {
                quizManager.OnButtonPressed(this);
            }

            // Change the scale & position to the pressedButton
            if (pressedButtonScale != Vector2.zero)
            {
                transform.localScale = new Vector3(pressedButtonScale.x, pressedButtonScale.y, 1f);
                transform.position += new Vector3(0f, pressedButtonOffset, 0f);
            }

            if (ladder != null)
            {
                ladder.SetActive(true);
            }


            // Add any additional logic you want to perform when the button is pressed
            // For example, triggering an event, opening a door, etc.
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (isPressed && other.CompareTag("Player"))
        {
            isPressed = false;

            // Reset the scale to the original scale
            //transform.localScale = originalScale;

            // Additional logic when the player leaves the button trigger
        }
    }

    public void ResetButton()
    {
        isPressed = false;
        transform.position = originalPosition;
        transform.localScale = originalScale;
    }








    /*public Sprite pressedButtonSprite;
    private SpriteRenderer spriteRenderer;


    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError("Sprite Renderer component not found.");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           /* if (spriteRenderer != null && pressedButtonSprite != null)
            {
                spriteRenderer.sprite = pressedButtonSprite;
            }*//*

             if (spriteRenderer != null)
            {
                if (pressedButtonSprite != null)
                {
                    spriteRenderer.sprite = pressedButtonSprite;
                    Debug.Log("Button Pressed - Sprite Changed");
                }
                else
                {
                    Debug.LogError("Pressed Button Sprite is not assigned.");
                }
            }
            else
            {
                Debug.LogError("SpriteRenderer component not found on the button GameObject.");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("player left the button");
        }
    }*/
}
