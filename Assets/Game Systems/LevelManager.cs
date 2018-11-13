using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {
    public int buildIndex;

   
  
    // Everytime a new level is started
    public void LoadLevel(string name)
    {


       SceneManager.LoadScene(name);
    }
        

      
   



    
}