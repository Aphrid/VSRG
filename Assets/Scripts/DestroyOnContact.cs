using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour
{

    public GameObject destroyer;
    private GameController gameController;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        if (destroyer.CompareTag("Player Perfect"))
        {
            gameController.UpdatePerfect();
        }
        else if (destroyer.CompareTag("Player Great"))
        {
            gameController.UpdateGreat();
        }
        else if (destroyer.CompareTag("Player Good"))
        {
            gameController.UpdateGood();
        }
        else if (destroyer.CompareTag("Miss"))
        {
            gameController.UpdateMiss();
        }
        gameController.UpdateScore();
        gameController.UpdateAccuracy();
    }

}
