using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//change all GameManager to GameOverAllControl
//change all player to sneakyPlayer
public class GameOverAllControl : MonoBehaviour
{
    public static GameOverAllControl instance;

    public GameObject sneakyPlayer;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);

    }

}

