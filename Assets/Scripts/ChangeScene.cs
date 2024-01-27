using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.FindObjectOfType<Canvas>();
        LeanTween.alphaCanvas(canvas.GetComponent<CanvasGroup>(), 1f, 1f).setFrom(0f).setEase(LeanTweenType.easeOutQuad);
    }

    [ContextMenu("TestChangeScene")]
    public void GoToNextScene()
    {
        int scene = SceneManager.GetActiveScene().buildIndex + 1;
        if (canvas.GetComponent<CanvasGroup>() != null)
        {
            LeanTween.alphaCanvas(canvas.GetComponent<CanvasGroup>(), 0f, 1f).setFrom(1f).setEase(LeanTweenType.easeOutQuad).setOnComplete(() => SceneManager.LoadScene(scene));
        }
    }

    public void GoToMainMenu()
    {
        LeanTween.alphaCanvas(canvas.GetComponent<CanvasGroup>(), 0f, 1f).setFrom(1f).setEase(LeanTweenType.easeOutQuad).setOnComplete(() => SceneManager.LoadScene("Main_Menu"));

    }
}
