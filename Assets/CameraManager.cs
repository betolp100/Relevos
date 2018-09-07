using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {
    private Ranking rank;
    private Transform target;
    private Transform p1, p2, p3, p4, p1_2, p2_2, p3_2, p4_2;
    public float smoothTime = 0.125F;
    private Vector3 velocity = Vector3.zero;

    // Use this for initialization
    void Start () {
        rank = GameObject.Find("Ranking").GetComponent<Ranking>();
        p1 = GameObject.Find("Player1").GetComponent<Transform>();
        p2 = GameObject.Find("Player2").GetComponent<Transform>();
        p3 = GameObject.Find("Player3").GetComponent<Transform>();
        p4 = GameObject.Find("Player4").GetComponent<Transform>();

        p1_2 = GameObject.Find("Player1_2").GetComponent<Transform>();
        p2_2 = GameObject.Find("Player2_2").GetComponent<Transform>();
        p3_2 = GameObject.Find("Player3_2").GetComponent<Transform>();
        p4_2 = GameObject.Find("Player4_2").GetComponent<Transform>();
    }

    void Update()
    {
        switch (rank.playerWinning)
        {
            case 1:
                target = p1;
                break;
            case 2:
                target = p2;
                break;
            case 3:
                target = p3;
                break;
            case 4:
                target = p4;
                break;
            case 5:
                target = p1_2;
                break;
            case 6:
                target = p2_2;
                break;
            case 7:
                target = p3_2;
                break;
            case 8:
                target = p4_2;
                break;
        }
        if (target != null)
        {
            // Smoothly move the camera towards that target position
            Vector3 targetOffset = new Vector3(target.position.x - 50, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetOffset, smoothTime);
        }
        else return;
    }
}
