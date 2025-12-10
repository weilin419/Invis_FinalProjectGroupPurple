using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour
{
    //This script is from the UI Demo OnClickBtnLoadScenebyNameScript Video on Canvas by Kerri Thornton
    //This script will allow the next scene to be loaded by name via input in the Unity inspector

    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

