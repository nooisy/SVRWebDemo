using System;
using UnityEngine;

public class PS4 : MonoBehaviour
{
    private bool toggleSong = false;

    FMOD.Studio.EventInstance S4;

    private void Start()
    {
        S4 = FMODUnity.RuntimeManager.CreateInstance("event:/Populieren/Speaker 4");
        S4.start();
    }

    void Update()
    {
        S4.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));

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
