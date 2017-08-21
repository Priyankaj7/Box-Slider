using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnermove : MonoBehaviour {
    public Rigidbody sb;
    public float forforce = 2000f;

	void FixedUpdate () {

        
        

        sb.AddForce(0, 0, forforce * Time.deltaTime);

    }
}
