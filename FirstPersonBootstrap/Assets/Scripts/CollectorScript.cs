
using System;
using TMPro;
using UnityEngine;

public class CollectorScript : MonoBehaviour
{
    private int _coin = 0;

    [SerializeField] private TextMeshProUGUI CoinText;
    [SerializeField] private AudioSource collectSoundEffect;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Collectable")) // recognize if colliding with a collectable object
        {
            
            // if collided with a collectable object
            // do the following:
            collectSoundEffect.Play();                      // play the collect sound effect                  
            Destroy(collision.gameObject);                  // make the collectable object invisible by destroying it
            _coin++;                                        // record the new amount of objects collected
            CoinText.text = "Coin: " + _coin;               // show the result on the screen
        }
    }
}
