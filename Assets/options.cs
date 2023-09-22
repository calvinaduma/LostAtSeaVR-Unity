using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class options : MonoBehaviour
{
    private bool on = false;
    private bool all = false;
    private GameObject buttonAll;
    private GameObject buttonSome;

    // Start is called before the first frame update
    void Start()
    {
        buttonAll = GameObject.Find("AllButton");
        buttonSome = GameObject.Find("SomeButton");
        swapConstellations();
        buttonAll.SetActive(false);
        buttonSome.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void handleOptions()
    {
        if (!on)
        {
            buttonAll.SetActive(true);
            buttonSome.SetActive(true);
            on = true;
        }
        else
        {
            buttonAll.SetActive(false);
            buttonSome.SetActive(false);
            on = false;
        }
    }

    public void swapConstellations()
    {
        if (!all)
        {
            ColorBlock cba = buttonAll.GetComponent<UnityEngine.UI.Button>().colors;
            cba.normalColor = Color.green;
            buttonAll.GetComponent<UnityEngine.UI.Button>().colors = cba;
            ColorBlock cbs = buttonSome.GetComponent<UnityEngine.UI.Button>().colors;
            cbs.normalColor = Color.red;
            buttonSome.GetComponent<UnityEngine.UI.Button>().colors = cbs;
            all = true;
        }
        else
        {
            ColorBlock cba = buttonAll.GetComponent<UnityEngine.UI.Button>().colors;
            cba.normalColor = Color.red;
            buttonAll.GetComponent<UnityEngine.UI.Button>().colors = cba;
            ColorBlock cbs = buttonSome.GetComponent<UnityEngine.UI.Button>().colors;
            cbs.normalColor = Color.green;
            buttonSome.GetComponent<UnityEngine.UI.Button>().colors = cbs;
            all = false;
        }
    }
}
