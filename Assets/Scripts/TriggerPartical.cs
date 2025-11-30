using UnityEngine;

public class TriggerPartical : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void OnMouseDown()
    {
        transform.GetComponent<ParticleSystem>().Play();
        transform.GetComponent<AudioSource>().Play();
    }
}
