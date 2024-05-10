using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PackageCounter : MonoBehaviour
{
    public static PackageCounter instance;

    public TMP_Text packageText;
    public int currentPackage = 5;

     void Awake()
    {
        instance = this;    
    }
    // Start is called before the first frame update
    void Start()
    {
        packageText.text = "Package Delivered: " + currentPackage.ToString();
    }


    public void IncreasePackage (int v) 
    {
        currentPackage += v;
        packageText.text = "Package: " + currentPackage.ToString();

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.LogWarning("hyjgfhytjg");
        if (other.gameObject.CompareTag("Package"))
        {
            currentPackage++;
            packageText.text = "Package: " + currentPackage.ToString();
        }
    }
}
