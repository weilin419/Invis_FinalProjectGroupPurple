using UnityEngine;

public class ToggleHighLight : MonoBehaviour
{
    public bool isClicked = false;
    
    public GameObject myManagerObj;
    //Access the list we just created in the Script of ManageGameObjectList in the script of ToggleHighLightOnObj.
    //Declares a variable to store a reference to another script
    private ManageGameObjectList myManagerObjectListScript; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.GetComponent<Outline>().enabled = false;
        //Find the object named "Manager" in the Unity Project and Associate object with it.
        myManagerObj = GameObject.Find("Manager");
        //Access the script from the game object.
        // Finds the GameObject and gets the actual reference to the script component
        myManagerObjectListScript = myManagerObj.transform.GetComponent<ManageGameObjectList>(); 
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
            //Once the objct is highlighted, we will add the object to the list
            // Uses that reference to access the public list in another script and add the object
            myManagerObjectListScript.myObjList.Add(transform.gameObject);
        }
        else
        {
            transform.GetComponent<Outline>().enabled = false;
            myManagerObjectListScript.myObjList.Remove(transform.gameObject);
        }
    }
}
