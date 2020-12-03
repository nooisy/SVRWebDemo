using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{

    bool audioResumed = false;

    public void ResumeAudio()
    {
       if (!audioResumed)
       {
           var result = FMODUnity.RuntimeManager.CoreSystem.mixerSuspend();
           Debug.Log(result);
           result = FMODUnity.RuntimeManager.CoreSystem.mixerResume();
           Debug.Log(result);
           audioResumed = true;
       }
     }

    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
