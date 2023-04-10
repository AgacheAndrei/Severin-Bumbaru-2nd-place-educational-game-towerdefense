using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerQ : MonoBehaviour
{
    public static bool isGamePaused = false;
    public GameObject[] Levels;
    //public GameObject ResetScreen, End;
    public GameObject next;
    public GameObject Ok;
    public GameObject notOk;
    int currentLevel;
    public static int x = 0;

    public void wrongAnswer()
    {
        Levels[currentLevel].SetActive(false);
        ResumeGame();
        currentLevel++;
        ECO.Instance.substractMoney(50);
        notOk.SetActive(true);
        Ok.SetActive(false);
        //ResetScreen.SetActive(true);


    }
    public void goodAnswer()
    {
        Levels[currentLevel].SetActive(false);
        ResumeGame();
        currentLevel++;
        ECO.Instance.addMoney(300);
        notOk.SetActive(false);
        Ok.SetActive(true);
    }

    /*public void ResetGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }*/

    private void Start()
    {
        //next.SetActive(false);
    }
    public void OnClick()
    {
        
            Levels[currentLevel].SetActive(true);
            PauseGame();
        if (Levels.Length == x + 1)
        { 
            next.SetActive(false);
            notOk.SetActive(false);
            Ok.SetActive(true);
        }

        x++;
    } 

    public void ResumeGame()
    {
        //Levels[currentLevel].SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }
    void PauseGame()
    {
        //Levels[currentLevel].SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }




}