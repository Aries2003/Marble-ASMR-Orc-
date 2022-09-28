using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class AddRoute : MonoBehaviour
{
    public Button Add_Route;
    public TMP_Text CashCounter; 
    public GameObject Route1;
    public GameObject Route2;
    
    public static int LvlTeller;

    // Start is called before the first frame update
    void Start()
    {
        LvlTeller = 2;
    }

    public void Update()
    {
        if (LvlTeller % 2 == 0)
        {
            Route1.active = true;
            Route2.active = false;
            print(LvlTeller);
        }
        if (LvlTeller % 2 != 0)
        {
            Route1.active = false;
            Route2.active = true;
            print(LvlTeller);
        }

    }

    public void _AddRoute()
    {        
        LvlTeller += 1;

        CashSystem.cash -=1000;
        if (CashSystem.cash < 1000)
        {
            Add_Route.interactable = false;
            CashCounter.text = CashSystem.cash.ToString();
        }
        if (CashSystem.cash >= 1000)
        {
            CashCounter.text = CashSystem.cash.ToString();
        }
    }


}
