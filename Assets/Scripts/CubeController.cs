using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    bool isViewed = false;

    public static Vector3 cubePos;

    private void Start()
    {
        isViewed = false;
    }

    public void IsSeen()
    {
        cubePos = transform.position;

        CameraController.SetPos(cubePos);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
