using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerWork4 : MonoBehaviour
{
    public int Index = 0;
    private UIManager UI;

    private DialogueController4 DC4;
    

    // Start is called before the first frame update
    void Start()
    {
       
        DC4 = GameObject.Find("DialogueController4").GetComponent<DialogueController4>();
        

        
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
               DC4.activateCompute5();  

            }
            
            
        }
    }
    
}
