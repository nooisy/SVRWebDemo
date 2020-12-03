using System;
using UnityEngine;

public class PS3 : MonoBehaviour
{
    private bool toggleSong = false;

    FMOD.Studio.EventInstance S3;

    private void Start()
    {
        S3 = FMODUnity.RuntimeManager.CreateInstance("event:/Populieren/Speaker 3");
        S3.start();
    }

    void Update()
    {
        S3.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));

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
