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
        purchaseText.text = "�ݾ� : " + pur_money + "��";
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
            FailText.text = "���� ���� ���� : �ܾ׺���";
        }
    }

    public void showInfoTap() 
    {
        InfoTab.SetActive(true);
    }
}
