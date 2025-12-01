using UnityEngine;
using System.Collections.Generic;

public class ManageGameObjectList : MonoBehaviour
{
    // Creates an empty container named myObject specifically for holding GameObjects
    public List<GameObject> myObjList = new List<GameObject>(); 
    public GameObject welcomePanel;
    public GameObject oralCavityPanel, nasalCavity, pharynxPanel, larynxPanel, tracheaPanel, bronchiPanel, lungPanel;

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
            for (int i = 0; i < transform.childCount -1; i++)
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
                if (objName == "OralCavity")
                {
                    oralCavityPanel.SetActive(true);
                }
                else if (objName == "NasalCavity")
                {
                    nasalCavity.SetActive(true);
                }
                else if (objName == "Pharynx")
                {
                    pharynxPanel.SetActive(true);
                }
                else if (objName == "Larynx")
                {
                    larynxPanel.SetActive(true);
                }
                else if (objName == "Trachea")
                {
                    tracheaPanel.SetActive(true);
                }
                else if (objName == "Bronchi")
                {
                    bronchiPanel.SetActive(true);
                }
                else if (objName == "Lung")
                {
                    lungPanel.SetActive(true);
                }
            }
        }

        //Reset visibility by Input keyDown of Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            for (int i = 0; i < transform.childCount -1; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
                //Access the Outline Component in the ToggleHighLightOnObj.cs
                //We don't need any outline to highlight any objects.
                transform.GetChild(i).GetComponent<Outline>().enabled = false;

                //Rest the value of isClicked for the ToggleHighLightOnObj.cs
                transform.GetChild(i).GetComponent<ToggleHighLightOnObj>().isClicked = false;
            }

            // Clear the List
            myObjList.Clear();

            oralCavityPanel.SetActive(false);
            nasalCavity.SetActive(false);
            pharynxPanel.SetActive(false);
            larynxPanel.SetActive(false);
            tracheaPanel.SetActive(false);
            bronchiPanel.SetActive(false);
            lungPanel.SetActive(false);
            
            welcomePanel.SetActive(true);
        }
    }
}
