using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomFire : MonoBehaviour
{


    [Header("Fire gun super sonic lol boum")]

    [SerializeField]
    GameObject bulletPrefab;
    [SerializeField]
    Transform[] guntransform;
    [SerializeField]
    float bulletVelocity = 2;
    [SerializeField]
    float timetofire = 2;
    
    // Use this for initialization

    void Start ()
    {
        
        StartCoroutine(fire());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private IEnumerator fire()
    {
        while (true)
        {
            Debug.Log("rentre");
            yield return new WaitForSeconds(timetofire);
            foreach (Transform t in guntransform)
            {
                GameObject bullet = Instantiate(bulletPrefab, t.position, t.rotation);
                bullet.GetComponent<Rigidbody2D>().velocity = t.right * bulletVelocity;
                Destroy(bullet, 5);
            }

        }
    }
}
