using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool isGamePaused = false;
    public static int x = 0;
    // public IntrebarType intrebare;


    //public GameObject pauseMenu;
    public GameObject[] intrebari;
    public void click()
    {
        if (x <= 10)
        {
            if (x + 1 != intrebari.Length)
            {
                intrebari[x].SetActive(false);

                x++;
                intrebari[x].SetActive(true);
            }
            else
            {

                intrebari[x].SetActive(false);
            }

            /* if (isGamePaused)
                {
                     ResumeGame();

                }
                else
                {
                    PauseGame();

                }

               }*/

        }
        /* public void apelareFunctie(int i)
         {

         }
         public void ResumeGame()
         {
             pauseMenu.SetActive(false);
             Time.timeScale = 1f;
             isGamePaused = false;
         }
         void PauseGame()
         {
             pauseMenu.SetActive(true);
             Time.timeScale = 0f;
             isGamePaused = true;
         }
         public void LoadMenu()
         {
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         }
         public void QuitGame()
         {
             Application.Quit();
         }
         public void ExitButtonQuizz()
         {
            // ResumeGame();
         }
         public enum IntrebarType
         {

             Greu,
             Usor
         }*/
    }
}
