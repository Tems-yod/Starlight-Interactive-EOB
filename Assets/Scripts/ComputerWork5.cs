using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerWork5 : MonoBehaviour
{
    private DialogueController5 DC5;


    // Start is called before the first frame update
    void Start()
    {
       
        DC5 = GameObject.Find("Computer_EyeShape (2)").GetComponent<DialogueController5>();
        

        
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
               DC5.activateCompute6();
               
               

            }
            
            
        }
    }
   
}
