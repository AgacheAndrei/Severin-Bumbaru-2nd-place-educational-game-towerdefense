using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Home : MonoBehaviour
{
    public int Health;
    public GameManager gameManager;
    public Image backgroundImage;
    public SpawnPoint spawnPoint;
    public static int test=0;
    private void Start()
    {
        gameManager = GameManager.instance;
    }
    //se ilumineaza o bucata de la baza casei sa se vada ca a luat dmg la intrarea unui inamic
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
            backgroundImage.enabled = true;
        
    }
    //se stinge  o bucata de la baza casei scand inamicul trece de ea
    public void OnTriggerExit2D(Collider2D collision)
    {
        //gameManager.currentContainer = null;
        backgroundImage.enabled = false;
    }
    // functia de luat damage pt casa
    public void ReceiveDamage(int Damage)
    {
        Health = Health - Damage;
        //GAME OVER
        if (Health <= 0)
        {
            SceneManager.LoadScene("gameOver");
            
        }


    }
}
