using UnityEngine;

public class OnClickAnimation : MonoBehaviour


{

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
