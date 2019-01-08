using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public static float targetRot = 0;
    public static float lastRot;

    public static void SetPos(Vector3 newPos)
    {
        GameObject.FindWithTag("Player").transform.position = newPos;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        lastRot = targetRot;
        targetRot = GameObject.FindWithTag("MainCamera").transform.eulerAngles.y ;
        UIController.SetRot(targetRot, lastRot);
    }
}
