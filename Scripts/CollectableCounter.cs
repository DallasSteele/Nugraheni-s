using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectableCounter : MonoBehaviour
{
    public static CollectableCounter instance;
    public TMP_Text CollectableText;
    public int currentCollectables = 0;

    void Awake()
    {
        instance = this;
    }    

    void Start()
    {
        CollectableText.text = "Barrel : " + currentCollectables.ToString();
    }

    public void IncreaseCollectables(int v)
    {
        currentCollectables += v;
        CollectableText.text = "Barrel : " + currentCollectables.ToString();
    }

}
