using System;
using UnityEngine;

public class FS1 : MonoBehaviour
{
    private bool toggleSong = false;

    FMOD.Studio.EventInstance S1;

    private void Start()
    {
        S1 = FMODUnity.RuntimeManager.CreateInstance("event:/Fountain/Speaker 1");
        S1.start();
    }

    void Update()
    {
        S1.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));

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
