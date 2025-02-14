﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    public Transform spawnPoint;
    [SerializeField] private AudioSource resetSoundEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            resetSoundEffect.Play();
            ResetPlayer(other.gameObject);
        }
        else
        {
            other.gameObject.SetActive(false);
        }
    }

    public void ResetPlayer(GameObject other)
    {
        other.transform.position = spawnPoint.position;
    }
}
