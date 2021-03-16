﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Adding Numbers Calculation Marco Lindner

public class AddNumbers : MonoBehaviour
{
    public InputField num1_in;
    public InputField num2_in;

    public Text result;
    public float num1;
    public float num2;
   

    bool correctIn1 = false;
    bool correctIn2 = false;

    public void AddNumbersOnClick()
    {
     try
        {
            num1 = float.Parse(num1_in.text);
            correctIn1 = true;
        }
        catch (System.Exception)
        {
            num1_in.image.color = new Color32(255,0,0,100);
            correctIn1 = false;
        }

        try
        {
            num2 = float.Parse(num2_in.text);
            correctIn2 = true;
        }
        catch (System.Exception)
        {
            num2_in.image.color = new Color32(255,0,0,100);
            correctIn2 = false;
        }
        
        if (correctIn1 == true && correctIn2 == true)
        {
            float addResult = num1 + num2;
            result.text = addResult.ToString();
        }
        else
        {
            result.text = "Incorrect Input";
        }
        
    }
}
