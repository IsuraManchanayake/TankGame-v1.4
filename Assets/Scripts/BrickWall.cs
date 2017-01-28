﻿using UnityEngine;
using System.Collections;


public class BrickWall : MonoBehaviour {

    string type = "brick";
    int num_brick = 10;

    public GameObject wall;



    // Use this for initialization
    void Start () {

        for (int i = 0; i < num_brick; i++)
        {
            float fx = Random.Range(-5,5);
            float fy = Random.Range(-5, 5);

            int x = (int)fx;
            int y = (int)fy;

            Vector2 pos = new Vector2(x+0.5f,y+0.5f);
            Instantiate(wall, pos, transform.rotation);
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
