using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhiteOutEffect : MonoBehaviour
{
   public Image image;
   [SerializeField] public GameObject eye;
   private AIController AIController;

   private float percentKilled = 0;
   void Start () 
   {
         AIController = eye.GetComponent<AIController>();

         image = GetComponent<Image>();
         var tempColor = image.color;
         tempColor.a = 0f;
         image.color = tempColor;
   }

    // Update is called once per frame
    void Update()
    {
        percentKilled = (AIController.percentPlayerKilled)/100;

        image = GetComponent<Image>();
        var tempColor = image.color;
        tempColor.a = percentKilled;
        image.color = tempColor;
    }
}
