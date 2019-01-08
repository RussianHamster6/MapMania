using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour {

    bool isViewed = false;

    public static Vector3 cubePos;
    public GameObject nameObj; 

    private void Start()
    {
    }

    public void IsSeen()
    {
        cubePos = transform.position;

        CameraController.SetPos(cubePos);

        if(UIController.target == nameObj.name)
        {
            UIController.IncreaseScore();
            UIController.ChangeLocation();
        }
        else
        {
            UIController.DecreaseScore();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
