using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseTap : MonoBehaviour
{
    public void closeTap() 
    {
        this.gameObject.SetActive(false);
    }
}
