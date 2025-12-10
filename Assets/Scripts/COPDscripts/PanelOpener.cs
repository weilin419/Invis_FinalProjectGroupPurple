using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//this whole script was written by myself (Andreea) with the help of Matthiew Poyade
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
  

    }// I wanted to still keep this old script for my own interest in order to compare it which what Matt helped me write and understand the differences
    */