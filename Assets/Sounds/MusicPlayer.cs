using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    static MusicPlayer instance = null;


    //Test for instance and execution order
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            Debug.Log("new MusicPlayer destroyed");
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }


    // Use this for initialization
    void Start ()
    {
                
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
