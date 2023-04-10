using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//clasa singleton pentru sistemul financiar
public sealed class ECO : MonoBehaviour
{
    public int money;
   
    //public get si private set
    public static ECO Instance { get;private set; }

    private ECO() { }
    // functia se apeleaza automat la inceperea jocului
    private void Awake()
    {
       
        //Daca este o instanta, si nu sunt eu, autostergere.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    // adaugare de bani
    public void addMoney(int moneyToAdd)
    {
        money += moneyToAdd;
    }
    // retragere de bani
    public void substractMoney(int moneyToSubstract)
    {
        if(money-moneyToSubstract>=0)
        {
            money -= moneyToSubstract;
           
        }
    }
}
