using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using UnityEngine.UI;


public class RaceExecuteKM : MonoBehaviour {

    // RoadSegment evaluated 
    public GameObject RoadBlocks;
    private RoadBlockStats roadBlockStats;
    private Transform OneRoadBlockAtATime;
    private int roadSegment;

    // Rider evaluated
    private RiderStatistics riderStatistics;
    private Transform OneRiderAtATime;
    private int thisRiderSlipChance;
    private int thisRiderTyreGrip;
    private int thisBlockNetFlatChance;
    private int thisRiderNetFlatChance;
    private int randomFlatChance;

    // Groups of Riders objects
    public GameObject TetedeLaCouseRiders;
    public GameObject GoOverRidersInPeloTon;
    public GameObject DroppedRiders;
    public GameObject CrashedRiders;

    // displaying info
    private RaceEventLog eventLog;
    public GameObject DisplayLength;
    public int raceLength;



    // Use this for initialization
    void Start() {
        eventLog = GetComponent<RaceEventLog>();

        GameObject goRoadBlocks = RoadBlocks;
        raceLength = 10 * goRoadBlocks.transform.childCount;
        DisplayLength.GetComponent<Text>().text = raceLength + " KM";
        roadSegment = 0;
    }

    
    public void UpdateRiderStats()
        {

        
        GameObject goRoadBlocks = RoadBlocks;
        OneRoadBlockAtATime = goRoadBlocks.transform.GetChild(roadSegment);
        roadBlockStats = OneRoadBlockAtATime.GetComponent<RoadBlockStats>();
        int thisBlockriskOfFlat = roadBlockStats.riskOfFlat;
                int thisBlockriskOfCrash = roadBlockStats.riskOfCrash;
        int thisBlockincline = roadBlockStats.incline;
        Debug.Log("Section " + (roadSegment + 1) + " risk of flat = " + thisBlockriskOfFlat + " with risk of crash " + thisBlockriskOfCrash + " with incline " + thisBlockincline);

        roadSegment++;


        GameObject goParent = GoOverRidersInPeloTon;
        for (int i = 0; i < goParent.transform.childCount; i++)
        {
            OneRiderAtATime = goParent.transform.GetChild(i);

            riderStatistics = OneRiderAtATime.GetComponent<RiderStatistics>();
            int thisRiderTyreGrip = riderStatistics.tyreGrip;
            int thisRiderTyreStrength = riderStatistics.tyreStrength;
            RiderFlatFunction(thisBlockriskOfFlat, thisRiderTyreStrength);
        }


        UpdateUIFields();

    }

   



    void RiderFlatFunction(int valuerff01, int valuerff02)
    {
        
        int thisBlockNetFlatChance = valuerff01 * 100;  // convert % to 100s out of 10Ks
        int thisRiderTyreStrength = valuerff02; // convert % to 100s out of 10Ks

        int thisDiscountRiderTyreStrength = (thisRiderTyreStrength / 100);
  //      Debug.Log("thisBlockriskOfFlat =  " + thisBlockNetFlatChance + " however discount for Tyres = " + thisDiscountRiderTyreStrength);

        thisRiderNetFlatChance = thisBlockNetFlatChance * thisDiscountRiderTyreStrength; 
        randomFlatChance = Random.Range(0, 100);
   //     Debug.Log("Net Flat  " + thisRiderNetFlatChance + " and randdom nr " + randomFlatChance); 

      //  if (randomFlatChance < thisRiderSlipChance)
      //     {
      //         RiderDropsBehind();
      //     }
    }

    void RiderDropsBehind()
    {
        eventLog.AddEvent("Player " + riderStatistics.name + " has fallen");
        GameObject getDropped = DroppedRiders;
        OneRiderAtATime.transform.SetParent(getDropped.transform);
    }

    void UpdateUIFields()
    {
        raceLength = raceLength - 10;
        DisplayLength.GetComponent<Text>().text = raceLength + " KM";

        eventLog.UpdateRaceTextField();
    }
 

}
