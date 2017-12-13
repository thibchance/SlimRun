using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SlimeController : MonoBehaviour
{

    [Header("Physics")]
    [SerializeField]
     float force = 10;
    [Header("Jump")]
    [SerializeField]
    private Transform positionRaycastJump;
    [SerializeField]
    private float radiusRaycastJump;
    [SerializeField]
    private LayerMask LayerMaskJump;
    [SerializeField]
    private float forcejump = 5;

    private PlatformGenerator platformgenerator;
   
    private Rigidbody2D rigidbody;
	// Use this for initialization
	void Start ()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        platformgenerator = FindObjectOfType<PlatformGenerator>();

    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal_Input = Input.GetAxis("Horizontal");
        //if (Input.GetAxis("Horizontal"))
        //{

        //}

        Vector2 forcedirection = new Vector2(Horizontal_Input, 0);
        forcedirection *= force;
        rigidbody.AddForce(forcedirection);
        bool touchfloor = Physics2D.OverlapCircle(positionRaycastJump.position, radiusRaycastJump, LayerMaskJump);
        if (Input.GetAxis("Jump") > 0 && touchfloor)
        {
            //rigidbody.velocity = new Vector2()
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "collision")
        {
            SceneManager.LoadScene("GameOver");
        }
        if (collision.gameObject.tag == "hit")
        {
            SceneManager.LoadScene("GameOver");
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Generator")
        {
            platformgenerator.RandomPlatfromGenerator();
        }

        if(collision.tag == "LimitDie")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
