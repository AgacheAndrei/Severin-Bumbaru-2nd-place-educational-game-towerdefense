using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // obiectele care o sa fie folosite precum caractere si ce containare avem disponibile
    public GameObject draggingObject;
    public GameObject currentContainer;
    public static GameManager instance;
    public void Awake()
    {
        instance = this;
    }
    //functia de legatura dintre obiect si container
    public void PlaceObject()
    {
       //daca obiectele nu sunt nule
        if (draggingObject != null && currentContainer != null)
        {
            //de pe obiect se adauga o instanta corespunzatoare obiectului si tparului acestuia ales si este pus in zona corecta
            GameObject objectGame = Instantiate(draggingObject.GetComponent<ObjectDragging>().card.object_Game, currentContainer.transform);
            //obiectele de tip inamic sunt create dupa tiparele corespunzatoare la zonele de spawn
            objectGame.GetComponent<PlantController>().zombies = currentContainer.GetComponent<ObjectContainer>().spawnPoint.zombies;
            // si containerul devine full, astfel nu putem pune 2 obiecte pe aceeasi zona
            currentContainer.GetComponent<ObjectContainer>().isFull = true;
        }
    }
}

