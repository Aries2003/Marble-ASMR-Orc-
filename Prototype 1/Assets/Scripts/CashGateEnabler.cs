using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CashGateEnabler : MonoBehaviour
{
    int GateNum = 1;
    public GameObject Lvl1Gate2;
    public GameObject Lvl1Gate3;
    public GameObject Lvl2Gate2;
    public GameObject Lvl2Gate3;
    public Button Income2;
    public TMP_Text CashCounter;
    public void GateEnabler()
    {
        GateNum += 1;
        if (AddRoute.LvlTeller % 2 == 0)
        {
            if (GateNum % 2 == 0)
            {
                // Gate = GameObject.FindGameObjectWithTag("CashGate2");
                Lvl1Gate2.gameObject.active = true;
                // Gate = GameObject.SetActive(true);
            }
            if (GateNum % 2 != 0)
            {
                // Gate = GameObject.FindGameObjectWithTag("CashGate3");
                Lvl1Gate3.gameObject.active = true;
            }
        }
        else
        {
            if (GateNum % 2 == 0)
            {
                // Gate = GameObject.FindGameObjectWithTag("CashGate2");
                Lvl2Gate2.gameObject.active = true;
                // Gate = GameObject.SetActive(true);
            }
            if (GateNum % 2 != 0)
            {
                // Gate = GameObject.FindGameObjectWithTag("CashGate3");
                Lvl2Gate3.gameObject.active = true;
            }
        }

        CashSystem.cash -=100;
        if (CashSystem.cash < 100)
        {
            Income2.interactable = false;
            CashCounter.text = CashSystem.cash.ToString();
        }
        if (CashSystem.cash >= 100)
        {
            CashCounter.text = CashSystem.cash.ToString();
        }
    }

}
