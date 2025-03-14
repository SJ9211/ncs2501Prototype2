using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverAction : UnityEngine.Events.UnityEvent{}
public class DestroyOutOfBounds : MonoBehaviour
{
    // private SpawanManager sm;
    public delegate void GameOverHandler();
    public static event GameOverHandler OnGameOver;
    //public static GameOverAction OnGameOver = new GameOverAction();

    private float topBound = 30;
    private float lowerBound = -10;
    void Start()
    {
        // sm = GameObject.FindGameObjectWithTag("SM").GetComponent<SpawanManager>();
    }


    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            //Debug.Log("Game Over!");
            //sm.DisplayGameOver();
            OnGameOver();

            Destroy(gameObject);
        }
    }
}
