using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
	    
	void OnTriggerEnter2D(Collider2D col)
	{
		if( (col.tag == "my_cat" )){
			GameFunction.Instance.end_game(); 
			
		}
	}



}
