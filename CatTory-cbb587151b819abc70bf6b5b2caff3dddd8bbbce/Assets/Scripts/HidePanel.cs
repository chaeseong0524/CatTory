using UnityEngine;
using UnityEngine.UI;

public class HidePanel : MonoBehaviour
{
    public Button button;
    public GameObject panel;

    private void Start()
    {
        button.onClick.AddListener(HideThePanel);
    }

    private void HideThePanel()
    {
        panel.SetActive(false);
    }
}
