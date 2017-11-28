using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager : MonoBehaviour {


    [SerializeField]
    AudioClip tablesounds;
    private AudioSource audiosource;
    // Use this for initialization
    void Start ()
    {
        audiosource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void PlaySound()
    {

        audiosource.clip = tablesounds;
        audiosource.Play();
    }
}
