using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowPanel(GameObject temp)
    {
        temp.SetActive(true);
        LeanTween.alphaCanvas(temp.GetComponent<CanvasGroup>(), 1f, 1f).setFrom(0f).setEase(LeanTweenType.easeInQuad);
    }

    public void HidePanel(GameObject temp)
    {
        LeanTween.alphaCanvas(temp.GetComponent<CanvasGroup>(), 0f, 1f).setFrom(1f).setEase(LeanTweenType.easeInQuad).setOnComplete(() => temp.SetActive(false));
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
