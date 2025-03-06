using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] public GameObject obtained;

    [SerializeField] public GameObject textObtained;
    public bool textGo = false;
    public bool item = false; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(item == true)
        {
            obtained.gameObject.SetActive(true);
        }
        if(textGo == true)
        {
            textObtained.gameObject.SetActive(true);

        }
        if(item == true && textGo == true)
        {
            textObtained.gameObject.SetActive(false);
        }
    }
}
