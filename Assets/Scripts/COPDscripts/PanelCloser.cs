using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PanelCloser : MonoBehaviour
{

    public List<GameObject> myObjList;


    public void OnActivatePanel(GameObject obj)
    {
        for (int i = 0; i < myObjList.Count; i++)
        {
            myObjList[i].SetActive(true);
        }

        obj.SetActive(false);
    }
}
//I used the same script as for panel opener but inverted the script because I knew PanelOpener script would cancel itself out unless true/false were reversed (wrote this myself hehe)