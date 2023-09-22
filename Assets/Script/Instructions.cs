using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{

	public GameObject canvasObject;
    // Start is called before the first frame update
    void Start()
    {
       canvasObject = GameObject.Find("Canvas");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnMouseDown(){
		canvasObject.gameObject.SetActive(false);
	}
		
}
