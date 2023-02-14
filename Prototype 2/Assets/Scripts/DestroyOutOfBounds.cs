using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    float lowerBound = -10f;
    float topBound = 30f;
    float bound = 13f;
    float rightBound = -13f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            print("Game Over1");
            Destroy(gameObject);
        }
        else if(transform.position.x > bound)
        {
            print("gameOver2");
            Destroy(gameObject);
        }
        else if (transform.position.x < rightBound)
        {
            print("gameover3");
            Destroy(gameObject);
        }
    }
}

