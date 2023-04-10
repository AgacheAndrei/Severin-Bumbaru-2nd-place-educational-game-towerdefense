using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatie_text : MonoBehaviour
{
    //Contruism o animatie cu ajutorului acestui script

    static int x = 1400;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;

    void Update()
    {
        x--;
        if (x == 1300)
        {
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(true);

        }
        if (x == 800)
        {
            text1.SetActive(false);
            text2.SetActive(true);
            text3.SetActive(false);

        }
        if (x == 300)
        {
            text1.SetActive(true);
            text2.SetActive(false);
            text3.SetActive(false);

        }
        if (x == 0)
        {
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);

        }


    }
}
