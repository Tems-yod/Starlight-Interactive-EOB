using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DialogueController1 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI DialogueText;
    public string[] Sentences2;
    [SerializeField] private Text Name;
    private int Index = 0;
    private bool runner = false;
    private bool compute2 = false;
    private bool comp2 = false;
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
        Computer2();
    }

    public void activateCompute2()
    {
        dialo.gameObject.SetActive(true);
        Name.text = "Name: Jessica 'Jesse' Bailey";
        comp2 = true;
        compute2 = true;

    }

    private void Computer2()
    {
        if((Input.GetKeyDown(KeyCode.E) && (runner == false && comp2 == true) || compute2 == true))
        {
            runner = true;
            compute2 = false;
            NextSentence2();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences2.Length))
        {
            dialo.gameObject.SetActive(false);
            DialogueText.text = "";
            runner = false;
            comp2 = false;
            Index = 0;
            
            



        }
    }

    void NextSentence2()
    {
        if(Index <= Sentences2.Length - 1)
        {
            DialogueText.text = "";
            StartCoroutine(WriteSentences2());
        }
        
    }

    IEnumerator WriteSentences2()
    {
        foreach(char Character in Sentences2[Index].ToCharArray())
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);
        }
        Index++;
        runner = false;
    }
}
