using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//code found online at learn.unity.com
public class LineRendererSettings : MonoBehaviour
{
	[SerializeField] LineRenderer rend;
	Vector3[] points;
	
	public Button btn;
	public Canvas startCanvas;
	public LayerMask layerMask;
    // Start is called before the first frame update
    void Start()
    {
		rend = gameObject.GetComponent<LineRenderer>();
		points = new Vector3[2];	 
		points[0] = Vector3.zero;
		points[1] = transform.position + new Vector3(0, 0, 20);
		
		rend.SetPositions(points);
		rend.enabled = true;
    }
	public bool AlignLineRenderer(LineRenderer rend){
		bool hitBtn = false;
		Ray ray;
		ray = new Ray(transform.position, transform.forward);
		RaycastHit hit;
		
		if(Physics.Raycast(ray, out hit, layerMask)){
			hitBtn = true;
			points[1] = transform.forward + new Vector3(0, 0, hit.distance);
			rend.startColor = Color.red;
			rend.endColor = Color.red;
			btn = hit.collider.gameObject.GetComponent<Button>();
		}else{
			hitBtn = false;
			points[1] = transform.forward + new Vector3(0, 0, 20);
			rend.startColor = Color.green;
			rend.endColor = Color.green;
		}
		
		rend.SetPositions(points);
		rend.material.color = rend.startColor;
		

		return hitBtn;
	}

    // Update is called once per frame
    void Update()
    {
		if(AlignLineRenderer(rend) && Input.GetAxis("Submit") > 0){
			btn.onClick.Invoke();
		}
        
    }
	
	public void CloseOnClick(){
		if(btn != null){
			if(btn.name == "StartButton"){
				Debug.Log("Clicked");
			}
			if(btn.name == "MainMenuButton"){
				Debug.Log("clicked");
			}
		}
	}

}
