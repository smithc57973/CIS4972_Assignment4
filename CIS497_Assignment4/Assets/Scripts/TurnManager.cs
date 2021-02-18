using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public Enemy[] enemiesToSpawn;
    public List<Enemy> enemiesPresent;
    public PlayerController pc;
    
    public int wave;
    public bool waveNeeded;
    public bool doCombat;

    // Start is called before the first frame update
    void Start()
    {
        pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        spawnPoints = GameObject.FindGameObjectsWithTag("Spawn");
        wave = 1;
        waveNeeded = true;
        doCombat = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (waveNeeded)
        {
            Spawn(wave);
        }

        if (doCombat && pc.doneChoosing)
        {
            Combat();
        }
    }

    public void Spawn(int w)
    {
        foreach (GameObject s in spawnPoints)
        {
            if (enemiesPresent.Count < w)
            {
                int rand = Random.Range(0, 100);
                if (rand <= 60)
                {
                    Enemy ske = Instantiate(enemiesToSpawn[0], s.transform);
                    enemiesPresent.Add(ske);
                }
                else if (rand > 60 && rand < 90)
                {
                    Enemy sli = Instantiate(enemiesToSpawn[1], s.transform);
                    enemiesPresent.Add(sli);
                }
                else
                {
                    Enemy beh = Instantiate(enemiesToSpawn[2], s.transform);
                    enemiesPresent.Add(beh);
                }
            }
            else
            {
                break;
            }
            
        }

        waveNeeded = false;
        wave++;
        /*if (!pc.canChooseClass)
        {
            doCombat = true;
        }*/
        doCombat = true;
    }

    public void Combat()
    {
        foreach (Enemy e in enemiesPresent)
        {
            //Combat attempt 1
            /*if (e.vulnerability == pc.u.dmgType)
            {
                e.health -= pc.u.Attack();
            }
            e.health -= pc.u.Attack();

            if (e.health <= 0)
            {
                enemiesPresent.Remove(e);
                Destroy(e.gameObject);
                //e.gameObject.SetActive(false);
            }
            else
            {
                pc.u.hp -= e.damage;
            }*/
            
            //Combat attempt 2
            pc.u.hp = pc.u.GetHP() - e.damage;
            if (e.vulnerability == pc.u.dmgType)
            {
                e.health -= pc.u.Attack();
            }
            e.health -= pc.u.Attack();

            if (e.health <= 0)
            {
                enemiesPresent.Remove(e);
                Destroy(e);
            }
        }

        if (enemiesPresent.Count == 0)
        {
            doCombat = false;
            waveNeeded = true;
            pc.canChooseClass = true;
        }

    }
}
