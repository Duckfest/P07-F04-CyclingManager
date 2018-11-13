using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RiderDisplay : MonoBehaviour {

    private RiderSelected riderSelected;
    private RiderStatistics riderStatistics;

    public GameObject RiderNameDisplay;
    public GameObject RiderStaminaDisplay;
    public GameObject RiderSlipperyDisplay;

    private Text myText;

    private float energy;
    private float maxEnergy = 100;
    public Slider EnergyBar;

    void Start()
    {
        energy = maxEnergy; 
        EnergyBar.value = energy / maxEnergy;  //Make a first Update to the Image that it shows correct

    }

    public void UpdateRiderSelectedEnergy(int selectedriderEnergy)
    {
        energy = selectedriderEnergy;
        EnergyBar.value = energy / maxEnergy;
    }



    public void UpdateRiderSelectedName(string printname)
    {
        Text myText = RiderNameDisplay.GetComponent<Text>();
        myText.text = printname;
    }


    public void UpdateRiderSelectedStamina(string printstamina)
    {
        Text myText = RiderStaminaDisplay.GetComponent<Text>();
        myText.text = printstamina;
    }

    public void UpdateRiderSelectedSlippery(string printslippery)
    {
        Text myText = RiderSlipperyDisplay.GetComponent<Text>();
        myText.text = printslippery;
    }

    


}
