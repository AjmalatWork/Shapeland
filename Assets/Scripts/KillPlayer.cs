using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

    public PlayerController player;
    public GameObject currentCheckpoint;

    // Use this for initialization
    void Start () {
        player = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RespawnPlayer()
    {
        player.transform.position = currentCheckpoint.transform.position;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            RespawnPlayer();
        }
            
                    
    }
}
