using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class my_catty : catty
{
   bool isbad =false;
   float step =0.03f;
   
   void start(){
		float y = Random.Range(-0.01f,-0.03f);
		gameObject.transform.position +=new Vector3(0,y,0);
	}
	void Update()
    {
		move(isbad,step); //move one step per 0.1 second

    }
	
	
	
	
	
}
