using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerWork3 : MonoBehaviour
{
    public int Index = 0;
    private UIManager UI;
    private DialogueController3 DC3;

    // Start is called before the first frame update
    void Start()
    {
       
        DC3 = GameObject.Find("DialogueController3").GetComponent<DialogueController3>();

        
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
               DC3.activateCompute4();
               
               

            }
            
            
        }
    }
    
}
