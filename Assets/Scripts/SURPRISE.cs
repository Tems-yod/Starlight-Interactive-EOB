using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SURPRISE : MonoBehaviour
{

    [SerializeField] public GameObject eye;
    [SerializeField] public int waitTimer = 15;
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
		Debug.Log("HIT TRIGGER");
        eye.SetActive(true);
        Destroy(gameObject);
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(!doOnce)

                {
                    doOnce = true;
                    StartCoroutine(TriggerInteraction());
                }
           

            
        }
    }

}
