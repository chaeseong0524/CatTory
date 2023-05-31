using UnityEngine;
using UnityEngine.UI;

public class ShowHidePanel : MonoBehaviour
{
    public Button button;
    public GameObject panel;

    private void Start()
    {
        button.onClick.AddListener(TogglePanel);
    }

    private void TogglePanel()
    {
        panel.SetActive(!panel.activeSelf);
    }
}
