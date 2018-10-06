using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource audioSource;
    bool flag = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            audioSource.Play();
            flag = true;

        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            flag = false;
            audioSource.Pause();
        }

        //if (flag)
        //    Debug.Log(audioSource.time);



    }



}
