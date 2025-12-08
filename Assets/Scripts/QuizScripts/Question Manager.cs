using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;

public class QuestionM : MonoBehaviour
{
    public GameObject correctResponse;
    public GameObject userResponse;
    public ToggleGroup myToggleGroup;
    public GameObject positiveFeedback;
    public GameObject negativeFeedback;
    public QuizManager myQuizManagerScript;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myQuizManagerScript = GameObject.Find("Canvas").GetComponent<QuizManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnConfirmClick()
    {
        // compare the user response with the correct response stored in the system.
        if(myToggleGroup.AnyTogglesOn())
        {
            Toggle selectedToggle = myToggleGroup.ActiveToggles().FirstOrDefault();
            Debug.Log(selectedToggle.name);
            
            userResponse = selectedToggle.gameObject;

            //set all toggle as non interactible
            for (int i = 0; i < myToggleGroup.gameObject.transform.childCount; i++)
            {
                myToggleGroup.gameObject.transform.GetChild(i).GetComponent<Toggle>().interactable = false;
            }
        
            if(userResponse == correctResponse)
            {
                //Show positive feedback
                positiveFeedback.SetActive(true);

                myQuizManagerScript.score += 1;
            }
            else 
            {
               //Show negative feedback
               negativeFeedback.SetActive(true); 
            }
        }
        else
        {
            //no toggles selected --> show negative feedback
            negativeFeedback.SetActive(true);

        }
    }
}
