using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroy : MonoBehaviour {


    public GameObject pointdestroy;
	// Use this for initialization
	void Start ()
    {
        pointdestroy = GameObject.Find("PointDestruct");
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(transform.position.x < pointdestroy.transform.position.x)
        {
            Destroy(gameObject);
        }
	}
}
