using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject[] enemies;
    
    public int wave;

    // Start is called before the first frame update
    void Start()
    {
        wave = 1;
        //Spawn(wave);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn(int w)
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("Spawn");
        int numSpawn = 0;
        
        foreach (GameObject s in spawnPoints)
        {
            if (numSpawn < w)
            {
                int rand = Random.Range(0, 100);
                if (rand <= 60)
                {
                    Instantiate(enemies[0], s.transform);
                    numSpawn++;
                }
                else if (rand > 60 && rand < 90)
                {
                    Instantiate(enemies[1], s.transform);
                    numSpawn++;
                }
                else
                {
                    Instantiate(enemies[2], s.transform);
                    numSpawn++;
                }
            }
            else
            {
                break;
            }
            
        }
    }
}
