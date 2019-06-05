using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class catty : MonoBehaviour
{
    // Start is called before the first frame update
 	public void move( bool isbad,float step){
		if(GameFunction.Instance.isplaying) 
		{
			float y;
			if(isbad){
				y = Random.Range((-1)*step/3,(-1)*step);
			}
			else {
				y = Random.Range(step/3,step);
			}
			float x = Random.Range(-0.01f,0.01f);
			gameObject.transform.position +=new Vector3(x,y,0);
			float time = 0;
			while(time>0.1f){
				time += Time.deltaTime; 
			}	
		}
		else{
			Destroy(gameObject);
		}
		
	}
	
}
