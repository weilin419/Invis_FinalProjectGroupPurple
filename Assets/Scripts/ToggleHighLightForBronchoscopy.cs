using UnityEngine;

public class ToggleHighLightForBronchoscopy : MonoBehaviour
{
    // Script is from videos 7.1 and 7.2 in Matt's Week 4 Introduction to C# Scripting Canvas module vidoe playlist
    // Wei modified it for use.
    
    public bool isClicked = false;
    
    public GameObject myManagerObj;
    //Access the list we just created in the Script of ManageGameObjectListForBronchoscopy in the script of ToggleHighLightOnMouseDown.
    //Declares a variable to store a reference to another script
    private ManageGameObjectListForBronchoscopy myManageGameObjectListForBronchoscopy; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.GetComponent<Outline>().enabled = false;
        //Find the object named "Manager" in the Unity Project and Associate object with it.
        myManagerObj = transform.parent.gameObject;//GameObject.Find("Manager");
        //Access the script from the game object.
        // Finds the GameObject and gets the actual reference to the script component
        myManageGameObjectListForBronchoscopy = myManagerObj.transform.GetComponent<ManageGameObjectListForBronchoscopy>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickOnObjInImage()
    {
        Debug.Log("Click on Object!" + transform.name);
        isClicked = !isClicked;

        if (isClicked)
        {
            transform.GetComponent<Outline>().enabled = true;
            //Once the objct is highlighted, we will add the object to the list
            // Uses that reference to access the public list in another script and add the object
            myManageGameObjectListForBronchoscopy.myObjList.Add(transform.gameObject);
        }
        else
        {
            transform.GetComponent<Outline>().enabled = false;
            myManageGameObjectListForBronchoscopy.myObjList.Remove(transform.gameObject);
        }
    }

    // Modification
    public void TriggerHighlight()
    {
        Debug.Log("Click on Object!" + transform.name);
        isClicked = !isClicked;

        if (isClicked)
        {
            transform.GetComponent<Outline>().enabled = true;
            myManageGameObjectListForBronchoscopy.myObjList.Add(transform.gameObject);
        }
        else
        {
            transform.GetComponent<Outline>().enabled = false;
            myManageGameObjectListForBronchoscopy.myObjList.Remove(transform.gameObject);
        }
    }

}
