using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    public AudioClip lockSound;
    public AudioClip doorOpening;
    public bool keyCollected;
    Animation doorOpeningAnimation;
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    public bool locked;

    // Create a boolean value called "opening" that can be checked in Update() 
    public bool opening;

    private void Start()
    {
        locked = true;
        doorOpeningAnimation = gameObject.GetComponent<Animation>();
    }
    private void Update()
    {

    }


    public void OnDoorClicked() {
        AudioSource doorAudio = gameObject.GetComponent<AudioSource>();
        if (!locked)
        {
            opening = true;
            doorAudio.PlayOneShot(doorOpening);
            doorOpeningAnimation.Play("Door");
        }
        else
        {

            doorAudio.PlayOneShot(lockSound);
        }
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        locked=false;
    }
}
