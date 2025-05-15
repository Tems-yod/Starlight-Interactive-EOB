using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueController2 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI DialogueText;
    public string[] Sentences3;
    [SerializeField] private Text Name;
    private int Index = 0;
    private bool runner = false;
    private bool compute3 = false;
    private bool comp3 = false;
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
        Computer3();
        
    }

    public void activateCompute3()
    {
        dialo.gameObject.SetActive(true);
        Name.text = "Name: Kris Bellaren";
        comp3 = true;
        

    }

    private void Computer3()
    {
        if((Input.GetKeyDown(KeyCode.E) && (runner == false && comp3 == true)))
        {
            runner = true;
            
            NextSentence3();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences3.Length))
        {
            dialo.gameObject.SetActive(false);
            DialogueText.text = "";
            runner = false;
            comp3 = false;
            Index = 0;
            
            



        }
    }

    void NextSentence3()
    {
        if(Index <= Sentences3.Length - 1)
        {
            DialogueText.text = "";
            StartCoroutine(WriteSentences3());
        }
        
    }

    IEnumerator WriteSentences3()
    {
        foreach(char Character in Sentences3[Index].ToCharArray())
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);
        }
        Index++;
        runner = false;
    }
}
