using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Threads : MonoBehaviour {
    Thread thread;
    private bool reached;
    Transform t;
    Vector3 latestPosition;
    public bool stop;
    public float random;
    private RandomNumber randomIndex;
    public float dist;
    public Transform goal;
    private Ranking playerWinning;
    public Material white, gold;
    public GameObject cubeSon;

	// Use this for initialization
	void Start ()
    {
        if (gameObject.tag != "Players_G2")
        {
            t = transform;
            latestPosition = t.localPosition;
            thread = new Thread(Run);
            thread.Start();
            randomIndex = GameObject.Find("Random").GetComponent<RandomNumber>();
            playerWinning = GameObject.Find("Ranking").GetComponent<Ranking>();
        }
    }

    public void StartGroup2()
    {
        if (gameObject.tag == "Players_G2")
        {
            t = transform;
            latestPosition = t.localPosition;
            thread = new Thread(Run2);
            thread.Start();
            randomIndex = GameObject.Find("Random").GetComponent<RandomNumber>();
            playerWinning = GameObject.Find("Ranking").GetComponent<Ranking>();
        }
    }

    private void OnDestroy()
    {
        if (thread != null)
        {
            stop = true;
            thread.Abort();
        }
    }

    private void OnApplicationQuit()
    {
        if (thread != null)
        {
            stop = true;
            thread.Abort();
        }
    }

    void Run()
    {
        while (stop==false)
        {
            Debug.Log("Jimmy");
            random = randomIndex.index;
        }
    }

    void Run2()
    {
        while (stop == false)
        {
            Debug.Log("Jimmy");
            random = randomIndex.index;

        }
    }

    private void Update()
    {
            if (stop == false)
            {
                t.position += Vector3.left * random;
                transform.position = t.position;
                dist = Vector3.Distance(goal.position, transform.position);

                if (gameObject.name == "Player1" && playerWinning.playerWinning == 1)
                {
                    cubeSon.GetComponent<Renderer>().material = gold;
                }
                else if (gameObject.name == "Player2" && playerWinning.playerWinning == 2)
                {
                    cubeSon.GetComponent<Renderer>().material = gold;
                }
                else if (gameObject.name == "Player3" && playerWinning.playerWinning == 3)
                {
                    cubeSon.GetComponent<Renderer>().material = gold;
                }
                else if (gameObject.name == "Player4" && playerWinning.playerWinning == 4)
                {
                    cubeSon.GetComponent<Renderer>().material = gold;
                }
                else if (gameObject.name == "Player1_2" && playerWinning.playerWinning == 5)
                {
                    cubeSon.GetComponent<Renderer>().material = gold;
                }
                else if (gameObject.name == "Player2_2" && playerWinning.playerWinning == 6)
                {
                    cubeSon.GetComponent<Renderer>().material = gold;
                }
                else if (gameObject.name == "Player3_2" && playerWinning.playerWinning == 7)
                {
                    cubeSon.GetComponent<Renderer>().material = gold;
                }
                else if (gameObject.name == "Player4_2" && playerWinning.playerWinning == 8)
                {
                    cubeSon.GetComponent<Renderer>().material = gold;
                }
                else cubeSon.GetComponent<Renderer>().material = white;
            }
            else return;
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Block1")
        {
            Debug.Log("Hola");
            stop = true;
        }
    }
}
