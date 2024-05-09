using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColourblindFilters : MonoBehaviour
{
    public Toggle toggleNone;
    public Toggle toggleProtanopia;
    public Toggle toggleDeuteranopia;
    public PostProcessProfile Default;
    public PostProcessProfile Protanopia;
    public PostProcessProfile Deuteranopia;
    public PostProcessVolume volume;
    public PostProcessProfile current;

    // Start is called before the first frame update
     void Start()
    {
       Object.DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("ToggleBool") == 1)
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



    /*this needs to be in a DDOL object
     * on scene load, find PP volume, update profile
     * create currentProfile variable
     * update currentProfile with selected option
     * change scenes' volumes' profile top currentProfile
     */
}
