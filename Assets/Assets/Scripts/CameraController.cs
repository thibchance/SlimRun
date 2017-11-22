using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    [SerializeField]
    private SlimeController slimeController;

    private Vector3 lastPosition;
    private float distancemove;

	// Use this for initialization
	void Start ()
    {
        slimeController = FindObjectOfType<SlimeController>();
        lastPosition = slimeController.transform.position;

	}
	
	// Update is called once per frame
	void Update ()
    {
        distancemove = slimeController.transform.position.x - lastPosition.x;

        transform.position = new Vector3(transform.position.x + distancemove, transform.position.y, transform.position.z);
        lastPosition = slimeController.transform.position;

    }
}
