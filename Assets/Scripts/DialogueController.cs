using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueController : MonoBehaviour
{
    public TextMeshProUGUI DialogueText;
    public string[] Sentences;
    public string[] Sentences2;
    public string[] Sentences3;
    public string[] Sentences4;
    public string[] Sentences5;
    public string[] Sentences6;
    public string[] Sentences7;
    public string[] Sentences8;
    public string[] Sentences9;
    [SerializeField] private Text Name;
    private int Index = 0;
    private bool runner = false;
    private bool compute1 = false;
    private bool compute2 = false;
    private bool compute3 = false;
    private bool compute4 = false;
    private bool compute5 = false;
    private bool compute6 = false;
    private bool compute7 = false;
    private bool compute8 = false;
    private bool compute9 = false;
    private bool comp = false;
    private bool comp2 = false;
    private bool comp3 = false;
    private bool comp4 = false;
    private bool comp5 = false;
    private bool comp6 = false;
    private bool comp7 = false;
    private bool comp8 = false;
    private bool comp9 = false;
    public float DialogueSpeed;
    [SerializeField] private ZeroGravity P;
    private UIManager UI;

    
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        P = GameObject.Find("Player").GetComponent<ZeroGravity>();
        UI = GameObject.Find("UIManager").GetComponent<UIManager>();
    
    }

    // Update is called once per frame
    void Update()
    {
        Computer();
        Computer2();
        Computer3();
        Computer4();
        Computer5();
        Computer6();
        Computer7();
        Computer8();
        Computer9();

    
    }
    public void activateCompute1()
    {
        Name.text = "Name: Kris Bellaren";
        UI.changeUP();
        comp = true;
        compute1 = true;

    }
    public void activateCompute2()
    {
        Name.text = "Name: Jessica 'Jesse' Bailey";
        UI.changeUP();
        comp2 = true;
        compute2 = true;

    }
        public void activateCompute3()
    {
        Name.text = "Name: Kris Bellaren";
        UI.changeUP();
        comp3 = true;
        compute3 = true;

    }
        public void activateCompute4()
    {
        Name.text = "Name: Grady Baxter";
        UI.changeUP();
        comp4 = true;
        compute4 = true;

    }
    public void activateCompute5()
    {
        Name.text = "Name: Johannes Rault";
        UI.changeUP();
        comp5 = true;
        compute5 = true;

    }
    public void activateCompute6()
    {
        Name.text = "Name: Mongomery Fletcher";
        UI.changeUP();
        comp6 = true;
        compute6 = true;

    }
    public void activateCompute7()
    {
        Name.text = "Name: Grady Baxter";
        UI.changeUP();
        comp7 = true;
        compute7 = true;

    }
    public void activateCompute8()
    {
        Name.text = "Name: Johannes Rault";
        UI.changeUP();
        comp8 = true;
        compute8 = true;

    }
    public void activateCompute9()
    {
        Name.text = "Name: Montomgery Fletcher";
        UI.changeUP();
        comp9 = true;
        compute9 = true;

    }

    private void Computer()
    {
        if((Input.GetKeyDown(KeyCode.E) && runner == false && comp == true) || compute1 == true)
        {
            runner = true;
            compute1 = false;
            NextSentence();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences.Length))
        {
            UI.changeBack();
            runner = false;
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
        runner = false;
    }

    private void Computer2()
    {
        if((Input.GetKeyDown(KeyCode.E) && runner == false && comp2 == true) || compute2 == true)
        {
            runner = true;
            compute2 = false;
            NextSentence2();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences2.Length))
        {
            UI.changeBack();
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

    private void Computer3()
    {
        if((Input.GetKeyDown(KeyCode.E) && runner == false && comp3 == true) || compute3 == true)
        {
            runner = true;
            compute3 = false;
            NextSentence3();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences3.Length))
        {
            UI.changeBack();
            runner = false;
            comp3 = false;
            Index = 0;
            



        }
    }

    void NextSentence3()
    {
        if(Index <= Sentences.Length - 1)
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

    private void Computer4()
    {
        if((Input.GetKeyDown(KeyCode.E) && runner == false && comp4 == true) || compute4 == true)
        {
            runner = true;
            compute4 = false;
            NextSentence4();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences4.Length))
        {
            UI.changeBack();
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

    private void Computer5()
    {
        if((Input.GetKeyDown(KeyCode.E) && runner == false) || compute5 == true)
        {
            runner = true;
            compute5 = false;
            NextSentence5();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences5.Length))
        {
            UI.changeBack();
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

    private void Computer6()
    {
        if((Input.GetKeyDown(KeyCode.E) && runner == false) || compute6 == true)
        {
            runner = true;
            compute6 = false;
            NextSentence6();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences6.Length))
        {
            UI.changeBack();
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

    private void Computer7()
    {
        if((Input.GetKeyDown(KeyCode.E) && runner == false) || compute7 == true)
        {
            runner = true;
            compute7 = false;
            NextSentence7();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences7.Length))
        {
            UI.changeBack();
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

    private void Computer8()
    {
        if((Input.GetKeyDown(KeyCode.E) && runner == false) || compute8 == true)
        {
            runner = true;
            compute8 = false;
            NextSentence8();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences8.Length))
        {
            UI.changeBack();
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

    private void Computer9()
    {
        if((Input.GetKeyDown(KeyCode.E) && runner == false) || compute9 == true)
        {
            runner = true;
            compute9 = false;
            NextSentence9();

        }
        else if ((Input.GetKeyDown(KeyCode.E) && Index == Sentences9.Length))
        {
            UI.changeBack();
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
