using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CashIncre : MonoBehaviour
{
    public TextMeshProUGUI Cash;
    public static int MergeIncrement = 0;

    void OnTriggerEnter(Collider col1)
    {
        if (BallMerge.BallMergeClicked == 0)
        {
            CashSystem.cash = CashSystem.cash + 1;
        }
        else
        {
            CashSystem.cash = CashSystem.cash + MergeIncrement;
        }
        // print(CashCheck.c);
        Cash.text = CashSystem.cash.ToString();
    }

    
}
