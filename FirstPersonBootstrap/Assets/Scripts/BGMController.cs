
using System;
using UnityEngine;

public class BGMController : MonoBehaviour
{
    [SerializeField] private AudioSource BGM;
    [SerializeField] public TimerScript timer;

    private bool isPlaying => BGM.isPlaying;

    private void Update()
    {
        if (timer.isTimerSet && !isPlaying)
        {
            BGM.Play();
        }

        if (!timer.isTimerSet)
        {
            BGM.Stop();
        }
    }
}
