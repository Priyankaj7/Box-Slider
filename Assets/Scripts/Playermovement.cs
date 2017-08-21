
using UnityEngine;

public class Playermovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sideforce = 500f;
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        //code wrttien by sir for clamp
        var pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -6, 6);
        transform.position = pos;
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x > Screen.width/2)
            {
                rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            else
                rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


       /* if (rb.position.y < 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }*/

        

    }
}
