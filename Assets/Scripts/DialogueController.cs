using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.UI;

public class DialogueController : MonoBehaviour
{
    public TextMeshProUGUI DialogueText;
    public string[] Sentences;
    private int Index = 0;
    [SerializeField] private Text yes;
    public float DialogueSpeed;
    [SerializeField] private GameObject dialo;
    private bool run = false;
    private bool yip = false;
    
    

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        popUp();
        Text1();
        
    
    }
    private void popUp()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            dialo.gameObject.SetActive(true);
            yip = true;
            yes.text = "Name: Kris Bellaren";
        }

    }

    private void Text1()
    {
        if ((Input.GetKeyDown(KeyCode.E) && run == false) || yip == true)
        {
            run = true;
            yip = false;
            NextSentence();

        }
        else if (Input.GetKeyDown(KeyCode.E) && Index == Sentences.Length)
        {
            dialo.gameObject.SetActive(false);
            DialogueText.text = "";
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
        run = false;
    }

   

}
