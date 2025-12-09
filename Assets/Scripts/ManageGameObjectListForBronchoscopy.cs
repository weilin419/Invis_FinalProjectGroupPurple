using UnityEngine;
using System.Collections.Generic;

public class ManageGameObjectListForBronchoscopy : MonoBehaviour
{
    // Creates an empty container named myObject specifically for holding GameObjects
    public List<GameObject> myObjList = new List<GameObject>(); 
    public GameObject welcomePanel;
    public GameObject nearTotalObstructionPanel , partialObstructionPanel , TEFPanel, fishBonePanel;

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
                //welcomePanel.SetActive(false);

                string objName = myObjList[0].name;
                if (objName == "nearTotalObstruction")
                {
                    Debug.Log("The panel should be actived!");
                    nearTotalObstructionPanel.SetActive(true);
                }
                else if (objName == "partialObstruction")
                {
                    partialObstructionPanel.SetActive(true);
                }
                else if (objName == "TEF")
                {
                    TEFPanel.SetActive(true);
                }
                else if (objName == "fishBone")
                {
                    fishBonePanel.SetActive(true);
                }
            }
        }

        //Reset visibility by Input keyDown of Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            for (int i = 0; i < transform.childCount ; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
                //Access the Outline Component in the ToggleHighLightForBronchoscopy.cs
                //We don't need any outline to highlight any objects.
                transform.GetChild(i).GetComponent<Outline>().enabled = false;

                //Rest the value of isClicked for the TToggleHighLightForBronchoscopy.cs
                transform.GetChild(i).GetComponent<ToggleHighLightForBronchoscopy>().isClicked = false;
            }

            // Clear the List
            myObjList.Clear();

            nearTotalObstructionPanel.SetActive(false);
            partialObstructionPanel.SetActive(false);
            TEFPanel.SetActive(false);
            fishBonePanel.SetActive(false);
            
            //welcomePanel.SetActive(true);
        }
    }
}
