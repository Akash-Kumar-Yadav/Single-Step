using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMUsic : MonoBehaviour
{
    private AudioSource audio;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public void music()
    {
        audio.Play();
    }
}
