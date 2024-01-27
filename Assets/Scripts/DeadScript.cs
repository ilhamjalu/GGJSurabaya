using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadScript : MonoBehaviour
{
    public Vector2 firstSpawnPosition;
    public Vector2 secondSpawnPosition;
    
    public Transform firstPlayerPosition;
    public Transform secondPlayerPosition;

    // Start is called before the first frame update
    void Start()
    {
        firstSpawnPosition = firstPlayerPosition.position;
        secondSpawnPosition = secondPlayerPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player 1") 
        {
            collision.gameObject.transform.position = firstSpawnPosition;
        }
        else if(collision.gameObject.name == "Player 2")
        {
            collision.gameObject.transform.position = secondSpawnPosition;
        }
    }
}
