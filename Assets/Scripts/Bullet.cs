using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float movementSpeed;
    public int DamageValue;
    //functie apelata pe fiecare frame
    void Update()
    {
        //miscarea unui obiecte de tip bullet 
        transform.Translate(new Vector3(movementSpeed * Time.timeScale, 0, 0));
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //prin verificarea acestui tag se limiteaza elementele pe care le poate lovii un bulet
        //loveste doar elementele de pee tag ul 11 (care in joc sunt inamici) astfel nu loveste aliati sau alte structuri
        if (collision.gameObject.layer == 11)
        {
            // cu ajutorul engin-ul fizic din unity puteam afla daca a avut loc o coliziune
            // obiectul de care s-a lovit o sa primeasca un damage in functie de tipul caracterului care a tras acest bulet
            collision.gameObject.GetComponent<ZombieController>().ReceiveDamage(DamageValue);
            //dupa impact se distruge bullet-ul
            Destroy(this.gameObject);
        }
    }
}
