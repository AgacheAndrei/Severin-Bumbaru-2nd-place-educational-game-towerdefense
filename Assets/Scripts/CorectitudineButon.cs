using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CorectitudineButon : MonoBehaviour
{
    public GameObject newButtown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeColorCorect()
    {
        newButtown.GetComponent<Text>().color = Color.green;
    }
    public void changeColorGresit()
    {
        newButtown.GetComponent<Text>().color = Color.red;
    }
}
