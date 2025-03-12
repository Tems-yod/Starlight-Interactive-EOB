using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueController : MonoBehaviour
{
    public TextMeshProUGUI DialogueText;
    public string[] Sentences;
    private int Index = 0;
    public float DialogueSpeed;
    [SerializeField] private ZeroGravity P;
    [SerializeField] private GameObject dialo;
    
    

    // Start is called before the first frame update
    void Start()
    {
        P = GameObject.Find("Player").GetComponent<ZeroGravity>();
    
    }

    // Update is called once per frame
    void Update()
    {
        if (P.containment)
        {
            dialo.SetActive(true);
            if(Input.GetKeyDown(KeyCode.Space))
            {
           
            NextSentence();
            }
        
        if(Index >= Sentences.Length)
        {
            P.dialogue = true;
            dialo.SetActive(false);
            
        }
        }
    
    }

    void NextSentence()
    {
        if(Index <= Sentences.Length - 1)
        {
            DialogueText.text = "";
            StartCoroutine(WriteSentences());
        }
        
    }

    IEnumerator WriteSentences()
    {
        foreach(char Character in Sentences[Index].ToCharArray())
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);
        }
        Index++;
    }

    void working()
    {
        if(P.containment)
        {
            dialo.gameObject.SetActive(true);
        }
    }

   

}
