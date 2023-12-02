using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerControl : MonoBehaviour
{
    public MusicControl musicControl;

    void Awake()
    {
       
    }
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            musicControl.PlayMusic(1);
        }
        else if (Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.W) == true)
        {
            musicControl.PlayMusic(0);
        }
       
    }
}
