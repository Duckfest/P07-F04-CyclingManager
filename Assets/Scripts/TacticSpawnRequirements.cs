using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TacticSpawnRequirements : MonoBehaviour
{

    public GameObject staffSLotPrefab;
    public GameObject cyclistSlotPrefab;
    public GameObject equipmentSlotPrefab;

    public int staffSlotsToCreate = 0;
    public int cyclistSlotsToCreate = 0;
    public int equipmentSlotsToCreate = 0;

    public bool AmIChanged = false;

    // Use this for initialization
    void Start()
    {
        
        
       
    }

    void Update()
    {

       

    }



        public void LaunchRequirements()
    {
      for (int i = 0; i < staffSlotsToCreate; i++)
         {
           GameObject go = Instantiate(staffSLotPrefab, transform.position, Quaternion.identity) as GameObject;
           go.transform.SetParent(this.transform);
       }
        staffSlotsToCreate = 0;

        for (int i = 0; i < cyclistSlotsToCreate; i++)
        {
            Debug.Log("cyclistSlot create?");
            GameObject go = Instantiate(cyclistSlotPrefab, transform.position, Quaternion.identity) as GameObject;
            go.transform.SetParent(this.transform);
        }
        cyclistSlotsToCreate = 0;

        for (int i = 0; i < equipmentSlotsToCreate; i++)
        {

            GameObject go = Instantiate(equipmentSlotPrefab, transform.position, Quaternion.identity) as GameObject;
            go.transform.SetParent(this.transform);
        }
        equipmentSlotsToCreate = 0;


    }

}

