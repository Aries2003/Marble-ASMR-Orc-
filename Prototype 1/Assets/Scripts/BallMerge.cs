using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallMerge : MonoBehaviour
{
    public GameObject[] Ball;
    int ballCount;
    public Button Merge_ball;
    public TMP_Text CashCounter;
    public static int BallMergeClicked = 0;
    
    

    public void BallMerger()
    {
        BallMergeClicked = 1;
        if(AddBall.BallCount % 2 == 0 )
        {
            ballCount = AddBall.BallCount;
            Ball = GameObject.FindGameObjectsWithTag("Ball");
            int j = 0;
           for(int i = 0; i < AddBall.BallCount/2; i++)
            {
                print(i);
                Destroy(Ball[j]);
                j++;
                
            }
            AddBall.BallCount = ballCount / 2;
            ballCount =  ballCount / 2;
        }
        else 
        {
            
            AddBall.BallCount -= 1;
            ballCount = AddBall.BallCount;
            Ball = GameObject.FindGameObjectsWithTag("Ball");
            int j = 0;
            for(int i = 0; i < AddBall.BallCount/2; i++)
            {
                print(i);
                Destroy(Ball[j]);
                j++;
                
            }

            AddBall.BallCount = ballCount / 2;
            AddBall.BallCount += 1;
            ballCount =  ballCount / 2;
        }
        
        CashSystem.cash -= 500;
        if (CashSystem.cash < 500)
        {
            Merge_ball.interactable = false;
            CashCounter.text = CashSystem.cash.ToString();
        }
        if (CashSystem.cash >= 500)
        {
            CashCounter.text = CashSystem.cash.ToString();
        }
        CashIncre.MergeIncrement += 2;
        // print(CashIncre.MergeIncrement);
    }
}
