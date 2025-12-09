using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
    public int maxQuestionIndex = 10;

    public int myQuestionIndex = 10; 

    public List<GameObject> questionList;

    public int score = 0;

    public GameObject finalPanel;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OnNextClick();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnNextClick()
    {
        if (myQuestionIndex < maxQuestionIndex)
        {
            //pick up randomly one question out of the list
            int index = Random.Range(0, questionList.Count-1);
            //set active the gameObject from the list at position index

            questionList[index].SetActive(true);
            //this makes the question that just showed up randomly to not come up again

            questionList.RemoveAt(index);
            //increase my question index

            myQuestionIndex += 1;


        }
        else
        {
            Debug.Log(myQuestionIndex);

            finalPanel.SetActive(true);

            finalPanel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Score is " + score;
        }

    }
}

