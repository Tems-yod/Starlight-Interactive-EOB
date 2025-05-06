using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueController5 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI DialogueText;
    [SerializeField] private GameObject dialo;
    public string[] Sentences6;
    [SerializeField] private Text Name;
    private int Index = 0;
    private bool runner = false;
    private bool compute6 = false;
    private bool comp6 = false;
    public float DialogueSpeed;
    private ComputerWork CW;
    private UIManager UI;
    // Start is called before the first frame update
    void Start()
    {
        UI = GameObject.Find("UIManager").GetComponent<UIManager>();
        CW = GameObject.Find("EyeComputer").GetComponent<ComputerWork>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Computer6();
        
    }
public void activateCompute6()
    {
        dialo.gameObject.SetActive(true);
        Name.text = "Name: Mongomery Fletcher";
        UI.changeUP();
        comp6 = true;
        compute6 = true;

    }

    private void Computer6()
    {
        if((Input.GetKeyDown(KeyCode.E) && runner == false && comp6 == true) || compute6 == true)
        {
            runner = true;
            compute6 = false;
            NextSentence6();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences6.Length))
        {
            UI.changeBack();
            DialogueText.text = "";
            runner = false;
            comp6 = false;
            Index = 0;
            
            



        }
    }

    void NextSentence6()
    {
        if(Index <= Sentences6.Length - 1)
        {
            DialogueText.text = "";
            StartCoroutine(WriteSentences6());
        }
        
    }

    IEnumerator WriteSentences6()
    {
        foreach(char Character in Sentences6[Index].ToCharArray())
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);
        }
        Index++;
        runner = false;
    }
}
