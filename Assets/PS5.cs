using System;
using UnityEngine;

public class PS5 : MonoBehaviour
{
    private bool toggleSong = false;

    FMOD.Studio.EventInstance S5;

    private void Start()
    {
        S5 = FMODUnity.RuntimeManager.CreateInstance("event:/Populieren/Speaker 5");
        S5.start();
    }

    void Update()
    {
        S5.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));

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
