using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleText : MonoBehaviour
{
    public GameObject obj;
    static bool isActive = true; //use to save state between reloads

    void Start() {
        //keep the state the same between reloads
        obj.SetActive(isActive);
    }

    // Update is called once per frame
    void Update()
    {
        //toggle text displaying
		if(Input.GetKeyDown(KeyCode.T)) {
            //when the user presses T, flip if the UI is active or not
            isActive = !obj.activeInHierarchy;
			obj.SetActive(isActive);
		}
    }
}
