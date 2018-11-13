using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceEventLog : MonoBehaviour {

    public GameObject DisplayFallMessage;


    // Private VARS
    private List<string> Eventlog = new List<string>();


    // Public VARS
    public int maxLines = 8;
    private string reportEventsText = "";



    // Use this for initialization
    void Start () {
        DisplayFallMessage.GetComponent<Text>().text = reportEventsText;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddEvent(string eventString)
    {
        Eventlog.Add(eventString);
        
        if (Eventlog.Count >= maxLines)
            Eventlog.RemoveAt(0);

        reportEventsText += eventString;
        reportEventsText += "\n";
      
    }

    public void UpdateRaceTextField()
    {
        DisplayFallMessage.GetComponent<Text>().text = reportEventsText;
    }
}
