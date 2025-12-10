using UnityEngine;

public class ToggleBronchoscopyPanel : MonoBehaviour
{
    // Find reference from https://stackoverflow.com/questions/44692366/activeself-return-true-and-gameobject-is-false
    public GameObject bronchoscopyPanel;
    public void Toggle()
    {
        bronchoscopyPanel.SetActive(!bronchoscopyPanel.activeSelf);
    } 
}
