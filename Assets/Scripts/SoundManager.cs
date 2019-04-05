using System.Collections.Generic;
using UnityEngine;
public class SoundManager : MonoBehaviour
{
    public List<AudioClip> clips = new List<AudioClip>();
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }      
    public void PlayAudio(int audioID)
    {
        audioSource.clip = clips[audioID];
        audioSource.Play();
    } 
}