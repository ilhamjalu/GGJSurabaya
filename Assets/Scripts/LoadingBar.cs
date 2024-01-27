using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadingBar : MonoBehaviour
{
    [SerializeField]
    Slider loading;

    [SerializeField]
    TextMeshProUGUI loadingText;

    [SerializeField]
    ChangeScene changeScene;
    
    // Start is called before the first frame update
    void Start()
    {
        loading = gameObject.GetComponent<Slider>();

        StartCoroutine(LoadingAnimation());
    }

    // Update is called once per frame
    void Update()
    {
        MoveLoadingBar();
    }

    void MoveLoadingBar()
    {
        loading.value += 1f * Time.deltaTime;

        if(loading.value >= loading.maxValue)
        {
            changeScene.GoToNextScene();
        }
    }

    IEnumerator LoadingAnimation()
    {
        WaitForSeconds delay = new WaitForSeconds(0.5f);

        while(loading.value < loading.maxValue) 
        {
            loadingText.text = "Loading";
            yield return delay;
            loadingText.text = "Loading .";
            yield return delay;
            loadingText.text = "Loading . .";
            yield return delay;
            loadingText.text = "Loading . . .";
            yield return delay;
        }
    }
}
