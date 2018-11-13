using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TacticSlot : MonoBehaviour, IDropHandler
{

    public TacticSpawnRequirements tacticSpawnRequirements;
    private Tactics tactics;
    public GameObject TacticLoaded;

    void Start()
    {
 
    }



    public GameObject item
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;

            }
            return null;
        }
    }

    #region IDropHandler implementation

    public void OnDrop(PointerEventData eventData)
    {
        // when no item in slot execute the following
        if (!item)
        {

            // only if the slot is of the same type as the item execute
            if (DragHandler.itemBeingDragged.tag == "Tactics")
            {
                DragHandler.itemBeingDragged.transform.SetParent(transform);
                              
                    PrintTacticRequirements();
               

            }
        }
    }
    #endregion

    public void PrintTacticRequirements()
    {
        // get # item requirements from object
        Debug.Log(DragHandler.itemBeingDragged.name);
        TacticLoaded.GetComponent<Text>().text = DragHandler.itemBeingDragged.name;

        tactics = item.GetComponent<Tactics>();
       
       
        // Set launch variable in TacticSpawn script
        tacticSpawnRequirements.staffSlotsToCreate = tactics.staffNeeded;
        tacticSpawnRequirements.cyclistSlotsToCreate = tactics.cyclistsNeeded;
        tacticSpawnRequirements.equipmentSlotsToCreate = tactics.equipmentNeeded;
        tacticSpawnRequirements.LaunchRequirements();

        // activate instantiation process

    }
}

