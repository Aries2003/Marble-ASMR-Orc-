using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddBall : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Spawner1;
    public GameObject Spawner2;
    static public int BallCount = 1;
    public Button Ball_add1;
    public TMP_Text CashCounter;


    [SerializeField]
    int ballCount = 1;

    void Start()
    {
        Ball_add1.interactable = false;
    }

    public void Ball_1()
    {
        BallCount += 1;
        ballCount = BallCount;
        if ( AddRoute.LvlTeller % 2 == 0)//even for lvl 1
        {
            Instantiate(Ball, Spawner1.transform.position, Spawner1.transform.rotation);
        }
        if ( AddRoute.LvlTeller % 2 != 0)// odd for lvl 2
        {
            Instantiate(Ball, Spawner2.transform.position, Spawner2.transform.rotation);
        }
        
        CashSystem.cash -=10;
        if (CashSystem.cash < 10)
        {
            Ball_add1.interactable = false;
            CashCounter.text = CashSystem.cash.ToString();
        }
        if (CashSystem.cash >= 10 )
        {
            CashCounter.text = CashSystem.cash.ToString();
        }
    }    
}
