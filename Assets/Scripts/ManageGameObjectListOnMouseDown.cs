using UnityEngine;
using System.Collections.Generic;

public class ManageGameObjectListOnMouseDown : MonoBehaviour
{
    // Wei modified this script that is referenced from Matt's recording of Managing GameObject List: 
    // https://canvas.gsa.ac.uk/courses/2804/pages/week-4-introduction-to-c-number-scripting-2?module_item_id=192435
    // Creates an empty container named myObject specifically for holding GameObjects
    public List<GameObject> myObjList = new List<GameObject>(); 
    public GameObject welcomePanel;
    public GameObject lungPanel, heartPanel, digestivePanel, liverPanel, kidneyPanel, diaphragmPanel;

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
            for (int i = 0; i < transform.childCount - 1 ; i++)
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
                welcomePanel.SetActive(false);

                string objName = myObjList[0].name;
                if (objName == "RespiratoryObj")
                {
                    lungPanel.SetActive(true);
                }
                else if (objName == "HeartObj")
                {
                    heartPanel.SetActive(true);
                }
                else if (objName == "DigestiveObj")
                {
                    digestivePanel.SetActive(true);
                }
                else if (objName == "LiverObj")
                {
                    liverPanel.SetActive(true);
                }
                else if (objName == "KidneyObj")
                {
                    kidneyPanel.SetActive(true);
                }
                else if (objName == "DiaphragmObj")
                {
                    diaphragmPanel.SetActive(true);
                }
            }
        }

        //Reset visibility by Input keyDown of Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            for (int i = 0; i < transform.childCount - 1 ; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
                //Access the Outline Component in the ToggleHighLightOnMouseDown.cs
                //We don't need any outline to highlight any objects.
                transform.GetChild(i).GetComponent<Outline>().enabled = false;

                //Rest the value of isClicked for the ToggleHighLightOnMouseDown.cs
                transform.GetChild(i).GetComponent<ToggleHighLightOnMouseDown>().isClicked = false;
            }

            // Clear the List
            myObjList.Clear();

            lungPanel.SetActive(false);
            heartPanel.SetActive(false);
            digestivePanel.SetActive(false);
            liverPanel.SetActive(false);
            kidneyPanel.SetActive(false);
            diaphragmPanel.SetActive(false);
            
            welcomePanel.SetActive(true);
        }
    }
}
