using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipbutton : MonoBehaviour
{
    GameObject ship, button, wheel, backSail;
    bool pressed = false, move = false;
    // Start is called before the first frame update
    void Start()
    {
        ship = GameObject.Find("Boat_1800early_BrigSloop_LOD_0");
        backSail = GameObject.Find("mastPivot (4)");
        button = GameObject.Find("Button");
        wheel = GameObject.Find("Wheel");
    }

    // Update is called once per frame
    void Update()
    {
        if (button.transform.localPosition.x < -1.507)
        {
            button.transform.localPosition = new Vector3(-1.507f, button.transform.localPosition.y, button.transform.localPosition.z);
            if (!pressed)
                move = !move;
            pressed = true;
        }
        else if (button.transform.localPosition.x >= -1.507 && button.transform.localPosition.x < -1.364)
        {
            button.transform.localPosition = button.transform.localPosition + new Vector3(.01f, 0, 0);
            if (button.transform.localPosition.y > -1.4)
                pressed = false;
        }

        if (wheel.transform.eulerAngles.z > 180)
            wheel.transform.eulerAngles = new Vector3(wheel.transform.eulerAngles.x, wheel.transform.eulerAngles.y, 180f);
        if (wheel.transform.eulerAngles.z < -180)
            wheel.transform.eulerAngles = new Vector3(wheel.transform.eulerAngles.x, wheel.transform.eulerAngles.y, -180f);
        backSail.transform.eulerAngles = new Vector3(0, 180f + wheel.transform.eulerAngles.z, 0);
        
        if (move)
        {
            ship.transform.position = ship.transform.position + new Vector3(Mathf.Sin(ship.transform.eulerAngles.y)/10f, 0, Mathf.Cos(ship.transform.eulerAngles.y) / 10f);
        }
    }
}
