using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    //taking inputs from unity game engine
    [SerializeField]
    float maxX;

    [SerializeField]
    float spawnInterval;


    public GameObject[] Candies;

    public static CandySpawner instance;

    private void Awake()
    {
    	if(instance==null)
    	{
    		instance=this;
    	}
    }

    void Start()
    {
        //SpawnCandy();
        StartSpawningCandies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCandy()
    {
    	int rand = Random.Range(0,Candies.Length);

    	float randomX = Random.Range(-maxX,maxX);
    	Vector3 randomPos = new Vector3(randomX, transform.position.y, transform.position.z); //y and z same
    	Instantiate(Candies[rand], randomPos, transform.rotation);


    }

    IEnumerator SpawnCandies()
    {
    	yield return new WaitForSeconds(3f); //delay to hold

    	while(true)//repeatedly
    	{
    		SpawnCandy();
    		yield return new WaitForSeconds(spawnInterval);//gain wait

    	}

    }

    public void StartSpawningCandies()
    {
    	StartCoroutine("SpawnCandies");
    }

     public void StopSpawningCandies()
    {
    	StopCoroutine("SpawnCandies");
    }


}
