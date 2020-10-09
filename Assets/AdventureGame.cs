using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AdventureGame : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text textComponent;
    void Start()
    {
        textComponent.text = "Programically added text!!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
