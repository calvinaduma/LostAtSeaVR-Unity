using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasStart : MonoBehaviour
{
	Canvas canvasObject;
    // Start is called before the first frame update
    void Start()
    {	
			canvasObject = GetComponent<Canvas>();
        	canvasObject.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void closeMenu(){
		canvasObject.gameObject.SetActive(false);
	}
}
