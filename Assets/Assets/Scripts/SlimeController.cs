using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SlimeController : MonoBehaviour
{

    private int offsetscore = 0;
    private int score = 0;
    [SerializeField]
    int highscore = 0;
    [SerializeField]
    Text textscore;
    private const string TEXT_SCORE = "Score = ";
    [SerializeField]
    Text texthighscore;
    private const string TEXT_HIGHSCORE = "HighScore = ";

    [Header("Velocity")]
    [SerializeField]
    float Velocity_X;
    [SerializeField]
    float Velocity_Y;
    [SerializeField]
    bool isGrounded;
    [SerializeField] float speed;

    [SerializeField] float speedmvt;
    private PlatformGenerator platformgenerator;

    
    private Rigidbody2D body;
    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        platformgenerator = FindObjectOfType<PlatformGenerator>();

        textscore.text = TEXT_SCORE + score;
        texthighscore.text = TEXT_HIGHSCORE + PlayerPrefs.GetInt("HighScore = ", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (offsetscore == 2)
        {
            Velocity_X += speedmvt;
            offsetscore = 0;
        }
      
        
    }


    private void FixedUpdate()
    {  
        body.velocity = new Vector2(Velocity_X, body.velocity.y);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            body.velocity = body.velocity + Vector2.up * speed;
            isGrounded = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Platform"))
        {
            isGrounded = true;
        }
            if (collision.gameObject.tag == "collision")
        {
            
        SceneManager.LoadScene("GameOver");
        // soundhit.PlaySound();
        }
        
    if (collision.gameObject.tag == "hit")
        {
            
            SceneManager.LoadScene("GameOver");
            // soundhit.PlaySound();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Generator")
        {
            platformgenerator.RandomPlatfromGenerator();
        }

        if (collision.tag == "LimitDie")
        {
            SceneManager.LoadScene("GameOver");
            // soundhit.PlaySound();
        }
        if (collision.tag == "Score")
        {
        Debug.Log("ICI");
            offsetscore++;
            score++;
            textscore.text = score.ToString();

            if (score > PlayerPrefs.GetInt("HighScore = ", 0))
            {
                PlayerPrefs.SetInt("HighScore = ", score);
                texthighscore.text = score.ToString();
            }

            
            textscore.text = TEXT_SCORE + score;
            texthighscore.text = TEXT_HIGHSCORE + highscore;



        }
    }
    }

