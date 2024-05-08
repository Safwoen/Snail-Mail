using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class ColourblindFilters : MonoBehaviour
{
    public Toggle toggleNone;
    public Toggle toggleProtanopia;
    public Toggle toggleDeuteranopia;
    public PostProcessProfile Default;
    public PostProcessProfile Protanopia;
    public PostProcessProfile Deuteranopia;
    public PostProcessVolume volume;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("ToggleBool") == 1) 
        {
            toggleNone.isOn = true;
            volume.profile = Default;
        }
        else
        {
            toggleNone.isOn = false;
        }

        if (PlayerPrefs.GetInt("ToggleBool") == 1)
        {
            toggleProtanopia.isOn = true;
            volume.profile = Protanopia;
        }
        else
        {
            toggleProtanopia.isOn = false;
        }

        if (PlayerPrefs.GetInt("ToggleBool") == 1)
        {
            toggleDeuteranopia.isOn = true;
            volume.profile = Deuteranopia;
        }
        else
        {
            toggleDeuteranopia.isOn = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
