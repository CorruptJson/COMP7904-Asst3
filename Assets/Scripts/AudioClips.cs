using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClips : MonoBehaviour
{
    public static AudioClips singleton;
    public AudioClip walk;
    public AudioClip openDoor;
    public AudioClip closeDoor;
    public AudioClip tvStatic;
    public AudioClip switchFlip;
    public AudioClip unlock;
    public AudioClip pickupKey;

    // Start is called before the first frame update
    void Start()
    {
        singleton = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
