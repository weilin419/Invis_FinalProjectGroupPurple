using UnityEngine;
using System.Collections.Generic;

public class ManageGameObjectList : MonoBehaviour
{
    // Creates an empty container named myObject specifically for holding GameObjects
    public List<GameObject> myObjList = new List<GameObject>(); 
    public GameObject instrctionPanel;
    public GameObject lungPanel, heartPanel, stomachPanel, liverPanel, kidneyPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Deactivate all objects.
            // Create for iteration
            for (int i = 0; i < transform.childCount; i++)
            {
                // Set deselected gameObject inactive, but selected objects stay active
                transform.GetChild(i).gameObject.SetActive(false);

                if (myObjList.Contains(transform.GetChild(i).gameObject))
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }

            if (myObjList.Count == 1)
            {
                instrctionPanel.SetActive(false);

                string objName = myObjList[0].name;
                if (objName == "LungObj")
                {
                    lungPanel.SetActive(true);
                }
                else if (objName == "HeartObj")
                {
                    heartPanel.SetActive(true);
                }
                else if (objName == "StomachObj")
                {
                    stomachPanel.SetActive(true);
                }
                else if (objName == "LiverObj")
                {
                    liverPanel.SetActive(true);
                }
                else if (objName == "KidneyObj")
                {
                    kidneyPanel.SetActive(true);
                }
            }
        }

        //Reset visibility by Input keyDown of Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
                //Access the Outline Component in the ToggleHighLightOnObj.cs
                //We don't need any outline to highlight any objects.
                transform.GetChild(i).GetComponent<Outline>().enabled = false;

                //Rest the value of isClicked for the ToggleHighLightOnObj.cs
                transform.GetChild(i).GetComponent<ToggleHighLight>().isClicked = false;
            }

            // Clear the List
            myObjList.Clear();

            lungPanel.SetActive(false);
            heartPanel.SetActive(false);
            stomachPanel.SetActive(false);
            liverPanel.SetActive(false);
            kidneyPanel.SetActive(false);
            
            instrctionPanel.SetActive(true);
        }
    }
}
