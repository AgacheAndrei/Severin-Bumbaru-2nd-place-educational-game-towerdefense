using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieController : MonoBehaviour
{
   // public Vector3 FinalDestination;
    public int Health;
    public int hp;
    public int DamageValue;
    public float movementSpeed;
    public bool isStopped;
    public float DamageCooldown;
    public static int x = 0;
    public static int morti = 1;
    public static int morti2 = 1;
    public static bool raniti = false;
    // Update is called once per frame
    private void Start()
    {
        hp = Health;
    }
    void Update()
    {
        x++;
        if( x % 900 == 0)
            ECO.Instance.addMoney(1);
        if(!isStopped)
        {
            transform.Translate(new Vector3(movementSpeed * -1 * Time.timeScale, 0, 0));//movementSpeed * -1 = mergem stanga
        }

        if (morti == 18 )
        {
            SceneManager.LoadScene("c2");
            morti = 0;
            raniti = true;
        }
        
       
        if(morti2==20)
        {
            SceneManager.LoadScene("final");
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10)
        {

            StartCoroutine(Attack(collision));
            isStopped = true;
        }
        if (collision.gameObject.layer == 13)
        {
            collision.gameObject.GetComponent<Home>().ReceiveDamage(DamageValue);
            morti++;
            if(raniti==true)
            {
                morti2++;
            }

        }
    }
    IEnumerator Attack(Collider2D collision)
    {
        if (collision == null)
        {
            isStopped = false;
        }
        else
        {
            collision.gameObject.GetComponent<PlantController>().ReceiveDamage(DamageValue);
            yield return new WaitForSeconds(DamageCooldown);
            StartCoroutine(Attack(collision));
        }
        
    }
    public void ReceiveDamage(int Damage)
    {
        Health = Health - Damage;
        if (Health <= 0)
        {
            morti++;
            if(raniti==true)
            {
                morti2++;
            }
            ECO.Instance.addMoney(hp/10);
            transform.parent.GetComponent<SpawnPoint>().zombies.Remove(this.gameObject);
            Destroy(this.gameObject);
        }

    }
}
