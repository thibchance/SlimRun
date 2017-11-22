using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private Rigidbody2D rigidbody;
	// Use this for initialization
	void Start ()
    {
        rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float Horizontal_Input = Input.GetAxis("Horizontal");
        Vector2 forcedirection = new Vector2(Horizontal_Input, 0);
        forcedirection *= force;
        rigidbody.AddForce(forcedirection);
        bool touchfloor = Physics2D.OverlapCircle(positionRaycastJump.position, radiusRaycastJump, LayerMaskJump);
        if (Input.GetAxis("Jump") > 0 && touchfloor)
        {
            rigidbody.AddForce(Vector2.up * forcejump, ForceMode2D.Impulse);
        }

    }
}
