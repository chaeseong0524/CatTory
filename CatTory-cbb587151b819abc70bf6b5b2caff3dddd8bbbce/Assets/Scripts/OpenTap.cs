using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTap : MonoBehaviour
{
    public GameObject infoTap;
    public GameObject buyTap;
    public void infoOpen() 
    {
        infoTap.SetActive(true);
    }

    public void buyOpen()
    {
        buyTap.SetActive(true);
    }
}
