using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CashSystem : MonoBehaviour
{
    public Button Ball_add1;
    public Button MergeBall;
    public Button Income2;
    public Button AddRoute; 
    public TMP_Text CashCounter;


    public static int cash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int.TryParse(CashCounter.text, out cash);
        if (cash >= 10)
        {
            Ball_add1.interactable = true;
            // CashCounter.text = CashSystem.cash.ToString();   
        }
        if (cash >= 100)
        {
            Income2.interactable = true;
        }
        if ( cash >= 500)
        {
            MergeBall.interactable = true;
        }
        if (cash >= 1000)
        {
            AddRoute.interactable = true;
        }
    }
}
