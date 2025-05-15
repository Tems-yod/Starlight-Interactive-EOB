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
    private int Index1 = 0;
    private bool runner1 = false;
    private bool compute2 = false;
    private bool comp2 = false;
    public float DialogueSpeed1;
    [SerializeField] private GameObject dialoque;
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
        dialoque.gameObject.SetActive(true);
        Name.text = "Name: Jessica 'Jesse' Bailey";
        comp2 = true;
        

    }

    private void Computer2()
    {
        if((Input.GetKeyDown(KeyCode.E) && (runner1 == false && comp2 == true)))
        {
            runner1 = true;
            
            NextSentence2();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index1 == Sentences2.Length))
        {
            dialoque.gameObject.SetActive(false);
            DialogueText.text = "Entry Accepted: Press 'E' to continue";
            runner1 = false;
            comp2 = false;
            Index1 = 0;
            
            



        }
    }

    void NextSentence2()
    {
        if(Index1 <= Sentences2.Length - 1)
        {
            DialogueText.text = "";
            StartCoroutine(WriteSentences2());
        }
        
    }

    IEnumerator WriteSentences2()
    {
        foreach(char Character in Sentences2[Index1].ToCharArray())
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed1);
        }
        Index1++;
        runner1 = false;
    }
}
