using UnityEngine;
using UnityEngine.UI;

public class ShowHidePanel1 : MonoBehaviour
{
    public Button button;
    public GameObject panel1; // 첫 번째 패널
    public GameObject panel2; // 두 번째 패널

    private bool isPanel1Visible = true; // 첫 번째 패널 가시 상태

    private void Start()
    {
        button.onClick.AddListener(TogglePanels);
    }

    private void TogglePanels()
    {
        if (isPanel1Visible)
        {
            panel1.SetActive(false);
            panel2.SetActive(true);
            isPanel1Visible = false;
        }
        else
        {
            panel1.SetActive(true);
            panel2.SetActive(false);
            isPanel1Visible = true;
        }
    }
}
