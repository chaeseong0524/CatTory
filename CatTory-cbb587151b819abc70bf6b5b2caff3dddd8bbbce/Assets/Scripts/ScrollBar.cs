using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBar : MonoBehaviour
{
    Scrollbar scrollbar;
    // Start is called before the first frame update
    void Start()
    {
        scrollbar = GetComponent<Scrollbar>();
        scrollbar.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
