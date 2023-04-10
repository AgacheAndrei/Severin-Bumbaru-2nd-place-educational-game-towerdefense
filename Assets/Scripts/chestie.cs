using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chestie : MonoBehaviour
{
    static int x = 1400;
  
    
    void Update()
    {
        x--;
        if(x==0)
            SceneManager.LoadScene("lvl1");
    }
}
