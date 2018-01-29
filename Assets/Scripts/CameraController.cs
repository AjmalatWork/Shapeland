using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private GameObject player;
    private Vector2 v;
    public float smoothTime;
    public float begin;
    public float end;


	// Use this for initialization
	void Start () {
        
        player = GameObject.FindGameObjectWithTag("Player");
        
    }
	
	// Update is called once per frame
	void Update () {
        
        if (player.transform.position.x <= transform.position.x && (player.transform.position.x > transform.position.x - 25)) 
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,transform.position.z);
            if(transform.position.x < begin)
            {
                transform.position = new Vector3(begin, transform.position.y, transform.position.z);
            }
            if (transform.position.x > end)
            {
                transform.position = new Vector3(end, transform.position.y, transform.position.z);
            }
        }
        else
        {
            float posx = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref v.x, smoothTime);
            transform.position = new Vector3(posx, transform.position.y, transform.position.z);
            if (transform.position.x < begin)
            {
                transform.position = new Vector3(begin, transform.position.y, transform.position.z);
            }
            if (transform.position.x > end)
            {
                transform.position = new Vector3(end, transform.position.y, transform.position.z);
            }
        }
       
    }

 
  
}
