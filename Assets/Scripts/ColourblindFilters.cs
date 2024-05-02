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
    PostProcessProfile profile;
    PostProcessVolume volume;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("ToggleBool") == 1) 
        {
            toggleNone.isOn = true;
            volume.profile = profile;
        }
        else
        {
            toggleNone.isOn = false;
        }

        if (PlayerPrefs.GetInt("ToggleBool") == 1)
        {
            toggleProtanopia.isOn = true;
        }
        else
        {
            toggleProtanopia.isOn = false;
        }

        if (PlayerPrefs.GetInt("ToggleBool") == 1)
        {
            toggleDeuteranopia.isOn = true;
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
