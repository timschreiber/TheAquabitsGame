using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour
{
    public float deathY;
    public bool hasDied;

	// Use this for initialization
	void Start ()
    {
        hasDied = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(!hasDied && gameObject.transform.position.y < deathY)
        {
            hasDied = true;
        }

        if(hasDied)
        {
            die();
        }
	}

    void die()
    {
        SceneManager.LoadScene("ManAnt_Scene");
        hasDied = false;
    }
}
