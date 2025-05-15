using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerWork2 : MonoBehaviour
{
    public int Index = 0;
    private UIManager UI;

    private DialogueController2 DC2;
    

    // Start is called before the first frame update
    void Start()
    {
        
        DC2 = GameObject.Find("Computer_EyeShape").GetComponent<DialogueController2>();


        
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
               DC2.activateCompute3();
               
            }
            
            
        }
    }
    
}
