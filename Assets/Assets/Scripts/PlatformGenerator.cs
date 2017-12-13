using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {


    public GameObject platform;
    [SerializeField]
    private Transform pointplatform;
    public float distanceplatform;
    [SerializeField]
    Transform[] spawnplatformgenerator;

    private float platformwidth;

    //[SerializeField]
    //private Renderer renderer;
    // Use this for initialization
    void Start ()
    {
       // renderer = GetComponent<Renderer>();
        platformwidth = platform.GetComponent<BoxCollider2D>().size.x;
        
    }
	
	// Update is called once per frame
	void Update ()
    {
       // RandomPlatfromGenerator();

        //tranforms.position.x = au centre 
        //
        //if (/*renderer.bounds.min.x*/ transform.position.x <= pointplatform.position.x)
        //{
        //    transform.position = new Vector3(transform.position.x /*renderer.bounds.min.x */+ platformwidth + distanceplatform, transform.position.y, transform.position.z);

        //    Instantiate(platform, transform.position, transform.rotation);
        //}

    }

    public void RandomPlatfromGenerator()
    {
        int spawnindex = Random.Range(0, spawnplatformgenerator.Length);

        if (/*renderer.bounds.min.x*/ spawnplatformgenerator[spawnindex].position.x <= pointplatform.position.x)
        {
            transform.position = new Vector3(spawnplatformgenerator[spawnindex].position.x /*renderer.bounds.min.x */+ platformwidth + distanceplatform, transform.position.y, transform.position.z);

            Instantiate(platform, spawnplatformgenerator[spawnindex].position, transform.rotation);
        }
    }
    

    //public void OnDrawGizmosSelected()
    //{
    //    Vector3 max = renderer.bounds.max;
    //    Vector3 min = renderer.bounds.min;
    //}
}
