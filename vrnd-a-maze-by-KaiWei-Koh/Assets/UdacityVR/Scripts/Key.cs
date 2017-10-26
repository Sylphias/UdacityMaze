using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject keyPoof;
    public Door door;
    public AudioClip poofSound;

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        GameObject poof = (GameObject)Instantiate(keyPoof,transform.position-new Vector3(0,2,0),transform.rotation);
        AudioSource coinSound = poof.AddComponent<AudioSource>();
        coinSound.PlayOneShot(poofSound);
        // Call the Unlock() method on the Door
        door.Unlock();
        // Set the Key Collected Variable to true
        door.keyCollected = true;
        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
    }

}
