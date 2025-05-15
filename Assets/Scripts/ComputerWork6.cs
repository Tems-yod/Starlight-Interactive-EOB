using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerWork6 : MonoBehaviour
{

    private UIManager UI;

    private DialogueController6 DC6;
   
    

    // Start is called before the first frame update
    void Start()
    {
        
        DC6 = GameObject.Find("Computer1").GetComponent<DialogueController6>();
       

        
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
               DC6.activateCompute7();
            }
           
            
        }
    }
}
