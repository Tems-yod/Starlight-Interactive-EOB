using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{

    [SerializeField] public GameObject text;
    [SerializeField] public int waitTimer = 8;
    private bool doOnce = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator TriggerInteraction()
	{
		yield return new WaitForSeconds(waitTimer);
		Application.Quit();
	}
 

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(!doOnce)

                {
                    text.SetActive(true);
                    doOnce = false;
                    TriggerInteraction();
                }
           

            
        }
    }

}
