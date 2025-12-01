using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitApplication : MonoBehaviour
{
    //This script was taken from and reused from Tiffany Lui's diorama formative assessment
    //This script for quitting the diorama application
    // This script is from the UI Demo OnClickBtnQuitScript video on Canvas from Kerri Thornton
    
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Application Quit");
    }
}