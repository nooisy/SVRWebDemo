using System;
using UnityEngine;

public class PS10 : MonoBehaviour
{
    private bool toggleSong = false;

    FMOD.Studio.EventInstance S10;

    private void Start()
    {
        S10 = FMODUnity.RuntimeManager.CreateInstance("event:/Populieren/Speaker 10");
        S10.start();
    }

    void Update()
    {
        S10.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));

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
