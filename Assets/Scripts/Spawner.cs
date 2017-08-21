using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] enemies;
    public float Spawnwait;
    public float Spawnmostwait;
    public float Spawnleastwait;
    public Vector3 Spawnvalues;
    public int Startwait;
    public int randenemy;
	
	void Start () {
        StartCoroutine(waitspawner());		
	}
	
	
	void Update () {
        Spawnwait = Random.Range(Spawnleastwait, Spawnmostwait);
		
	}

    IEnumerator waitspawner()
    {
        yield return new WaitForSeconds(Startwait);

        while (true)
        {
            randenemy = Random.Range(0, 2);
            Vector3 spawnposition = new Vector3(Random.Range(-Spawnvalues.x, Spawnvalues.x), 7, Random.Range(-Spawnvalues.z, Spawnvalues.z));
            Instantiate(enemies[randenemy], spawnposition + GameObject.Find("Spawner").transform.position , gameObject.transform.rotation);
            yield return new WaitForSeconds(Spawnwait);
        }
    }
}
