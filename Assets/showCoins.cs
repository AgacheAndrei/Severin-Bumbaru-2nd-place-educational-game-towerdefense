using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showCoins : MonoBehaviour
{
    public Text t;
   
    void Start()
    {
        t.text = ECO.Instance.money.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        t.text = ECO.Instance.money.ToString();
    }
}
