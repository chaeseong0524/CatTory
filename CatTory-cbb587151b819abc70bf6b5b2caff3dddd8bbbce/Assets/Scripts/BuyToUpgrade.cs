using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyToUpgrade : MonoBehaviour
{
    public GameObject target1;
    public GameObject target2;

    public void clicked() 
    {
        target1.SetActiveRecursively(true);
        target2.SetActiveRecursively(false);
    }
}
