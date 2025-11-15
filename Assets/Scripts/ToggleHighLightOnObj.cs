using UnityEngine;

public class ToggleHighLight : MonoBehaviour
{
    private bool isClicked = false;
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
        Debug.Log("Click on Object!" + transform.name);
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
