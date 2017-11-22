using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {


    public GameObject platform;
    [SerializeField]
    private Transform pointplatform;
    public float distanceplatform;

    private float platformwidth;
	// Use this for initialization
	void Start ()
    {
        platformwidth = platform.GetComponent<BoxCollider2D>().size.x;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(transform.position.x < pointplatform.position.x)
        {
            transform.position = new Vector3(transform.position.x + platformwidth + distanceplatform, transform.position.y, transform.position.z);

            Instantiate(platform, transform.position, transform.rotation);
        }
	}
}
