using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PanelOpener : MonoBehaviour
{

    public List<GameObject> myObjList;


    public void OnActivatePanel(GameObject obj)
    { 
        for (int i = 0; i < myObjList.Count; i++)
        {
            myObjList[i].SetActive(false);
        }

        obj.SetActive(true);
    }

}


    /*public GameObject Panel;
    public void OpenPanel()

    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    } //I wrote this script myself, and I will link the tutorial that i used for this

    }
    public class mouseUp2 : MonoBehaviour
    {



        public GameObject Panel2Disappear;
        public GameObject Panel2Appear;



        void OnMouseUp()
        {
            Debug.Log("MouseHit");
            Panel2Disappear.SetActive(false);
            Panel2Appear.SetActive(true);
        }
  

    }// i will link the reference for this script, but I wanted to show a different approach to switching between panels by just clicking on any of the buttons present,through code rather than UI
    */