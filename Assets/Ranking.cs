using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    private Blocks block1;
    private Threads player1, player1_2, player2, player2_2, player3, player3_2, player4, player4_2;
    // Use this for initialization
    public int playerWinning;

    private void Start()
    {
        player1 = GameObject.Find("Player1").GetComponent<Threads>();
        player2 = GameObject.Find("Player2").GetComponent<Threads>();
        player3 = GameObject.Find("Player3").GetComponent<Threads>();
        player4 = GameObject.Find("Player4").GetComponent<Threads>();

        player1_2 = GameObject.Find("Player1_2").GetComponent<Threads>();
        player2_2 = GameObject.Find("Player2_2").GetComponent<Threads>();
        player3_2 = GameObject.Find("Player3_2").GetComponent<Threads>();
        player4_2 = GameObject.Find("Player4_2").GetComponent<Threads>();

        block1 = GameObject.Find("Block1").GetComponent<Blocks>();
    }
    // Update is called once per frame
    void Update()
    {
        if (block1.playerReach == false)
        {
            if (player1.dist < player2.dist && player1.dist < player3.dist && player1.dist < player4.dist)
            {
                playerWinning = 1;
                return;
            }
            else if (player2.dist < player1.dist && player2.dist < player3.dist && player2.dist < player4.dist)
            {
                playerWinning = 2;
                return;
            }
            else
            if (player3.dist < (player1.dist) && player3.dist < player2.dist && player3.dist < player4.dist)
            {
                playerWinning = 3;
                return;
            }
            else
            if (player4.dist < player1.dist && player4.dist < player2.dist && player4.dist < player3.dist)
            {
                playerWinning = 4;
                return;
            }
        }
        else
        {
            if (player1_2.dist < player2_2.dist && player1_2.dist < player3_2.dist && player1_2.dist < player4_2.dist)
            {
                playerWinning = 5;
                return;
            }
            else if (player2_2.dist < player1_2.dist && player2_2.dist < player3_2.dist && player2_2.dist < player4_2.dist)
            {
                playerWinning = 6;
                return;
            }
            else
            if (player3_2.dist < player1_2.dist && player3_2.dist < player2_2.dist && player3_2.dist < player4_2.dist)
            {
                playerWinning = 7;
                return;
            }
            else
            if (player4_2.dist < player1_2.dist && player4_2.dist < player2_2.dist && player4_2.dist < player3_2.dist)
            {
                playerWinning = 8;
                return;
            }
        }
        
    }
}
