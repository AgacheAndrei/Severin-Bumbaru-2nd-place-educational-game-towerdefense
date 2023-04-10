using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sc2 : MonoBehaviour
{
    static int x = 1000;


    void Update()
    {
        x--;
        if (x == 0)
            SceneManager.LoadSceneAsync("Lvl2");
    }
}
