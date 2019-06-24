using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class bad_catty_creat : catty
{
	bool isbad =true;
	float step = 0.03f;
    void start(){
		float y = Random.Range(-0.01f,-0.03f);
		gameObject.transform.position +=new Vector3(0,y,0);
	}

    void Update()
    { 
		move(isbad,step);
    }
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag == "my_cat"){
			Destroy(col.gameObject); //kill the one who hit it
			Destroy(gameObject); //kill itself
		}
		else if(col.tag == "wall"){ 
			Destroy(gameObject); //kill itself
		}
	
	}
	

}

