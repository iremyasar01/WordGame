using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gm : MonoBehaviour
{
    public static string CurrentWord;
    public Transform SpelledWord;
    public KeyCode RMB; //rightmost button
    public Transform LetterH;
    public Transform LetterE;
    public Transform LetterA;
    public Transform LetterR;
    public Transform LetterT;
    public Transform LetterL;
    
    public Transform BottomL1Obj;//Bottom Letter object
    public Transform BottomL2Obj;
    public Transform BottomL3Obj;
    public Transform BottomL4Obj;
    public Transform BottomL5Obj;
    public Transform BottomL6Obj;
    

    
    //Avaible Letter
    public List<string> AvailLetter1 = new List<string>() { "L" };
    public List<string> AvailLetter2 = new List<string>() { "E" };
    public List<string> AvailLetter3 = new List<string>() { "H" };
    public List<string> AvailLetter4 = new List<string>() { "T" };
    public List<string> AvailLetter5 = new List<string>() { "A" };
    public List<string> AvailLetter6 = new List<string>() { "R" };

    public int WordLen;
    public string word5l = "HEART";
    public string wordl4l = "HEAT";
    public string word4l2 = "HATE";
    public static List<string> SelectLetter = new List<string>() { " ", " ", " ", " ", " ", " " };
    public static int LetterNum = 0;

    void Start()
    {
        BottomL1Obj.GetComponent<TextMeshPro>().text = AvailLetter1[0];
        BottomL2Obj.GetComponent<TextMeshPro>().text = AvailLetter2[0];
        BottomL3Obj.GetComponent<TextMeshPro>().text = AvailLetter3[0];
        BottomL4Obj.GetComponent<TextMeshPro>().text = AvailLetter4[0];
        BottomL5Obj.GetComponent<TextMeshPro>().text = AvailLetter5[0];
        BottomL6Obj.GetComponent<TextMeshPro>().text = AvailLetter6[0];




    }


    void Update()
    {
        SpelledWord.GetComponent<TextMeshPro>().text = CurrentWord;

        if (Input.GetKeyDown(RMB))
        {
            WordLen = CurrentWord.Length;
            Debug.Log(WordLen);
        }
        if (WordLen == 4)
        {
            if (CurrentWord == wordl4l || CurrentWord == word4l2)
            {
                Debug.Log("Correct 4 letter");
            }
            else
            {
                Debug.Log("Wrong 4 letter");
            }

        }
        if (WordLen == 5)
        {
            if (CurrentWord == word5l)
            {
                Debug.Log("Correct 5 letter");

                

                LetterH.GetComponent<TextMeshPro>().text = SelectLetter[1];
                LetterE.GetComponent<TextMeshPro>().text = SelectLetter[2];
                LetterA.GetComponent<TextMeshPro>().text = SelectLetter[3];
                LetterR.GetComponent<TextMeshPro>().text = SelectLetter[4];
                LetterT.GetComponent<TextMeshPro>().text = SelectLetter[5];
              


            }
            else
            {
                Debug.Log("Wrong 5 letter");
            }
        }
    }
}

