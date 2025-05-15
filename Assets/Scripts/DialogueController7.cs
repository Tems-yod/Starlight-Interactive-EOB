using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueController7 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI DialogueText;
    public string[] Sentences8;
    [SerializeField] private Text Name;
    private int Index = 0;
    private bool runner = false;
    private bool compute8 = false;
    private bool comp8 = false;
    [SerializeField] private GameObject dialo;
    public float DialogueSpeed;
    private ComputerWork CW;
    private UIManager UI;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        Computer8();
        
    }

    public void activateCompute8()
    {
        dialo.gameObject.SetActive(true);
        Name.text = "Name: Johannes Rault";
        comp8 = true;

    }

    private void Computer8()
    {
        if((Input.GetKeyDown(KeyCode.E) && (runner == false && comp8 == true)))
        {
            runner = true;
            NextSentence8();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences8.Length))
        {
            dialo.gameObject.SetActive(false);
            DialogueText.text = "";
            runner = false;
            comp8 = false;
            Index = 0;
            



        }
    }

    void NextSentence8()
    {
        if(Index <= Sentences8.Length - 1)
        {
            DialogueText.text = "";
            StartCoroutine(WriteSentences8());
        }
        
    }

    IEnumerator WriteSentences8()
    {
        foreach(char Character in Sentences8[Index].ToCharArray())
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);
        }
        Index++;
        runner = false;
    }
}