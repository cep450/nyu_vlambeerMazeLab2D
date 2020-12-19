using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    //just re-using code from the flatgame

    static float SPEED = 0.05f;
    static float SPEED_DIAG = SPEED * Mathf.Sin(Mathf.PI / 4) + 0.002f;

    bool up, down, left, right = false;
    float effectivespeed;

    // Update is called once per frame
    void Update()
    {

        up = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        down = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);
        left = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        right = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);

        //same speed when diagonal
        if((up || down ) && (left || right)) {
            effectivespeed = SPEED_DIAG;
        } else {
            effectivespeed = SPEED;
        }

        if(up) {
            transform.Translate(0f, effectivespeed, 0f);
        }
        if(down) {
            transform.Translate(0f, -effectivespeed, 0f);
        }
        if(left) {
            transform.Translate(-effectivespeed, 0f, 0f);
        }
        if(right) {
            transform.Translate(effectivespeed, 0f, 0f);
        }

    }
}
