using System;
using UnityEngine;

public class PS2 : MonoBehaviour
{
    private bool toggleSong = false;

    FMOD.Studio.EventInstance S2;

    private void Start()
    {
        S2 = FMODUnity.RuntimeManager.CreateInstance("event:/Populieren/Speaker 2");
        S2.start();
    }

    void Update()
    {
        S2.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));

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
