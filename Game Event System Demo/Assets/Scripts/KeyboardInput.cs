using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{

    public GameEvent eventMoveUp;
    public GameEvent eventMoveDown;
    public GameEvent eventMoveLeft;
    public GameEvent eventMoveRight;


    void Update()
    {

        // Movement
        if (Input.GetKey("w"))
        {
            eventMoveUp.Raise();
        }
        if (Input.GetKey("s"))
        {
            eventMoveDown.Raise();
        }
        if (Input.GetKey("a"))
        {
            eventMoveLeft.Raise();
        }
        if (Input.GetKey("d"))
        {
            eventMoveRight.Raise();
        }

    }
}
