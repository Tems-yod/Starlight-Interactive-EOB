using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerWork8 : MonoBehaviour
{
    public int Index = 0;
    private UIManager UI;
    private DialogueController DC;
    private DialogueController1 DC1;
    private DialogueController2 DC2;
    private DialogueController3 DC3;
    private DialogueController4 DC4;
    private DialogueController5 DC5;
    private DialogueController6 DC6;
    private DialogueController7 DC7;
    private DialogueController8 DC8;

    // Start is called before the first frame update
    void Start()
    {

        DC8 = GameObject.Find("Computer3").GetComponent<DialogueController8>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            
            if ((Input.GetKeyDown(KeyCode.E)))
            {
               DC8.activateCompute9();
            }
            
        }
    }
}
