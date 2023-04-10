using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]//sa ne arate clasa in inspector
public class Zombie 
{
    public int spawnTime;
    public ZombieType ZombieType;
    public int Spawner;
    public bool RandomSpawn;
    public bool isSpawned;
}
public enum ZombieType
{
    
    Zombie_Basic,
    Zombie_Cone,
    Zombie_Bucket
}