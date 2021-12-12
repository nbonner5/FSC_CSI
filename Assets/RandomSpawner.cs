using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
	
	public string spawnPointTag = "Blood";
	public bool alwaysSpawn = true;
	
	public List<GameObject> prefabsToSpawn;
	
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] spawnPoints = GameObject.FindGameObjectsWithTag(spawnPointTag);
		foreach(GameObject spawnPoint in spawnPoints){
			int randomPrefab = Random.Range(0, prefabsToSpawn.Count);
			if(alwaysSpawn){
				GameObject pts = Instantiate(prefabsToSpawn[randomPrefab]);
				pts.transform.position = spawnPoint.transform.position;
			}else{
				int spawnOrNot = Random.Range(0, 5);
				if(spawnOrNot == 0) {
					GameObject pts = Instantiate(prefabsToSpawn[randomPrefab]);
					pts.transform.position = spawnPoint.transform.position;
					pts.transform.localScale = new Vector3(Random.Range(10.0f, 25.0f), Random.Range(10.0f, 25.0f), 1);
				}
			}
		}
    }

}