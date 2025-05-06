using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueController4 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI DialogueText;
    public string[] Sentences5;
    [SerializeField] private Text Name;
    private int Index = 0;
    private bool runner = false;
    private bool compute5 = false;
    private bool comp5 = false;
    public float DialogueSpeed;
    [SerializeField] private GameObject dialo;
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
        Computer5();
        
    }

    public void activateCompute5()
    {
        dialo.gameObject.SetActive(true);
        Name.text = "Name: Johannes Rault";
        UI.changeUP();
        comp5 = true;
        compute5 = true;

    }

    private void Computer5()
    {
        if((Input.GetKeyDown(KeyCode.E) && runner == false && comp5 == true) || compute5 == true)
        {
            runner = true;
            compute5 = false;
            NextSentence5();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences5.Length))
        {
            UI.changeBack();
            DialogueText.text = "";
            runner = false;
            comp5 = false;
            Index = 0;
            



        }
    }

    void NextSentence5()
    {
        if(Index <= Sentences5.Length - 1)
        {
            DialogueText.text = "";
            StartCoroutine(WriteSentences5());
        }
        
    }

    IEnumerator WriteSentences5()
    {
        foreach(char Character in Sentences5[Index].ToCharArray())
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);
        }
        Index++;
        runner = false;
    }
}
