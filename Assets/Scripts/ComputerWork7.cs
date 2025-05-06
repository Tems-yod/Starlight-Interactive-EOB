using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerWork7 : MonoBehaviour
{

    private DialogueController7 DC7;
    private DialogueController8 DC8;

    // Start is called before the first frame update
    void Start()
    {
        
        DC7 = GameObject.Find("DialogueController7").GetComponent<DialogueController7>();
        

        
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
               DC7.activateCompute8();
               
               

            }
            
            
        }
    }
    
}
