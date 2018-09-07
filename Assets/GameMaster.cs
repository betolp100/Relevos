using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

    private bool isWatchingCam1 = true;
    private Camera cam1, cam2;

    private void Start()
    {
        cam1 = GameObject.Find("Main Camera").GetComponent<Camera>();
        cam2 = GameObject.Find("Camera").GetComponent<Camera>();
        cam1.enabled = true;
        cam2.enabled = false;
    }
    public void ResetScene()
    {
        SceneManager.LoadScene(0);
    }

    public void ChangeCameraDisplay()
    {
        if (isWatchingCam1 == true)
        {
            cam2.enabled = true;
            cam1.enabled = false;
        }
        else
        {
            cam2.enabled = false;
            cam1.enabled = true;
        }
        isWatchingCam1 = !isWatchingCam1;
    }
}
