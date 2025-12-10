using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitApplication : MonoBehaviour
{

    // This script is from the UI Demo OnClickBtnQuitScript video on Canvas from Kerri Thornton
    
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Application Quit");
    }
}