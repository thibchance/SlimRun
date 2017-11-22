using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    [SerializeField]
     Button button;
	// Use this for initialization
	void Start ()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(btnClick);
	}
	
    void btnClick()
    {
        SceneManager.LoadScene("GameLevel");
    }
	// Update is called once per frame
	void Update ()
    {
		
	}
}
