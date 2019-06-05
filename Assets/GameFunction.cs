using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameFunction : MonoBehaviour
{
    
public GameObject emeny; 
public GameObject my_cat; 
public GameObject GameTitle;
public GameObject GameOver;
public float time; 
public static int money = 100; 
public int cost = 1;
public bool isplaying = false;
public static GameFunction Instance; 
 
 
	// Start is called before the first frame update
    void Start()
    {
		Instance = this;
		GameOver.SetActive (false);
		GameTitle.SetActive (true);
 
    }

    // Update is called once per frame
    void Update()
    {
        
		if(isplaying){
			/*creat a emeny every 0.5 second*/
			time += Time.deltaTime; 
			if(time>0.5f) //if 0.5sec pathpos
			{
				Vector3 pos_emeny = new Vector3(Random.Range(-3f,-1.5f),3.6f,0); //random set a position
				Instantiate(emeny,pos_emeny,transform.rotation);//creat emeny
				time = 0f; //reset time
			}
			if (Input.GetKeyDown(KeyCode.Space))	
			{
				if(SpendMoney()){
					Vector3 pos_emeny = new Vector3(Random.Range(-3f,-1.5f),-3.68f,0); //random set a position
					Instantiate(my_cat,pos_emeny,transform.rotation);//creat new cat
				} 

			}
		}
		else{
			if(Input.GetKeyDown(KeyCode.G)) game_start(); //check the space key is pressed ot not
		}
		
	}
	public bool SpendMoney()

	{
		if(money < cost){
			return false;
		}
		money -= cost;
		GameObject.Find("Canvas/your_money").GetComponent<Text>().text = "money: " + money;
		return true;
		//your_money.text = str(); //show the rest of money

	}
	public void  game_start(){
		GameTitle.SetActive (false);
		isplaying= true;
	}
	public void end_game(){
			GameOver.SetActive (true);
			isplaying =false;
			Application.Quit();

	}

}


