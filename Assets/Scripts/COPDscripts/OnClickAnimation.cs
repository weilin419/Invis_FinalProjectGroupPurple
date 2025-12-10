using UnityEngine;

public class OnClickAnimation : MonoBehaviour


{

//This script is from Kerri's 06 Animation - How to use Scripting to Trigger and Animation using the Animator Part 1 Video on Canvas
    Animator animator;
    public GameObject showAnimationButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = showAnimationButton.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
