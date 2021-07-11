using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void  OnTriggerEnter2D( Collider2D collider)
    {
    	if(collider.gameObject.tag=="Player") //tagged in unity

    	 {
    	 	//incrementing
    	 	GameManager.instance.IncrementScore(); //inc if hit player
    	 	Destroy(gameObject);
    	 }
    	 else if(collider.gameObject.tag=="Boundary") //if down boundary
    	 {  
    	 	GameManager.instance.DecrementLife();  //calling when hits boundary
    	 	Destroy(gameObject);
    	 }
    }

}
