using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpaceCandyMainControl : MonoBehaviour
{
    public static SpaceCandyMainControl instance;
    public List<Transform> spawnPoints;
    public GameObject astroidPrefab;
    public int numberOfAliens;
    public int maxNumberOfAliens;
    float timer;
    public float weighttime;
    bool canSpawn;
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
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 1)
        {
            canSpawn = true;
            timer = weighttime;
        }
        if (maxNumberOfAliens > numberOfAliens)
        {
            if (canSpawn == true)
            {
                int random = Random.Range(0, spawnPoints.Count);
                GameObject alien = Instantiate(astroidPrefab, spawnPoints[random].position, spawnPoints[random].rotation);
                numberOfAliens++;
                canSpawn = false;
            }

        }



    }
}

