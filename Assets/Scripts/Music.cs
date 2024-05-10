using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
    [SerializeField] AudioSource music;
    [SerializeField] AudioClip musicClip;
    float time;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("ddol");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

        SceneManager.sceneUnloaded += OnSceneUnload;
        SceneManager.sceneLoaded += OnSceneLoad;
    }

    private void OnSceneLoad(Scene arg0, LoadSceneMode arg1)
    {
        music.time = time;
    }

    private void OnSceneUnload(Scene arg0)
    {
        time = music.time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMusic()
    {
        music.Play();
    }

    public void OffMusic()
    {
        music.Stop();
    }
}
