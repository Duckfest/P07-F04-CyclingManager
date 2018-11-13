using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceCharacteristics : MonoBehaviour {

    public GameObject RaceSelected;

    public int stagesUntilFinale;
    public enum RoadQuality {Dutch, Belgian};
    public enum FinaleType { Sprint, Uphill };

    public RoadQuality firstRoadQuality;
    public FinaleType firstFinaleType;

    public GameObject RaceLengthDescription;
    public GameObject RaceRoadDescription;
    public GameObject RaceFinaleDescription;

    public void RaceLookup(string name)
    {
                if (name == "omloop")
        {
            RaceSelected.SetActive(true);
            Debug.Log("Confirmed chosen is " + name);
            firstRoadQuality = RoadQuality.Dutch;
            firstFinaleType = FinaleType.Sprint;
            stagesUntilFinale = 4;
        }

    }






    // Use this for initialization
    void Start ()
    {
        firstRoadQuality = RoadQuality.Dutch;
        firstFinaleType = FinaleType.Sprint;


    }
	
	// Update is called once per frame
	void Update ()
    {
        RaceLengthDescription.GetComponent<Text>().text = "Race Duration: " + stagesUntilFinale;
        RaceRoadDescription.GetComponent<Text>().text = "Road Types: " + firstRoadQuality;
        RaceFinaleDescription.GetComponent<Text>().text = "Race Finale Type: " + firstFinaleType;
    }

    



}
