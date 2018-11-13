using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewsNavigator : MonoBehaviour {

    public GameObject MenuBarToFront;
    public GameObject MainBackground;

    public GameObject Placeitems; // the basic drag and drop view
     
    public GameObject UsePrograms; // place and load tactics

    public GameObject StaffScreenOverlay; // staff
    public GameObject CyclistScreenOverlay; // cyclists
    public GameObject EquipmentScreenView; // equipment

    bool staffButtonActive = true;
    bool teamButtonActive = true;
    bool equipmentButtonActive = true;

    public void PlaceItemVIew()
    {
        Placeitems.SetActive(true);
        UsePrograms.SetActive(false);
        MainBackground.SetActive(false);

    }

    public void GetProgramView()
    {
        UsePrograms.SetActive(true);
        Placeitems.SetActive(false);
        MainBackground.SetActive(false);

    }



    public void StaffButton()
    {
   
   
        if (staffButtonActive == true)
        {
            StaffScreenOverlay.SetActive(false);
        staffButtonActive = false;
            return;
        }
        StaffScreenOverlay.SetActive(true);
        staffButtonActive = true;
    }

    public void TeamButton()
    {


        if (teamButtonActive == true)
        {
            CyclistScreenOverlay.SetActive(false);
            teamButtonActive = false;
            return;
        }
        CyclistScreenOverlay.SetActive(true);
        teamButtonActive = true;
    }

    public void EquipmentButton()
    {

        if (equipmentButtonActive == true)
        {
            EquipmentScreenView.SetActive(false);
            equipmentButtonActive = false;
            return;
        }
        EquipmentScreenView.SetActive(true);
        equipmentButtonActive = true;
    }


    
    

    
}
