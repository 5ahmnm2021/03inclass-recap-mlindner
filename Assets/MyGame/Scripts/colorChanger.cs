using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Changes the Color of the Square when Space is clicked.

// Colors from Adobe Color: https://color.adobe.com/create/color-wheel

public class colorChanger : MonoBehaviour
{
    public GameObject color;
    
// Defining Colors
    public void ChangeColor()
    {
        Color[] colors =
        {
            new Color32(35,123,173,68),
            new Color32(250,100,105,98),
            new Color32(75,186,250,98),
            new Color32(250,246,50,98),
            new Color32(173,171,43,68),
        };

        if (Input.GetKeyDown("space"))
        {
            color.GetComponent<Image>().color = colors[Random.Range(0, colors.Length)];
        }
    }

    void Update()
    {
        ChangeColor();
    }
}