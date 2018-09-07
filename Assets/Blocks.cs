using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour {
    public bool playerReach = false;
    private void OnTriggerEnter(Collider other)
    {
        playerReach = true;
        if ( other.gameObject.name == "Player1" )
        {
            GameObject.Find("Player1_2").GetComponent<Threads>().stop = false;
            GameObject.Find("Player1_2").GetComponent<Threads>().StartGroup2();
        }

        if (other.gameObject.name == "Player2")
        {
            GameObject.Find("Player2_2").GetComponent<Threads>().stop = false;
            GameObject.Find("Player2_2").GetComponent<Threads>().StartGroup2();
        }

        if (other.gameObject.name == "Player3")
        {
            GameObject.Find("Player3_2").GetComponent<Threads>().stop = false;
            GameObject.Find("Player3_2").GetComponent<Threads>().StartGroup2();
        }

        if (other.gameObject.name == "Player1")
        {
            GameObject.Find("Player4_2").GetComponent<Threads>().stop = false;
            GameObject.Find("Player4_2").GetComponent<Threads>().StartGroup2();
        }
    }
}
