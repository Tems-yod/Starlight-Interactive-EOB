using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueController8 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI DialogueText;
    public string[] Sentences9;
    [SerializeField] private Text Name;
    private int Index = 0;
    private bool runner = false;
    private bool compute9 = false;
    private bool comp9 = false;
    public float DialogueSpeed;
    [SerializeField] private GameObject dialo;
    private UIManager UI;
    private ComputerWork CW;
    // Start is called before the first frame update
    void Start()
    {
        UI = GameObject.Find("UIManager").GetComponent<UIManager>();
        CW = GameObject.Find("EyeComputer").GetComponent<ComputerWork>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Computer9();
        
    }

    public void activateCompute9()
    {
        dialo.gameObject.SetActive(true);
        Name.text = "Name: Montomgery Fletcher";
        UI.changeUP();
        comp9 = true;
        compute9 = true;

    }

    private void Computer9()
    {
        if((Input.GetKeyDown(KeyCode.E) && runner == false && comp9 == true) || compute9 == true)
        {
            runner = true;
            compute9 = false;
            NextSentence9();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences9.Length))
        {
            UI.changeBack();
            DialogueText.text = "";
            runner = false;
            comp9 = false;
            Index = 0;
            
            



        }
    }

    void NextSentence9()
    {
        if(Index <= Sentences9.Length - 1)
        {
            DialogueText.text = "";
            StartCoroutine(WriteSentences9());
        }
        
    }

    IEnumerator WriteSentences9()
    {
        foreach(char Character in Sentences9[Index].ToCharArray())
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);
        }
        Index++;
        runner = false;
    }
}
