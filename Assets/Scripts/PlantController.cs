using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public float attackCooldown;
    private float attackTime;
    public int DamageValue;
    public List<GameObject> zombies;
    public bool isAttacking;
    public GameObject toAttack;
    public int Health;

    

    private void Update()
    {
        if (zombies.Count > 0)
        {
            float distance = 1010;
            foreach (GameObject zombie in zombies)
            {
                float zombieDistance = Vector3.Distance(transform.position, zombie.transform.position);
                if (zombieDistance < distance)
                {
                    toAttack = zombie;
                    distance = zombieDistance;
                }
            }
        }
        else
        {
            toAttack = null;
        }
        /*if (zombies.Count > 0 && isAttacking == false)
        {
            isAttacking = true;
        }
        else if (zombies.Count == 0 && isAttacking == true)
        {
            isAttacking = false;
        }*/
        if (toAttack != null)
        {
            if (attackTime <= Time.time)
            {
                GameObject bulletInstance = Instantiate(bullet, transform);
                bulletInstance.GetComponent<Bullet>().DamageValue = DamageValue;
                attackTime = Time.time + attackCooldown;
            }
        }
    }
    public void ReceiveDamage(int Damage)
    {
        Health = Health - Damage;
        if (Health <= 0)
        {

            //isStopped = false
            Destroy(this.gameObject);
            
        }

    }
}
