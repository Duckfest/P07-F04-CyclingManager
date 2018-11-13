using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler {

    // public TacticSpawnRequirements myChangeMeScript;
    


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
            if (DragHandler.itemBeingDragged.tag == transform.tag)
            {
               DragHandler.itemBeingDragged.transform.SetParent(transform);

            }
                    }
    }
    #endregion

    
}
