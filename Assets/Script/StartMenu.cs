using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
	Canvas canvasObject;
    // Start is called before the first frame update
    void Start()
    {
       canvasObject = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void closeMenu(){
		canvasObject.gameObject.SetActive(false);
	}

}
