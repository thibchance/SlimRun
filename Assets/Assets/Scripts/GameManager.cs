using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private float score = 0;
    [SerializeField]
    Text textscore;
    [SerializeField]
    private float pointseconds;
    private const string TEXT_SCORE = "Score = ";

    private static GameObject lastscore;
    public bool scoreincreasing;
	// Use this for initialization
	void Start ()
    {
        //textscore.text = PlayerPrefs.GetInt("Score",0).ToString();

        if (lastscore == null)
        {
            DontDestroyOnLoad(gameObject);
            lastscore = gameObject;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    
    private void PlayerDie()
    {
        
        SceneManager.LoadScene("GameOver");
    }
	// Update is called once per frame
	void Update ()

    {

        //Debug.Log("score");
        if (scoreincreasing)
        {
            score += pointseconds * Time.deltaTime;
            
        }
        textscore.text = TEXT_SCORE + Mathf.Round(score);
        //PlayerPrefs.SetFloat("Score",score);
       
    }
    public float GetScore()
    {
        return score;
    }
}
