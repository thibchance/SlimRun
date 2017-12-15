using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager : MonoBehaviour {


    [SerializeField]
    AudioClip[] tablesounds;
    private AudioSource audiosource;
    // Use this for initialization
    void Start ()
    {
        audiosource = GetComponent<AudioSource>();
      //  DontDestroyOnLoad(audiosource);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void PlaySound()
    {
        int indexsoundrandom = Random.Range(0, tablesounds.Length);
        audiosource.clip = tablesounds[indexsoundrandom];
        audiosource.Play();
    }
}
