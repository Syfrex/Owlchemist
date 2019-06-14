using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioComponentChickenAI : MonoBehaviour
{
    public AudioClip[] walkingSounds;
    public AudioClip stalkingSound;
    public AudioClip runningSound;
    public AudioClip lookaroundSound;
    public AudioClip[] staggerSound;
    public AudioClip stompSound;
    int voiceNumber;
    public AudioSource audioS;

    private void Start()
    {
        voiceNumber = Random.Range(0,1);
    }
    void WalkingSound()
    {
        audioS.PlayOneShot(walkingSounds[Random.Range(0, walkingSounds.Length - 1)]);
    }

    void StalkingSound()
    {
        //audioS.PlayOneShot(walkingSounds[Random.Range(0, walkingSounds.Length - 1)]);
        audioS.PlayOneShot(stalkingSound);
    }

    void RunningSound()
    {
        audioS.PlayOneShot(runningSound);
    }

    void LookAroundSound()
    {
        audioS.PlayOneShot(lookaroundSound);
    }

    void StaggerSound()
    {
        audioS.PlayOneShot(staggerSound[voiceNumber]);
    }

    void StompSound()
    {
        audioS.PlayOneShot(stompSound);
    }
}