using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WhiteOutEffect : MonoBehaviour
{
   public Image image;
   [SerializeField] public GameObject eye;
   private AIController AIController;
   AudioSource EyeSound;
   private float percentKilled = 0;
   void Start () 
   {
         EyeSound = GetComponent<AudioSource>();
         AIController = eye.GetComponent<AIController>();

         image = GetComponent<Image>();
         var tempColor = image.color;
         tempColor.a = 0f;
         image.color = tempColor;
   }

    // Update is called once per frame
    void Update()
    {
        percentKilled = (AIController.percentPlayerKilled)/200;
     
        image = GetComponent<Image>();
        var tempColor = image.color;
        tempColor.a = percentKilled;
        image.color = tempColor;

        if(percentKilled>.01 && percentKilled<.09)
        {
            EyeSound.Play(0);
        }
        if(percentKilled >= 1)
        {
            Debug.Log("Quitting...");
            SceneManager.LoadScene("EOBZeroGrav");
        }
    }
}
