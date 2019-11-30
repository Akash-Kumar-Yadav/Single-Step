using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorAnim : MonoBehaviour
{
    private AudioSource audio;
    public static FloorAnim Instance;
    public float musicvolume;
    private void Awake()
    {
        audio = GetComponent<AudioSource>();

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else if (Instance != null)
        {
            Destroy(this.gameObject);
        }
        
    }
    private void Update()
    {
        audio.volume = musicvolume;
    }
    public void volume(float vol)
    {
        musicvolume = vol;
    }

}
