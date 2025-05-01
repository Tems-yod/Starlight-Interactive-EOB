using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerWork : MonoBehaviour
{
    private int Index = 0;
    private UIManager UI;
    private DialogueController DC;
    // Start is called before the first frame update
    void Start()
    {
        DC = GameObject.Find("DialogueController").GetComponent<DialogueController>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if ((Index == 0 && Input.GetKeyDown(KeyCode.E)))
            {
               DC.activateCompute1();
               Index = 1;

            }
            else if ((Index == 1 && Input.GetKeyDown(KeyCode.E)))
            {
               DC.activateCompute2();
               Index = 2;

            }
            else if ((Index == 2 && Input.GetKeyDown(KeyCode.E)))
            {
               DC.activateCompute3();
               Index = 3;

            }
            else if ((Index == 3 && Input.GetKeyDown(KeyCode.E)))
            {
               DC.activateCompute4();
               Index = 4;

            }
            else if ((Index == 4 && Input.GetKeyDown(KeyCode.E)))
            {
               DC.activateCompute5();
               Index = 5;

            }
            else if ((Index == 5 && Input.GetKeyDown(KeyCode.E)))
            {
               DC.activateCompute6();
               Index = 6;

            }
            else if ((Index == 6 && Input.GetKeyDown(KeyCode.E)))
            {
               DC.activateCompute7();
               Index = 7;

            }
            else if ((Index == 7 && Input.GetKeyDown(KeyCode.E)))
            {
               DC.activateCompute8();
               Index = 8;

            }
            else if ((Index == 8 && Input.GetKeyDown(KeyCode.E)))
            {
               DC.activateCompute9();
               Index = 9;

            }
        }
    }
}
