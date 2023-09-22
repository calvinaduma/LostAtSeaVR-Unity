using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public int raw;
    private GameObject meter;
    private GameObject meterB;
   // private GameObject death;
    private bool going = false;
    // Start is called before the first frame update
    void Start()
    {
        raw = 10000;
        meterB = GameObject.Find("bCanv");
        meter = GameObject.Find("Meter");
        //death = GameObject.Find("Death");
        //death.SetActive(false);
        meterB.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (going)
        {
            if (raw > 0)
            {
                raw--;
                int food = raw / 100;
                meter.GetComponent<UnityEngine.UI.Text>().text = "Food " + food.ToString() + "/100";
            }
            else
            {
               // death.SetActive(true);
                this.enabled = false;
            }
        }
      
       
        //if (food <= 0)
        //    death();
    }

    public void startTimer()
    {
        meterB.SetActive(true);
        going = true;
    }

    //private void death()
    //{

    //}
}
