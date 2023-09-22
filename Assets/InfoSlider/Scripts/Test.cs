using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Madhur.InfoPopup;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
	[SerializeField]
    string Text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void popup(){
		InfoPopupUtil.ShowInformation ( "Great!Find Orion!" );
	}

}
