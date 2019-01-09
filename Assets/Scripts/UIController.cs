using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour {
    
    //Variable Definitions
    public static int Score = 0;
    public static UnityEngine.Object scoreText;
    public static int randI;

    Text[] returned;
    static Text score;
    bool flag = false;
    static bool flag2 = false;
    int i = 0;
    public static Text location;
    public static string target; 

    public static System.Random rnd = new System.Random();

    public static string[] locations = { "Car Park", "Church", "Campsite", "Building of Historic Interest", "Information Centre", "Nature Reserve" };

	// Use this for initialization
	void Start () {
		returned = GetComponentsInChildren<Text>();
        Score = 0;  

        while (!flag && i <= returned.Length)
        {
            if(returned[i].name == "ScoreText")
            {
                score = returned[i];
                flag = true;
            }
        }

        i = 0;
        flag = false;

        while (!flag && i <= returned.Length)
        {
            if (returned[i].name == "LocationText")
            {
                location = returned[i];
                flag = true;
            }
            i++;
        }

        score.text = "Score: 0";

        ChangeLocation();
    }
	
	// Update is called once per frame
	void Update () {
		if (flag2 == true)
        {
            score.text = "Score: " + Score;
            flag2 = false;
        }
    }

    public static void SetRot(float newRot, float oldRot)
    {
        Quaternion lastRot = Quaternion.Euler(0, 0, oldRot);
        Quaternion target = Quaternion.Euler(0, 0, newRot);
        GameObject.FindWithTag("Compass").transform.rotation = Quaternion.Slerp(lastRot, target, 0);
    }

    //Increses Score
    public static void IncreaseScore()
    {
        Score = Score + 1;
        flag2 = true; 
    }

    //Decrese Score
    public static void DecreaseScore()
    {
        Score = Score - 1;
        flag2 = true;
    }

    //Change Target Location
    public static void ChangeLocation()
    {
        randI = rnd.Next(0, 5);
        target = locations[randI];
        location.text = "Go to: " + target;
    }
}
