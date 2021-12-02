using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //close the game
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
