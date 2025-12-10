using UnityEngine;

public class ManageRotation : MonoBehaviour
{
    // Wei modified this script that is referenced from Matt's recording of simple inputs and interactions: 
    // https://canvas.gsa.ac.uk/courses/2804/pages/week-3-introduction-to-scripting?module_item_id=192434
    private float yRot = 0.0f;
    private Vector3 eulerRot;

    private Quaternion myInitialRotation;
    private Quaternion frontRotation;
    private Quaternion backRotation;
    private Quaternion leftRotation;
    private Quaternion rightRotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Assign the original obj orientation to the initial rotation variable
        myInitialRotation = transform.rotation;

        // Assign rotations for front, back, left, and right rotation.
        frontRotation = Quaternion.Euler(0f,0f,0f);
        backRotation = Quaternion.Euler(0f,180f,0f);
        leftRotation = Quaternion.Euler(0f,90f,0f);
        rightRotation = Quaternion.Euler(0f,270f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        // Manage Rotation around Y-Axis
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            yRot = -0.5f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            yRot = 0.5f;
        }
        else 
        {
            yRot = 0.0f;
        }

        eulerRot = new Vector3(0.0f, yRot, 0.0f);
        transform.Rotate(eulerRot, Space.Self);  
    }

    public void ResetRotation()
    {
        transform.rotation = myInitialRotation;
        Debug.Log("Rotation Reset!");
    }

    public void RotateToFront()
    {
        transform.rotation = frontRotation;
        Debug.Log("Rotated to Front!");
    }

    public void RotateToBack()
    {
        transform.rotation = backRotation;
        Debug.Log("Rotated to Back!");
    }
    
    public void RotateToLeft()
    {
        transform.rotation = leftRotation;
        Debug.Log("Rotated to Left!");
    }

    public void RotateToRight()
    {
        transform.rotation = rightRotation;
        Debug.Log("Rotated to Right!");
    }
}
