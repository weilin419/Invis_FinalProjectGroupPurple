using UnityEngine;

public class ToggleBronchoscopyPanel : MonoBehaviour
{
    public GameObject bronchoscopyPanel;
    public void Toggle()
    {
        Debug.Log("Toggle按钮被点击,当前Panel状态:" + bronchoscopyPanel.activeSelf);
        bronchoscopyPanel.SetActive(!bronchoscopyPanel.activeSelf);
    } 
}
