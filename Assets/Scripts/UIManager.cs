using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] public GameObject obtained;

    [SerializeField] public GameObject textObtained;
    [SerializeField] private GameObject titleScreen;
    [SerializeField] private GameObject reticle;
    [SerializeField] private GameObject PlayerUI;
    [SerializeField] private GameObject ChangingUI;
    
    public bool textGo = false;
    public bool item = false; 
    // Start is called before the first frame update
    void Start()
    {
        titleScreen.gameObject.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            titleScreen.gameObject.SetActive(false);
            PlayerUI.gameObject.SetActive(true);
        }
    }

    public void changeUP()
    {
        ChangingUI.gameObject.SetActive(false);
        

    }
    public void changeBack()
    {
        ChangingUI.gameObject.SetActive(true);
        
    }
    
}