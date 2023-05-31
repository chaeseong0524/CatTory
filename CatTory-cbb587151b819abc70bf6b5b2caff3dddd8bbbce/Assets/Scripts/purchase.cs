using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class purchase : MonoBehaviour
{
    int pur_money = 10000;
    int h_money = GameManager.instance.tot_Money;
    public Text purchaseText;
    public GameObject FailTab;
    public GameObject SuccessTab;
    public GameObject InfoTab;
    public Text FailText;

    // Start is called before the first frame update
    void Start()
    {
        purchaseText.text = "금액 : " + pur_money + "원";
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void discrimination()
    {
        if (h_money >= pur_money)
        {
            SuccessTab.SetActive(true);
            h_money -= pur_money;
        }
        else
        {
            FailTab.SetActive(true);
            FailText.text = "구매 실패 사유 : 잔액부족";
        }
    }

    public void showInfoTap() 
    {
        InfoTab.SetActive(true);
    }
}
