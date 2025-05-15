using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI DialogueText;
    public string[] Sentences;

    [SerializeField] private Text Name;
    private int Index = 0;
    private bool runner = false;
    private bool compute1 = false;
    private bool comp = false;
    public float DialogueSpeed;
    [SerializeField] private GameObject dialo;
    
    private UIManager UI;
    private ComputerWork CW;

    
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        
        
    
    }

    // Update is called once per frame
    void Update()
    {
        Computer();
        
        
    
    }
    public void activateCompute1()
    {
        dialo.gameObject.SetActive(true);
        Name.text = "Name: Kris Bellaren";
        
        comp = true;

    }

    

    private void Computer()
    {
        if((Input.GetKeyDown(KeyCode.E) && comp == true && runner == false))
        {
            runner = true;
            NextSentence();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences.Length))
        {
            dialo.gameObject.SetActive(false);
            DialogueText.text = "Entry Accepted: Press 'E' to continue";
            runner = false;
            Index = 0;
            



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
            
            yield return new WaitForSeconds(DialogueSpeed);
            DialogueText.text += Character;
        }
        Index++;
        runner = false;
        
        
        
        
    }

    

    

    

    
   

}
