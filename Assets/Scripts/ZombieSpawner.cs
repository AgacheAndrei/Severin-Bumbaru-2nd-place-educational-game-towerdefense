using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public List<GameObject> zombiePrefab;
    public List<Zombie> zombies;

    private void Update()
    {
        //trecem prin inamici
        foreach (Zombie zombie in zombies)
        {
            //daca este timpul si spanwnul este liber
            if (zombie.isSpawned == false && zombie.spawnTime <= Time.time)
            {
                if (zombie.RandomSpawn)
                {
                    zombie.Spawner = Random.Range(0, transform.childCount); //alege random un spawnpoint pentru inamicul curent
                }
                GameObject zombieInstance = Instantiate(zombiePrefab[(int)zombie.ZombieType], transform.GetChild(zombie.Spawner).transform);
                transform.GetChild(zombie.Spawner).GetComponent<SpawnPoint>().zombies.Add(zombieInstance);
                zombie.isSpawned = true;
                //zombieInstance.GetComponent<ZombieController>().FinalDestination = transform.GetChild(zombie.Spawner).transform.GetComponent<SpawnPoint>().Destination;
            }
        }
    }
}


