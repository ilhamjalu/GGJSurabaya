using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int playerCount;
    public ButtonManager buttonManager;
    public GameObject randomPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsLevelDone())
        {
            randomPanel.SetActive(true);
            playerCount = 0;
        }
    }

    bool IsLevelDone()
    {
        if(playerCount == 2)
        {
            return true;
        }
        return false;
    }
}
