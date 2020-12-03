using System;
using UnityEngine;

public class PS8 : MonoBehaviour
{
    private bool toggleSong = false;

    FMOD.Studio.EventInstance S8;

    private void Start()
    {
        S8 = FMODUnity.RuntimeManager.CreateInstance("event:/Populieren/Speaker 8");
        S8.start();
    }

    void Update()
    {
        S8.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));

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
