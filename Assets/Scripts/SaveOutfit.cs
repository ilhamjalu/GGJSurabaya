using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveOutfit : MonoBehaviour
{
    public List<Sprite> maleOutfit = new List<Sprite>();
    public List<Sprite> femaleOutfit = new List<Sprite>();

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
