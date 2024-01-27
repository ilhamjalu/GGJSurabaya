using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WearOutfit : MonoBehaviour
{
    public List<Image> wearMaleOutfit;
    public List<Image> wearFemaleOutfit;

    SaveOutfit saveOutfit;

    // Start is called before the first frame update
    void Start()
    {
        saveOutfit = FindObjectOfType<SaveOutfit>();

        SetOutfit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetOutfit()
    {
        for(int i = 0; i<3; i++)
        {
            wearMaleOutfit[i].sprite = saveOutfit.maleOutfit[i];
            wearFemaleOutfit[i].sprite = saveOutfit.femaleOutfit[i];
        }
    }
}
