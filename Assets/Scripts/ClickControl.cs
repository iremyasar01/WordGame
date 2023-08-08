using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ClickControl : MonoBehaviour
{


    void Start()
    {



    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Gm.CurrentWord = "";
            Gm.LetterNum = 0;
            Debug.Log("space key was pressed");


        }


    }

    private void OnMouseDown()
    {
        Gm.CurrentWord += GetComponent<TextMeshPro>().text;
        if (!Gm.CorrectWordsList.Contains(Gm.CurrentWord)) { 
        Gm.LetterNum += 1;
        Gm.SelectLetter[Gm.LetterNum] = GetComponent<TextMeshPro>().text;
        Debug.Log(Gm.CurrentWord);
        Gm.CorrectWordsList.Add(Gm.CurrentWord);
        }



       else {
            Debug.Log("You're wrong");
        }
    }
}
        
    

   

    





