using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ToggleHighlights : MonoBehaviour
{
    
    private bool isClicked = false;

    // Script is from videos 7.1 and 7.2 in Matt's Week 4 Introduction to C# Scripting Canvas module vidoe playlist
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.GetComponent<Outline>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Click on Object " + transform.name);

        isClicked = !isClicked;

        if (isClicked)
        {
             transform.GetComponent<Outline>().enabled = true;
        }
        else
        {
             transform.GetComponent<Outline>().enabled = false;
        }
    }
}
