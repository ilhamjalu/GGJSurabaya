using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPointScript : MonoBehaviour
{
    [SerializeField]
    Slider healthSlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DecreaseHealthPoint();
        }
    }

    void DecreaseHealthPoint()
    {
        healthSlider.value -= 10;

        if(healthSlider.value <= 0)
        {
            Debug.Log("Game Over");
        }
    }
}
