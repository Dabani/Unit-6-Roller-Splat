using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
*   Script to play audio background across multiple scenes
*   from youtube resource https://www.youtube.com/watch?v=i0coh71r-v8
*   watched on October 07, 2022
*/
public class BackGroundSound : MonoBehaviour
{
    // Play globally
    private static BackGroundSound instance = null;
    public static BackGroundSound Instance 
    {
        get {
            return instance;
        }
    }

    void Awake() {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // End play globally
}
