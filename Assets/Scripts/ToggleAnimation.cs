using UnityEngine;

public class ToggleAnimation : MonoBehaviour
{
    //Script from Kerri's videos on Canvas
    // TriggerPartical triggerParticalScript;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Toggle(GameObject gameobject)
    {
        gameObject.SetActive(!gameObject.activeSelf);
        // triggerParticalScript = GameObject.FindGameObjectWithTag("OralCavity").GetComponent<TriggerPartical>();
        // triggerParticalScript.OnMouseDown();
    }
}
