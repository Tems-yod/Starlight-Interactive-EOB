using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueController6 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI DialogueText;
    public string[] Sentences7;
    [SerializeField] private Text Name;
    private int Index = 0;
    private bool runner = false;
    private bool compute7 = false;
    private bool comp7 = false;
    [SerializeField] private GameObject dialo;
    public float DialogueSpeed;
    private UIManager UI;
    private ComputerWork CW;
    // Start is called before the first frame update
    void Start()
    {
        UI = GameObject.Find("UIManager").GetComponent<UIManager>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Computer7();
        
    }
    public void activateCompute7()
    {
        dialo.gameObject.SetActive(true);
        Name.text = "Name: Grady Baxter";
        UI.changeUP();
        comp7 = true;
        compute7 = true;

    }

    private void Computer7()
    {
        if((Input.GetKeyDown(KeyCode.E) && runner == false && comp7 == true) || compute7 == true)
        {
            runner = true;
            compute7 = false;
            NextSentence7();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences7.Length))
        {
            UI.changeBack();
            DialogueText.text = "";
            runner = false;
            comp7 = false;
            Index = 0;
            
            



        }
    }

    void NextSentence7()
    {
        if(Index <= Sentences7.Length - 1)
        {
            DialogueText.text = "";
            StartCoroutine(WriteSentences7());
        }
        
    }

    IEnumerator WriteSentences7()
    {
        foreach(char Character in Sentences7[Index].ToCharArray())
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);
        }
        Index++;
        runner = false;
    }
}