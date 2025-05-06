using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerWork1 : MonoBehaviour
{
    public int Index = 0;
    private UIManager UI;
    private DialogueController1 DC1;

    // Start is called before the first frame update
    void Start()
    {
        DC1 = GameObject.Find("DialogueController1").GetComponent<DialogueController1>();


        
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
               DC1.activateCompute2();
               
            }
            
            
        }
    }
    
}
