using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
  public  bool opened = false;
  public  Key mykey;
    AudioSource Audio_Source;
    public AudioClip []clips;
   int speed=100;
    void Start()
    {
        Audio_Source = GetComponent<AudioSource>();

        // If the door is opening and it is not fully raised
        // Animate the door raising up
    }
    void Update()
    {
        // If the door is opening and it is not fully raised
        // Animate the door raising up

        if (opened == true && transform.position.z < 2000)
        {
            transform.Translate(Vector3.up * 5f * Time.deltaTime);
        }
        else if(opened)
        {
            Destroy(gameObject);
        }
    }

    public void OnDoorClicked()
    {
        if (mykey.get_key() == true)
        {
            opened = true;
            Audio_Source.PlayOneShot(clips[1]);
            //transform.Translate(Vector3.up*speed*Time.deltaTime);
           
        }
        else
        {
            Audio_Source.PlayOneShot(clips[0]);
        }
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked

    }

    //public void Unlock()
    //{
    //    // You'll need to set "locked" to false here
    //}
}
