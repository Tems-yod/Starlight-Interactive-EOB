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
    [SerializeField] private ZeroGravity P;
    private UIManager UI;
    private ComputerWork CW;

    
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        P = GameObject.Find("Player").GetComponent<ZeroGravity>();
        
    
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
        
        compute1 = true;

    }

    

    private void Computer()
    {
        if((Input.GetKeyDown(KeyCode.E) && comp == true && runner == false) || compute1 == true)
        {
            runner = true;
            compute1 = false;
            NextSentence();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences.Length && runner == false))
        {
            dialo.gameObject.SetActive(false);
            DialogueText.text = "";
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
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);

            
            
        
        }
        Index++;
        StartCoroutine(runtime());
        
        
        
    }

    IEnumerator runtime()
    {
        runner = false;
        yield return new WaitForSeconds(5.0f);
        
    }

    

    

    
   

}
