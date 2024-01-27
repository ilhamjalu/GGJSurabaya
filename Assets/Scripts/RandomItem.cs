using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomItem : MonoBehaviour
{
    [SerializeField]
    List<Sprite> itemSprite;

    [SerializeField]
    List<Button> randomButton;

    [SerializeField]
    Button nextButton;

    SaveOutfit saveOutfit;

    // Start is called before the first frame update
    void Start()
    {
        saveOutfit = FindObjectOfType<SaveOutfit>();
    }

    // Update is called once per frame
    void Update()
    {
        ActivateNextButton();   
    }

    public void RandomizeItem(Image item)
    {
        int rand = UnityEngine.Random.Range(0, itemSprite.Count);

        item.sprite = itemSprite[rand];

        AddOutfitToList(item);
    }

    void AddOutfitToList(Image item)
    {
        if(item.name == "MaleOutfit")
        {
            saveOutfit.maleOutfit.Add(item.sprite);
        }
        else
        {
            saveOutfit.femaleOutfit.Add(item.sprite);
        }
    }

    public void DisableButton(Button tempButton)
    {
        tempButton.interactable = false;
    }

    void ActivateNextButton()
    {
        foreach(Button temp in randomButton)
        {
            if(temp.interactable == true)
            {
                return;
            }
        }

        nextButton.interactable = true;
    }
}
