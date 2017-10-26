using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject coinPoof;
    public AudioClip coinPoofSound;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        GameObject poof = (GameObject)Instantiate(coinPoof, transform.position , transform.rotation * Quaternion.Euler(-90, 0, 0));
        AudioSource coinSound = poof.AddComponent<AudioSource>();
        coinSound.PlayOneShot(coinPoofSound);
        // Destroy this coin. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
    }
    
}
