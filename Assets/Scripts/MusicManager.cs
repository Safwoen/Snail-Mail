using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    [SerializeField] AudioSource music;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMusic()
    {
        music.Play();
        music.time = time;
    }

    public void OffMusic()
    {
        music.Stop();
        time = music.time;
    }
}
