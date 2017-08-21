
using UnityEngine;

public class Playercollision : MonoBehaviour {
    public Playermovement move;


	void OnCollisionEnter (Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
