using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ObjectCard : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    // obiectele necesare
    public GameObject object_Drag;
    public GameObject object_Game;
    public Canvas canvas;
    private GameObject objectDragInstance;
    private GameManager gameManager;
    //pretul obiectului
    public int pret;
    private void Start()
    {
        //instanta pentru game mananeger
        gameManager = GameManager.instance;
    }
    //Daca vrei sa selectezi un caracter
    public void OnDrag(PointerEventData eventData)
    {
        int sumaActuala = ECO.Instance.money;//suma de bani din clasa singleton
        if (sumaActuala - pret >= 0)//daca ai destui bani
        {
           //cumperi obiectul si l pui unde vrei
            objectDragInstance.transform.position = Input.mousePosition;
        }
       
    }
    //cat timp ai obiectul selectat
    public void OnPointerDown(PointerEventData eventData)
    {

        //se creaza o instanta a imaginii obiectului (un fel de tipar) pozitia este data de mous
        objectDragInstance=Instantiate(object_Drag, canvas.transform);
        objectDragInstance.transform.position = Input.mousePosition;
        //si ai creat o instanta pe care poti sa o muti unde vrei
        objectDragInstance.GetComponent<ObjectDragging>().card = this;
        gameManager.draggingObject = objectDragInstance;

    }
    //cand lasi obiectul unde vrei
    public void OnPointerUp(PointerEventData eventData)
    {
        //daca oboectul nu este nul si ai loc valid unde sa l pui
        if (gameManager.draggingObject != null && gameManager.currentContainer != null)
        {
            int sumaActuala = ECO.Instance.money;
            //se scada suma de bani abia cand ai pus obiectul
            //il pui unde doresti si acolo se init un obiect dupa tipar
            ECO.Instance.substractMoney(pret);
            gameManager.PlaceObject();
            //elemntul pe care il mutai este doar o imagine pt acel obiect (nu este unu real)
            //cand nu mai ai  nevoie de le il stergi
            gameManager.draggingObject = null;
            Destroy(objectDragInstance);
        }
        else
        {
            //sau daca una din conditiile din if este falsa se sterge imaginea
           Destroy(objectDragInstance);
        }
    }
}
