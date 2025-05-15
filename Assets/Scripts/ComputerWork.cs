using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerWork : MonoBehaviour
{
    public int Index = 0;
    private UIManager UI;
    private DialogueController DC;

    // Start is called before the first frame update
    void Start()
    {
        DC = GameObject.Find("Computer6").GetComponent<DialogueController>();
        

        
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
               DC.activateCompute1();

            }
            
            
        }
    }

}
