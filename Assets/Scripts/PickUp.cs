using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private UIManager UI;
    // Start is called before the first frame update
    void Start()
    {
        UI = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            
            UI.textGo = true;

            if(Input.GetKeyDown(KeyCode.F))
            {
                
                UI.item = true;
                Destroy(gameObject);
            }
        }
    }
}
