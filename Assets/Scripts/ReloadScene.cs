﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //restart button
		if(Input.GetKeyDown(KeyCode.R)) {
			//reset global tile count between reloads, since it's a static variable
			FloorMaker.globalTileCount = 0;
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
    }
}
