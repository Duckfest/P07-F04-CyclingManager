using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RiderSelected : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{



    public void OnPointerEnter(PointerEventData eventData)
    {
        // for readability start with finding update function in RaceManager
        GameObject raceManager = GameObject.Find("RaceManager");
        RiderDisplay riderDisplay = raceManager.GetComponent(typeof(RiderDisplay)) as RiderDisplay;
        
        // find out who our selected rider is
        RiderStatistics currentRiderStatistics = gameObject.GetComponent(typeof(RiderStatistics)) as RiderStatistics;
        string selectedridernametext = gameObject.name;
        riderDisplay.UpdateRiderSelectedName(selectedridernametext);
        
        // Get and publish stamina
        int selectedriderStamina = currentRiderStatistics.riderStamina;
        string selectedriderstaminatext = "Stamina = " + selectedriderStamina.ToString();
        riderDisplay.UpdateRiderSelectedStamina(selectedriderstaminatext);

        // Get and publish energy
        int selectedriderEnergy = currentRiderStatistics.riderEnergy;
        riderDisplay.UpdateRiderSelectedEnergy(selectedriderEnergy);


        // Get and publish slippery
        int selectedriderSlippery = currentRiderStatistics.tyreGrip;
        string selectedriderslipperytext = "Tyre Grip = " + selectedriderSlippery.ToString();
        riderDisplay.UpdateRiderSelectedSlippery(selectedriderslipperytext);

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }

    


}
