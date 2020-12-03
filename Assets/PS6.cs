using System;
using UnityEngine;

public class PS6 : MonoBehaviour
{
    private bool toggleSong = false;

    FMOD.Studio.EventInstance S6;

    private void Start()
    {
        S6 = FMODUnity.RuntimeManager.CreateInstance("event:/Populieren/Speaker 6");
        S6.start();
    }

    void Update()
    {
        S6.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));

        if (Input.GetKeyDown(KeyCode.C))
        {
            if(toggleSong == false)
            {
                FMODUnity.RuntimeManager.StudioSystem.setParameterByName("Switch", 1f);
                toggleSong = true;
                print("Word");
            } else
            {
                FMODUnity.RuntimeManager.StudioSystem.setParameterByName("Switch", 0f);
                toggleSong = false;
                print("Amor");
            }
        }
    }
}
