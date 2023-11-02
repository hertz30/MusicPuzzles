using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastClicked : MonoBehaviour
{
    GameObject lastClicked;
    Ray ray;
    RaycastHit rayHit;
 
    void Update()
    {
		if(Input.GetMouseButtonDown (0))
		{
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	        if(Physics.Raycast(ray, out rayHit))
	        {
	            lastClicked = rayHit.collider.gameObject;
	            if(lastClicked != null)
	                print(lastClicked.name);
	        }
    	}
	}
	public GameObject getLastClicked(){
		return lastClicked;
	}
}
