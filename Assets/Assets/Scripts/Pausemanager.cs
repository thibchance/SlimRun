using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausemanager : MonoBehaviour {
    
   [SerializeField]
   private GameObject panelpause;
   [SerializeField]
   private GameObject uigamepanel;
    private bool isinpause = false;

    private static Pausemanager instance;


    //public static Pausemanager instance{

    //    get
    //    {
    //        return instance;
    //    }

    //}
    //private void Awake()
    //{
    //    instance = this;
    //}
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButton("Pause") && !isinpause)
        {
            isinpause = true;
            panelpause.SetActive(true);
            uigamepanel.SetActive(false);
             Time.timeScale = 0;
        }
    }
    public void onresumeGameButtonDown()
    {
            isinpause = false;
            panelpause.SetActive(false);
            uigamepanel.SetActive(true);
            Time.timeScale = 1;
    }
}
