using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demoEnd : MonoBehaviour
{
    public GameObject demo;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
        if (demo != null)
            {
                demo.SetActive(true);
            }
        }
    }
}
