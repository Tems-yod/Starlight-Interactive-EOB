using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueController3 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI DialogueText;
    public string[] Sentences4;
    [SerializeField] private Text Name;
    private int Index = 0;
    private bool runner = false;
    private bool compute4 = false;
    private bool comp4 = false;
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
        Computer4();
        
    }

    public void activateCompute4()
    {
        dialo.gameObject.SetActive(true);
        Name.text = "Name: Grady Baxter";
        comp4 = true;
        

    }

    private void Computer4()
    {
        if((Input.GetKeyDown(KeyCode.E) && runner == false && comp4 == true))
        {
            runner = true;
            
            NextSentence4();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences4.Length))
        {
            dialo.gameObject.SetActive(false);
            DialogueText.text = "";
            runner = false;
            comp4 = false;
            Index = 0;
            
            



        }
    }

    void NextSentence4()
    {
        if(Index <= Sentences4.Length - 1)
        {
            DialogueText.text = "";
            StartCoroutine(WriteSentences4());
        }
        
    }

    IEnumerator WriteSentences4()
    {
        foreach(char Character in Sentences4[Index].ToCharArray())
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);
        }
        Index++;
        runner = false;
    }
}