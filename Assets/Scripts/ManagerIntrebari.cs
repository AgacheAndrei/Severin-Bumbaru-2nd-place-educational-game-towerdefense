using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerIntrebari : MonoBehaviour
{
    public GameObject[] Levels;
    public GameObject corect;
    public GameObject gresit;
    
    public void correctAnswer()
    {

        corect.SetActive(true);
        gresit.SetActive(false);

    }
    public void gresitAnswer()
    {
        corect.SetActive(false);
        gresit.SetActive(true);


    }
}
